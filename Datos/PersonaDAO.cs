using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace clubDeportivo.Datos
{
    internal class Persona_DAO
    {
        // Método para verificar si un documento ya existe en cualquier tabla
        public bool DocumentoExiste(string documento)
        {
            MySqlConnection? sqlCon = null;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Verificar en tabla socio
                string querySocio = "SELECT COUNT(*) FROM socio WHERE Documento = @documento";
                MySqlCommand cmdSocio = new MySqlCommand(querySocio, sqlCon);
                cmdSocio.Parameters.AddWithValue("@documento", documento);
                int countSocio = Convert.ToInt32(cmdSocio.ExecuteScalar());

                if (countSocio > 0) return true;

                // Verificar en tabla nosocio
                string queryNoSocio = "SELECT COUNT(*) FROM nosocio WHERE Documento = @documento";
                MySqlCommand cmdNoSocio = new MySqlCommand(queryNoSocio, sqlCon);
                cmdNoSocio.Parameters.AddWithValue("@documento", documento);
                int countNoSocio = Convert.ToInt32(cmdNoSocio.ExecuteScalar());

                return countNoSocio > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar documento: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        // Método para inscribir un SOCIO
        public bool InscribirSocio(string nombre, string apellido, string documento,
                                    string telefono, DateTime FNacimiento, bool aptoFisico)
        {
            MySqlConnection? sqlCon = null;
            MySqlTransaction? transaccion = null;

            try
            {
                // Verificar si el documento ya existe
                if (DocumentoExiste(documento))
                {
                    MessageBox.Show("El documento ya está registrado en el sistema",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                transaccion = sqlCon.BeginTransaction(); // Inicia la transacción

                string querySocio = @"INSERT INTO socio (Nombre, Apellido, Documento, Telefono, FechaNacimiento, AptoFisico, FechaInscripcion, Activo)  +
                                     VALUES (@nombre, @apellido, @documento, @telefono, @fechaNacimiento, @aptoFisico, @fInscripcion, @activo)";
                // "SELECT LAST_INSERT_ID();"; // Obtiene el IdSocio recien creado

                MySqlCommand comando = new MySqlCommand(querySocio, sqlCon);
                comando.Transaction = transaccion;

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", FNacimiento.Date);
                comando.Parameters.AddWithValue("@aptoFisico", aptoFisico);
                //DateTime fInscripcion = DateTime.Now.Date;
                comando.Parameters.AddWithValue("@fInscripcion", DateTime.Now.Date);
                comando.Parameters.AddWithValue("@activo", 1);

                // Ejecuta y obtiene el IdSocio
                int IdSocio = Convert.ToInt32(comando.ExecuteScalar());

                // Crea la primera cuota
                DateTime fechaVencimientoCuota = DateTime.Now.Date.AddMonths(1);
                decimal importeCuota = 20000m;

                MySqlCommand comandoCuota = new MySqlCommand(
                    @"INSERT INTO cuota (IdSocio, Documento, FechaPagoCuota, FechaVencimientoCuota, importeCuota, ImporteAdeudado)
                     VALUES(@IdSocio, @documento, @fechaPagoCuota, @fechaVencimientoCuota, @importeCuota, @importeAdeudado)",
                    sqlCon, transaccion);

                comandoCuota.Parameters.AddWithValue("@idSocio", IdSocio);
                comandoCuota.Parameters.AddWithValue("@documento", documento);
                comandoCuota.Parameters.AddWithValue("@fechaPagoCuota", DBNull.Value);
                comandoCuota.Parameters.AddWithValue("@fechaVencimientoCuota", fechaVencimientoCuota);
                comandoCuota.Parameters.AddWithValue("@importeCuota", importeCuota);
                comandoCuota.Parameters.AddWithValue("@importeAdeudado", importeCuota);

                comandoCuota.ExecuteNonQuery();

                // Confirma la transacción
                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                // Si da error revierte todo
                if (transaccion is not null)
                {
                    transaccion.Rollback();
                }

                string errorCompleto = "Error" + ex.Message;
                if (ex.InnerException != null)
                {
                    errorCompleto += "\n\nInner Exception: " + ex.InnerException.Message;
                }
                errorCompleto += "\n\nStack Trace:" + ex.StackTrace;
                MessageBox.Show(errorCompleto, "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        // Método para inscribir un NO SOCIO
        public bool InscribirNoSocio(string nombre, string apellido, string documento,
                                      string telefono, DateTime FNacimiento, bool aptoFisico)
        {
            MySqlConnection? sqlCon = null;
            try
            {
                // Verificar si el documento ya existe
                if (DocumentoExiste(documento))
                {
                    MessageBox.Show("El documento ya está registrado en el sistema",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(
                    "INSERT INTO nosocio (Nombre, Apellido, Documento, Telefono, FechaNacimiento, AptoFisico) " +
                    "VALUES (@nombre, @apellido, @documento, @telefono, @fechaNacimiento, @aptoFisico)",
                    sqlCon);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", FNacimiento.ToString("dd-MM-yyyy"));
                comando.Parameters.AddWithValue("@aptoFisico", aptoFisico);

                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribir no socio: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        // Busca por documento y devuelve los datos completos
        public Persona? BuscarPorDocumento(string documento)
        {
            MySqlConnection? sqlCon = null;
            MySqlDataReader? reader = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Busca en la tabla Socio
                string querySocio = @"SELECT s.Nombre, s.Apellido, s.Documento, s.Telefono, s.FechaNacimiento, s.AptoFisico,
                                       c.FechaVencimientoCuota, c.ImporteCuota, c.ImporteAdeudado, c.FechaPagoCuota
                                    FROM socio s 
                                    LEFT JOIN cuota c ON c.IdSocio = s.IdSocio
                                    WHERE s.Documento = @documento
                                    ORDER BY c.FechaVencimientoCuota DESC
                                    LIMIT 1";
                MySqlCommand cmdSocio = new MySqlCommand(querySocio, sqlCon);
                cmdSocio.Parameters.AddWithValue("@documento", documento);
                reader = cmdSocio.ExecuteReader();

                if (reader.Read())
                {
                    var persona = new Persona
                    {
                        Tipo = "Socio",
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Documento = reader.GetString("Documento"),
                        Telefono = reader.GetString("Telefono"),
                        FNacimiento = reader.GetDateTime("FechaNacimiento"),
                        Presentado = reader.GetBoolean("AptoFisico"),

                        FechaVencimientoCuota = reader.IsDBNull(reader.GetOrdinal("FechaVencimientoCuota"))
                            ? (DateTime?)null
                            : reader.GetDateTime("FechaVencimientoCuota"),
                        FechaPagoCuota = reader.IsDBNull(reader.GetOrdinal("FechaPagoCuota"))
                            ? (DateTime?)null
                            : reader.GetDateTime("FechaPagoCuota"),
                        ImporteCuota = reader.IsDBNull(reader.GetOrdinal("ImporteCuota"))
                            ? (decimal?)null
                            : reader.GetDecimal("ImporteCuota"),
                        ImporteAdeudado = reader.IsDBNull(reader.GetOrdinal("ImporteAdeudado"))
                            ? (decimal?)null
                            : reader.GetDecimal("ImporteAdeudado")
                    };
                    reader.Close();
                    return persona;
                }

                reader.Close();

                // Busca en la tabla no Socio
                string queryNoSocio = "SELECT Nombre, Apellido, Documento, Telefono, FechaNacimiento, AptoFisico FROM nosocio WHERE Documento =@documento";
                MySqlCommand cmdNoSocio = new MySqlCommand(queryNoSocio, sqlCon);
                cmdNoSocio.Parameters.AddWithValue("@documento", documento);
                reader = cmdNoSocio.ExecuteReader();

                if (reader.Read())
                {
                    var persona = new Persona
                    {
                        Tipo = "No socio",
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Documento = reader.GetString("Documento"),
                        Telefono = reader.GetString("Telefono"),
                        FNacimiento = reader.GetDateTime("FechaNacimiento"),
                        Presentado = null
                    };
                    reader.Close();
                    return persona;
                }

                reader.Close();

                // Si no se encuentra ninguna persona debuelve null
                return null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar persona:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        // Método para obtener socios con cuota vencida hoy
        public List<Persona> ObtenerSociosConCuotaVencidaHoy()
        {
            List<Persona> sociosMorosos = new List<Persona>();
            MySqlConnection? sqlCon = null;
            MySqlDataReader? reader = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();


                string query = @"SELECT s.Nombre, s.Apellido, s.Documento, s.Telefono, s.FechaNacimiento, s.AptoFisico
                                FROM socio s INNER JOIN cuota c ON s.IdSocio = c.IdSocio
                                WHERE DATE(c.FechaVencimientoCuota) = CURDATE()
                                AND s.Activo = 1";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var persona = new Persona
                    {
                        Tipo = "Socio",
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Documento = reader.GetString("Documento"),
                        Telefono = reader.GetString("Telefono"),
                        FNacimiento = reader.GetDateTime("FechaNacimiento"),
                        Presentado = reader.GetBoolean("AptoFisico")
                    };
                    sociosMorosos.Add(persona);
                }

                return sociosMorosos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener socios morosos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return sociosMorosos;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public decimal ObtenerImporteCuota()
        {
            MySqlConnection? sqlCon = null;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "SELECT valor From configuracion WHERE nombre_patametro = 'ImporteCuota' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);

                object? result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtenner el valor de la cuota" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public bool RegistrarPagoYGenerarProximaCuota(string documento, decimal importePagado, int cuotas)
        {
            MySqlConnection? sqlCon = null;
            MySqlTransaction? transaccion = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                transaccion = sqlCon.BeginTransaction(); // Inicia la transacción

                // 1. Obtener el IdSocio y el IdCuota más reciente (la pendiente)
                // Usaremos una consulta rápida para obtener los IDs y la fecha de vencimiento actual.
                string queryGetIds = @"SELECT s.IdSocio, c.IdCuota, c.FechaVencimientoCuota
                              FROM socio s
                              LEFT JOIN cuota c ON c.IdSocio = s.IdSocio
                              WHERE s.Documento = @documento AND c.FechaPagoCuota IS NULL
                              ORDER BY c.FechaVencimientoCuota DESC
                              LIMIT 1;";

                MySqlCommand cmdGetIds = new MySqlCommand(queryGetIds, sqlCon, transaccion);
                cmdGetIds.Parameters.AddWithValue("@documento", documento);
                MySqlDataReader reader = cmdGetIds.ExecuteReader();

                if (!reader.Read())
                {
                    reader.Close();
                    MessageBox.Show("No se encontró una cuota pendiente para el socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    transaccion.Rollback();
                    return false;
                }

                int idSocio = reader.GetInt32("IdSocio");
                int idCuotaActual = reader.GetInt32("IdCuota");
                DateTime fechaVencimientoActual = reader.GetDateTime("FechaVencimientoCuota");
                reader.Close();

                // 2. Actualizar la cuota pendiente como PAGADA
                string queryUpdate = @"UPDATE cuota
                              SET FechaPagoCuota = @fechaPago, ImporteAdeudado = 0
                              WHERE IdCuota = @idCuotaActual;";

                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, sqlCon, transaccion);
                cmdUpdate.Parameters.AddWithValue("@fechaPago", DateTime.Now.Date);
                cmdUpdate.Parameters.AddWithValue("@idCuotaActual", idCuotaActual);
                cmdUpdate.ExecuteNonQuery();

                // 3. Crear el registro de la PRÓXIMA cuota (vence en 1 mes)
                DateTime nuevaFechaVencimiento = fechaVencimientoActual.AddMonths(1); // La próxima vence un mes después de la que se acaba de pagar/vencer.
                decimal importeCuota = 20000m; // Deberías obtener el importe real de configuración o de la cuota anterior. Usaremos 20000m como placeholder.

                string queryInsert = @"INSERT INTO cuota (IdSocio, Documento, FechaPagoCuota, FechaVencimientoCuota, ImporteCuota, ImporteAdeudado)
                              VALUES(@idSocio, @documento, @fechaPagoCuota, @fechaVencimientoCuota, @importeCuota, @importeAdeudado);";

                MySqlCommand cmdInsert = new MySqlCommand(queryInsert, sqlCon, transaccion);
                cmdInsert.Parameters.AddWithValue("@idSocio", idSocio);
                cmdInsert.Parameters.AddWithValue("@documento", documento);
                cmdInsert.Parameters.AddWithValue("@fechaPagoCuota", DBNull.Value); // Empieza como pendiente
                cmdInsert.Parameters.AddWithValue("@fechaVencimientoCuota", nuevaFechaVencimiento);
                cmdInsert.Parameters.AddWithValue("@importeCuota", importeCuota);
                cmdInsert.Parameters.AddWithValue("@importeAdeudado", importeCuota);

                cmdInsert.ExecuteNonQuery();

                // Confirma la transacción
                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (transaccion is not null)
                {
                    transaccion.Rollback(); // Si algo falla, revierte todo
                }
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        // Método para obtener los detalles del último pago de una cuota para un socio
        public Persona? ObtenerDatosUltimoPago(string documento)
        {
            MySqlConnection? sqlCon = null;
            MySqlDataReader? reader = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Obtiene el último registro de cuota pagada para el socio
                string query = @"SELECT s.IdSocio, c.IdCuota, s.Nombre, s.Apellido, s.Documento, c.FechaPagoCuota, c.ImporteCuota
                         FROM socio s
                         INNER JOIN cuota c ON c.IdSocio = s.IdSocio
                         WHERE s.Documento = @documento AND c.FechaPagoCuota IS NOT NULL
                         ORDER BY c.FechaPagoCuota DESC
                         LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@documento", documento);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var persona = new Persona
                    {
                        Tipo = "Socio",
                        IdSocio = reader.GetInt32("IdSocio"),
                        IdCuota = reader.GetInt32("IdCuota"), // En este caso, IdCuota es el ID del pago
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Documento = reader.GetString("Documento"),
                        Telefono = "", // No se selecciona, pero lo rellenamos
                        FNacimiento = DateTime.MinValue, // No se selecciona, pero lo rellenamos
                        Presentado = null, // No aplica directamente
                        FechaPagoCuota = reader.GetDateTime("FechaPagoCuota"),
                        FechaVencimientoCuota = null, // No aplica para el comprobante de pago
                        ImporteCuota = reader.GetDecimal("ImporteCuota"), // Este es el importe pagado
                        ImporteAdeudado = 0m
                    };
                    reader.Close();
                    return persona;
                }

                reader.Close();
                return null; // No se encontró un pago
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del último pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }


        public bool PagarActividad(string documento, decimal importe, string actividad)
        {
            MySqlConnection? sqlCon = null;
            MySqlTransaction? transaccion = null;

            try
            {
                if (string.IsNullOrWhiteSpace(documento))
                    throw new Exception("Documento vacío.");
                if (string.IsNullOrWhiteSpace(actividad))
                    throw new Exception("Actividad vacía.");
                if (importe <= 0)
                    throw new Exception("Importe inválido.");

                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string insertSql = @"
            INSERT INTO pagoActividad (Documento, Actividad, Importe, FechaPago)
            VALUES (@doc, @act, @imp, @fecha);";

                using var cmd = new MySqlCommand(insertSql, sqlCon);
                cmd.Parameters.AddWithValue("@doc", documento);
                cmd.Parameters.AddWithValue("@act", actividad);
                cmd.Parameters.AddWithValue("@imp", importe);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al pagar actividad: " + ex.Message,
                    "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }

    public class Persona
    {
        public required string Tipo { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Documento { get; set; }
        public required string Telefono { get; set; }
        public DateTime FNacimiento { get; set; }
        public bool? Presentado { get; set; }
        public DateTime? FechaPagoCuota { get; set; }
        public DateTime? FechaVencimientoCuota { get; set; }
        public decimal? ImporteCuota { get; set; }
        public decimal? ImporteAdeudado { get; set; }
        public int IdSocio {  get; set; }
        public int IdCuota { get; set; }
        public decimal Importe { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}

