using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    "INSERT INTO socio (Nombre, Apellido, Documento, Telefono, FechaNacimiento, AptoFisico, FechaVencimientoCuota) " +
                    "VALUES (@nombre, @apellido, @documento, @telefono, @fechaNacimiento, @aptoFisico, @fechaVencimientoCuota)",
                    sqlCon);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", FNacimiento.ToString("dd-MM-yyyy"));
                comando.Parameters.AddWithValue("@aptoFisico", aptoFisico);              
                comando.Parameters.AddWithValue("@activo", 1);

                DateTime fInscripcion = DateTime.Now.Date;
                DateTime fechaVencimientoCuota = fInscripcion.AddMonths(1);
                comando.Parameters.AddWithValue("@fechaVencimientoCuota", fechaVencimientoCuota.ToString("d-MM-yyyy"));


                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                string errorCompleto = "Error: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorCompleto += "\n\nInner Exception" + ex.InnerException.Message;
                }
                errorCompleto += "\n\nStack Trace: " + ex.StackTrace;

                MessageBox.Show(errorCompleto, "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                /*MessageBox.Show("Error al inscribir socio: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;*/
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
                string querySocio = "SELECT Nombre, Apellido, Documento, Telefono, FechaNacimiento, AptoFisico FROM socio WHERE Documento =@documento";
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
                        Presentado = reader.GetBoolean("AptoFisico")
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

                //MySqlDataReader reader = cmdNoSocio.ExecuteReader();

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
    }

}

