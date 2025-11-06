using clubDeportivo.Datos;
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
    public partial class FormPagarActividad : Form
    {
        public FormPagarActividad()
        {
            InitializeComponent();
        }
        private void FormPagarActividad_Load(object sender, EventArgs e)
        {
            gbCuotas.Enabled = false;
            rb1Cuota.Checked = false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

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
            string Documento = txtCheckDocumento.Text.Trim();

            Persona_DAO dAO = new Persona_DAO();
            _ = dAO.BuscarPorDocumento(Documento);


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
            //Buscar en la BD            
            BuscarPorDocumento(documento);
        }
        private void BuscarPorDocumento(long documento)
        {
            Persona_DAO dao = new Persona_DAO();
            Datos.Persona personaEncontrada = dao.BuscarPorDocumento(documento.ToString());


            if (personaEncontrada != null && personaEncontrada.Tipo != "Socio")
            {
                MessageBox.Show("Persona encontrada en el sistema como " + personaEncontrada.Tipo,
                                "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblNombreEncontrado.Text = personaEncontrada!.Nombre;
                lblApellidoEncontrado.Text = personaEncontrada.Apellido;
                btnConfirmar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                //Persona inexistente
                MessageBox.Show("La persona buscada no existe o es socio. Por favor intente con otro DNI",
                                "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelar.Enabled = false;
                btnConfirmar.Enabled = false;

                lblApellidoEncontrado.Text = "";
                lblNombreEncontrado.Text = "";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
