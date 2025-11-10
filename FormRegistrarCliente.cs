using clubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo
{
    public partial class FormRegistrarCliente : Form
    {
        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        public FormRegistrarCliente(string documento) : this()
        {
            txtDocumento.Text = documento.ToString();
        }

        private void FormRegistrarCliente_Load(object sender, EventArgs e)
        {
            // Ocultar panel de datos al inicio
            panelDatosPersona.Visible = false;

            txtCheckDocumento.MaxLength = 9;
            habilitarCampos(false);

            txtCheckDocumento.Focus();            
        }

        private void FormRegistrarCliente_KeyDown(object? sender, KeyEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDocumento_Click(object sender, EventArgs e)
        {

        }

        private void dtpFNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblFNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAptoF_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void chkPresentado_CheckedChanged(object sender, EventArgs e)
        {
            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea cancelar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                limpiarCampos();
                panelDatosPersona.Visible = false;
            }
        }

        public void BuscarPorDocumento(long documento)
        {
            Persona_DAO dao = new Persona_DAO();
            Datos.Persona personaEncontrada = dao.BuscarPorDocumento(documento.ToString());               

            // Muestra el panel de datos
            panelDatosPersona.Visible = true;

            if (personaEncontrada != null)
            {
                MessageBox.Show("Persona encontrada en el sistema como " + personaEncontrada.Tipo, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Carga los datos de la persona encontrada
                txtNombre.Text = personaEncontrada!.Nombre;
                txtApellido.Text = personaEncontrada.Apellido;
                txtDocumento.Text = personaEncontrada.Documento;
                txtTelefono.Text = personaEncontrada.Telefono ?? "";
                dtpFNacimiento.Value = personaEncontrada.FNacimiento;
                chkPresentado.Checked = personaEncontrada.Presentado.HasValue ? personaEncontrada.Presentado.Value : false;

                // Deshabilita los campos para que no se puedan editar los datos existentes.
                habilitarCampos(false);
            }
            else
            {
                //Persona inexistente (se habilita la carga de datos)
                MessageBox.Show("Persona no encontrada. Complete los campos para registrarla.", "Nueva Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos
                limpiarCampos();

                // Habilita los campos para poder completar los datos
                habilitarCampos(true);
                btnSocio.Visible = true;
                btnNoSocio.Visible = true;

                // Da foco al primer campo
                txtNombre.Focus();

                FormRegistrarCliente form = new FormRegistrarCliente(documento.ToString());
                txtDocumento.Text = documento.ToString();
            }

            // Habilita los botones Socio, No socio y Cancelar            
            btnCancelar.Enabled = true;
            btnSocio.Enabled = true;
            btnNoSocio.Enabled = true;
        }

        public void limpiarCampos()
        {
            // Limpia todos los campos
            txtCheckDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";

            // Reestablece valores
            dtpFNacimiento.Value = DateTime.Today;
            chkPresentado.Checked = false;
        }

        private void habilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtDocumento.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            dtpFNacimiento.Enabled = habilitar;
            chkPresentado.Enabled = habilitar;
        }

        private void lblChekDocumento_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelDatosPersona_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letrass, teclas de control y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Para bloquear el caracter
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Para bloquear el caracter
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite sólo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  //Bloquea el caracter
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite sólo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Bloquea el caracter
                return;
            }
            //  Pone un límite de 9 caracteres
            if (txtDocumento.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;  // No permite más caracteres
            }
        }

        private void txtCheckDocumento_Click(object sender, EventArgs e)
        {

        }

        private void txtChekDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite sólo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Bloquea el caracter               
            }
        }

        private void btnInscribirSocio_Click(object sender, EventArgs e)
        {
            if (!CamposObligatorios())
                return;            

            // Confirmar la inscripción
            DialogResult resultado = MessageBox.Show(
                "¿Desea inscribir a esta persona como SOCIO?",
                "Confirmar Inscripción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Obtener los valores del formulario
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string documento = txtDocumento.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                DateTime fNacimiento = dtpFNacimiento.Value;
                bool presentado = chkPresentado.Checked;

                // Crear instancia del DAO y guardar
                Persona_DAO personaDAO = new Persona_DAO();
                bool exito = personaDAO.InscribirSocio(nombre, apellido, documento,
                                                        telefono, fNacimiento, presentado);

                if (exito)
                {
                    MessageBox.Show("✓ Socio inscripto exitosamente. Será redirigido al panel de Socios.",
                       "Éxito",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                    FormSocio formSocio = new FormSocio(txtDocumento.Text.Trim());
                    formSocio.Show();

                    // Limpiar el formulario
                    limpiarCampos();
                    panelDatosPersona.Visible = false;
                    txtCheckDocumento.Focus();

                    this.Close();                                                         
                }               
            }
        }

        private void btnInscribirNoSocio_Click(object sender, EventArgs e)
        {
            if (!CamposObligatorios())
                return;            

            // Confirma la inscripción
            DialogResult resultado = MessageBox.Show(
                "¿Desea inscribir a esta persona como NO SOCIO?",
                "Confirmar Inscripción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Obtienr los valores del formulario
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string documento = txtDocumento.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                DateTime fNacimiento = dtpFNacimiento.Value;
                bool presentado = chkPresentado.Checked;

                // Crea instancia del DAO y guarda
                Persona_DAO personaDAO = new Persona_DAO();
                bool exito = personaDAO.InscribirNoSocio(nombre, apellido, documento,
                                                          telefono, fNacimiento, presentado);

                if (exito)
                {
                    MessageBox.Show("✓ No Socio inscripto exitosamente. Será redirigido al panel de no Socios",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Limpia el formulario
                    limpiarCampos();
                    panelDatosPersona.Visible = false;
                    txtCheckDocumento.Focus();
                }
            }
        }

        private bool CamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Ingrese un número de documento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese un número de teléfono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (dtpFNacimiento.Value == DateTime.Today || dtpFNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha de nacimiento válida", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFNacimiento.Focus();
                return false;
            }

            if (!chkPresentado.Checked)
            {
                MessageBox.Show("Debe marcar Presentado en Apto Físico para poder continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkPresentado.Focus();
                return false;
            }

            return true;
        }
    }

}
