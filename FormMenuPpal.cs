using System;
using System.Windows.Forms;

namespace clubDeportivo
{
    public partial class FormMenuPpal : Form
    {
        public FormMenuPpal()
        {
            InitializeComponent();
        }

        private void FormMenuPpal_Load(object sender, EventArgs e)
        {

        }

        //Eventos click de los botones
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente frm = new FormRegistrarCliente();
            frm.Show();
        }

        private void btnPagoCuota_Click(object sender, EventArgs e)
        {
            FormPagarCuota frm = new FormPagarCuota();
            frm.Show();
        }

        private void txtPagoActividad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagoActividad_Click(object sender, EventArgs e)
        {

        }

        private void btnListaMorosos_Click(object sender, EventArgs e)
        {
            FormMorosos formMorosos = new FormMorosos();
            formMorosos.ShowDialog();
        }

        private void btnCierreSesion_Click(object sender, EventArgs e)
        {
            // Confirmar el cierre de sesión
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Cierra y vuelve al Login
            }
        }
    }
}
