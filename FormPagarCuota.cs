using clubDeportivo;
using clubDeportivo.Datos;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo
{
    public partial class FormPagarCuota : Form
    {
        private Persona? socioActual; // Nuevo campo para guardar los datos

        public FormPagarCuota()
        {
            InitializeComponent();

            this.AcceptButton = btnBuscar;
        }

        private void FormPagarCuota_Load(object sender, EventArgs e)
        {
            gbCuotas.Enabled = false;
            rb1Cuota.Checked = false;
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredito.Checked)
            {
                gbCuotas.Enabled = true; // Habilita el grupo de cuota
                rb1Cuota.Checked = true; // Selecciona automáticamente la opción de 1 cuota

            }
            else // Si Crédito no está seleccionado (se deseleccionó)
            {
                gbCuotas.Enabled = false; // Deshabilita el grupo de cuota
                rb1Cuota.Checked = false;
                rb3Cuotas.Checked = false;
                rb6Cuotas.Checked = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Documento = txtCheckDocumento.Text.Trim();

            // Validar que el documento no este vacío
            if (string.IsNullOrWhiteSpace(txtCheckDocumento.Text))
            {
                MessageBox.Show("Debe ingresar un número de documento", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheckDocumento.Focus();
                return;
            }

            // Validar que se ingresan números
            if (!long.TryParse(txtCheckDocumento.Text, out long documento))
            {
                MessageBox.Show("Ingrese sólo números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheckDocumento.Focus();
                return;
            }

            var dao = new Persona_DAO();
            Persona? personaEncontrada = dao.BuscarPorDocumento(Documento);

            socioActual = BuscarPorDocumento(documento); // Asigna el resultado a la variable de clase

            if (socioActual is not null)
            {
                MessageBox.Show("Socio encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar los datos de la persona encontrada
                txtNombre.Text = personaEncontrada.Nombre;
                txtApellido.Text = personaEncontrada.Apellido;

                if (personaEncontrada.ImporteCuota is not null)
                    txtUltimoVencimiento.Text = personaEncontrada.FechaVencimientoCuota?.ToShortDateString();
                txtImporteCuota.Text = personaEncontrada.ImporteCuota.Value.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el socio", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Persona? BuscarPorDocumento(long documento)
        {
            MySqlConnection sqlCon = null;
            MySqlDataReader? reader = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Busca en la tabla socio y en la tabla cuota
                string querySocio = @"SELECT 
                                s.Nombre, 
                                s.Apellido, 
                                s.Documento, 
                                s.Telefono, 
                                s.FechaNacimiento, 
                                s.AptoFisico,
                                c.FechaVencimientoCuota, 
                                c.ImporteCuota, 
                                c.ImporteAdeudado, 
                                c.FechaPagoCuota
                               FROM socio AS s
                               LEFT JOIN cuota AS c ON s.IdSocio = c.IdSocio
                               WHERE s.Documento = @documento
                               ORDER BY c.FechaVencimientoCuota DESC
                               LIMIT 1;";


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
                return null;
            }

            /* // Busca en la tabla no Socio
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
         }*/
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

        private void FormPagarCuota_Shown(object sender, EventArgs e)
        {
            txtCheckDocumento.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagarGenerarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioActual == null)
                {
                    MessageBox.Show("Primero debe buscar y encontrar un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar forma de pago seleccionada
                if (!rbEfectivo.Checked && !rbCredito.Checked)
                {
                    MessageBox.Show("Debe seleccionar una forma de pago.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determinar cantidad de cuotas (solo si es con tarjeta de crédito)
                int cuotas = 1;
                if (rbCredito.Checked)
                {
                    if (rb3Cuotas.Checked)
                        cuotas = 3;
                    else if (rb6Cuotas.Checked)
                        cuotas = 6;
                }

                // Confirmar el pago
                decimal importe = socioActual.ImporteCuota.Value; // Usar el importe del objeto socioActual
                string mensajeCuotas = cuotas > 1 ? $" en {cuotas} cuotas" : "";
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Confirma el pago de ${importe}{mensajeCuotas} para el socio {socioActual.Nombre} {socioActual.Apellido}?",
                    "Confirmar Pago",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes)
                    return;

                var dao = new Persona_DAO();
                bool pagoExitoso = dao.RegistrarPagoYGenerarProximaCuota(socioActual.Documento, importe, cuotas);


                if (!pagoExitoso)
                {
                    MessageBox.Show("Error al registrar el pago en la base de datos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar los datos del socio después del pago
                socioActual = BuscarPorDocumento(long.Parse(socioActual.Documento));


                // Crear el formulario del comprobante y pasarle el objeto Persona
                FormComprobantePago formComprobante = new FormComprobantePago(socioActual);
                formComprobante.ShowDialog();

                // Mostrar el formulario
                formComprobante.ShowDialog();

                // Limpiar el formulario después del pago
                LimpiarCampos();

                MessageBox.Show("Pago registrado exitosamente.",
            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar comprobante: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUltimoVencimiento.Clear();
            txtImporteCuota.Clear();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}


