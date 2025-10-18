using System;
using System.Data;
using System.Windows.Forms;
using clubDeportivo.Datos;

namespace clubDeportivo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.AcceptButton = btnIngresar;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          

            // Validación básica
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conexión y validación
            try
            {
                Usuarios usuarioDAO = new Usuarios();
                DataTable tablaLogin = usuarioDAO.Log_Usu(txtUsuario.Text.Trim(), txtPass.Text.Trim());

                if (tablaLogin.Rows.Count > 0)
                {
                   // MessageBox.Show("Ingreso exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FormMenuPpal menu = new FormMenuPpal();
                    menu.ShowDialog();
                    this.Hide(); // this.Close()
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}