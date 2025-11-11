using clubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clubDeportivo
{
    public partial class FormPagarActividad : Form
    {
        private Persona? noSocioActual; // Nuevo campo para guardar los datos
        public FormPagarActividad()
        {
            InitializeComponent();
            this.Shown += FormPagarActividad_Shown;
        }
        private void FormPagarActividad_Load(object sender, EventArgs e)
        {
            gbCuotas.Enabled = false;
            rb1Cuota.Checked = false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
            comboBoxActividades.DataSource = Enum.GetValues(typeof(Actividades));

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)

        {
            if (noSocioActual == null)
            {
                MessageBox.Show("Primero buscá el DNI de un NO socio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1) Actividad obligatoria
            if (comboBoxActividades.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una actividad.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxActividades.Focus();
                return;
            }

            string actividad = comboBoxActividades.SelectedItem.ToString();
            // 2) Monto válido (acepta coma o punto)
            if (!decimal.TryParse(
                    txtMonto.Text.Replace(',', '.'),
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out decimal importe) || importe <= 0)
            {
                MessageBox.Show("Ingresá un monto válido (mayor a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            // 3) Confirmación
            string resumen =
                $"Vas a registrar un pago de actividad.\n\n" +
                $"No socio: {noSocioActual.Nombre} {noSocioActual.Apellido} ({noSocioActual.Documento})\n" +
                $"Actividad: {actividad}\n" +
                $"Importe: ${importe:N2}\n" +
                $"Fecha: {DateTime.Now:dd/MM/yyyy}\n\n" +
                $"¿Confirmás el pago?";

            var confirmar = MessageBox.Show(resumen, "Confirmar pago",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmar != DialogResult.Yes) return;

            // 4) Guardar
            var dao = new Persona_DAO();
            bool ok = dao.PagarActividad(noSocioActual.Documento, importe, actividad);

            if (!ok)
            {
                MessageBox.Show("No se pudo registrar el pago.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5) Comprobante (opcional)
            var deseaComprobante = MessageBox.Show("Pago registrado.\n\n¿Querés generar el comprobante en PDF?",
                "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (deseaComprobante == DialogResult.Yes)
            {
                var frm = new FormComprobanteActividad(noSocioActual, actividad, importe);
                frm.ShowDialog();
            }

            // 6) Limpiar / cerrar
            txtActividadAPagar.Clear();
            txtMonto.Clear();
            Close();
        }





        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredito.Checked)
            {
                gbCuotas.Enabled = true;
                rb1Cuota.Checked = true;

            }
            else
            {
                gbCuotas.Enabled = false;
                rb1Cuota.Checked = false;
                rb3Cuotas.Checked = false;
                rb6Cuotas.Checked = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                string documentoTxt = txtCheckDocumento.Text.Trim();

                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(documentoTxt))
                {
                    MessageBox.Show("Debe ingresar un número de documento", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCheckDocumento.Focus();
                    return;
                }

                if (!long.TryParse(documentoTxt, out _))
                {
                    MessageBox.Show("Ingrese sólo números", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCheckDocumento.Focus();
                    return;
                }

                // Buscar en BD
                var dao = new Persona_DAO();
                var personaEncontrada = dao.BuscarPorDocumento(documentoTxt);

                // Debe existir y NO ser socio
                if (personaEncontrada != null && !string.Equals(personaEncontrada.Tipo, "Socio", StringComparison.OrdinalIgnoreCase))
                {
                    noSocioActual = personaEncontrada;

                    // Cargar datos en pantalla
                    txtNombre.Text = personaEncontrada.Nombre;
                    txtApellido.Text = personaEncontrada.Apellido;

                    btnConfirmar.Enabled = true;
                    btnCancelar.Enabled = true;

                    MessageBox.Show("No socio encontrado.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    noSocioActual = null;
                    txtNombre.Clear();
                    txtApellido.Clear();
                    btnConfirmar.Enabled = false;
                    btnCancelar.Enabled = false;

                    MessageBox.Show("No existe o es Socio. Probá con otro DNI.",
                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();

        }

        private void txtCheckDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick(); // Simula un click en el botón Buscar
                e.SuppressKeyPress = true;
            }

        }

        private void FormPagarActividad_Shown(object sender, EventArgs e)
        {
            txtCheckDocumento.Focus();
        }
    }

    public enum Actividades
    {
        Yoga,
        Pilates,
        Gimnasio,
        Pileta,
        Opción,
    }
}

        
   
