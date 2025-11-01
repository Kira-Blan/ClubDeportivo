using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using clubDeportivo.Datos;

namespace clubDeportivo
{
    public partial class FormMorosos : Form
    {
        public FormMorosos()
        {
            InitializeComponent();
        }

        private void FormMorosos_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Evento Load ejecutándose...");   //Para chequear que se esté cargando 

            // Coloca la fecha actual
            lblFecha.Text = $"Fecha: {DateTime.Now: dd/MM/yyyy}";

            //Carga datos de los clientes morosos
            CargarMorosos();
        }

        private void CargarMorosos()
        {
            try
            {
                Persona_DAO personaDao = new Persona_DAO();
                List<Persona> morosos = personaDao.ObtenerSociosConCuotaVencidaHoy();

                if (morosos.Count == 0)
                {
                    MessageBox.Show("¡Excelente! No hay socios con cuota vencida hoy.",
                        "Sin Morosos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCantidad.Text = "Total: 0 socios";
                    lblCantidad.ForeColor = Color.FromArgb(39, 174, 96);
                    return;
                }

                dgvMorosos.DataSource = morosos;

                // Personalizar columnas
                if (dgvMorosos.Columns["Tipo"] != null)
                    dgvMorosos.Columns["Tipo"].Visible = false;

                if (dgvMorosos.Columns["Presentado"] != null)
                    dgvMorosos.Columns["Presentado"].Visible = false;

                if (dgvMorosos.Columns["Nombre"] != null)
                    dgvMorosos.Columns["Nombre"].HeaderText = "Nombre";

                if (dgvMorosos.Columns["Apellido"] != null)
                    dgvMorosos.Columns["Apellido"].HeaderText = "Apellido";

                if (dgvMorosos.Columns["Documento"] != null)
                {
                    dgvMorosos.Columns["Documento"].HeaderText = "DNI";
                    dgvMorosos.Columns["Documento"].Width = 100;
                }

                if (dgvMorosos.Columns["Telefono"] != null)
                {
                    dgvMorosos.Columns["Telefono"].HeaderText = "Teléfono";
                    dgvMorosos.Columns["Telefono"].Width = 120;
                }

                if (dgvMorosos.Columns["FNacimiento"] != null)
                {
                    dgvMorosos.Columns["FNacimiento"].HeaderText = "Fecha Nac.";
                    dgvMorosos.Columns["FNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvMorosos.Columns["FNacimiento"].Width = 100;
                }

                lblCantidad.Text = $"Total de morosos: {morosos.Count} socios";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona_DAO personaDao = new Persona_DAO();
                List<Persona> morosos = personaDao.ObtenerSociosConCuotaVencidaHoy();

                if (morosos.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivo de texto|*.txt",
                    Title = "Guardar listado de morosos",
                    FileName = $"Morosos_{DateTime.Now:yyyyMMdd}.txt"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveDialog.FileName))
                    {
                        file.WriteLine("===============================================");
                        file.WriteLine("     LISTADO DE SOCIOS CON CUOTA VENCIDA");
                        file.WriteLine($"     Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
                        file.WriteLine("===============================================");
                        file.WriteLine();
                        file.WriteLine($"Total de morosos: {morosos.Count}");
                        file.WriteLine();

                        foreach (var socio in morosos)
                        {
                            file.WriteLine($"Nombre: {socio.Apellido}, {socio.Nombre}");
                            file.WriteLine($"DNI: {socio.Documento}");
                            file.WriteLine($"Teléfono: {socio.Telefono}");
                            file.WriteLine($"Fecha Nac: {socio.FNacimiento:dd/MM/yyyy}");
                            file.WriteLine("-----------------------------------------------");
                        }
                    }

                    MessageBox.Show("Archivo exportado exitosamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMorosos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }       

        private void pHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}