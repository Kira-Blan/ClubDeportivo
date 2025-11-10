using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace clubDeportivo
{
    public partial class FormSocio : Form
    {
        private string documentoSocio;

        public FormSocio(string documento)
        {
            InitializeComponent();
            documentoSocio = documento;
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            FormPagarCuota frm = new FormPagarCuota();
            frm.Show();
        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {

            // Crea la instancia DAO y llama al método
             Persona_DAO dao = new Persona_DAO();

           
            // Obtiene la persona de la BD
            Persona persona = ObtenerPersona(documentoSocio);

            if (persona != null)
            {
                // Crea imagen digital del carnet
                Bitmap carnet = new Bitmap(618, 317);

                using (Graphics g = Graphics.FromImage(carnet))
                { 

                g.Clear(Color.Cornsilk);// Fondo Beige

                // Mejora el renderizado
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                // Dibuja el borde
                Pen pen = new Pen(Color.Black, 2);
                g.DrawRectangle(new Pen(Color.Black, 2), 0, 0, carnet.Width - 1, carnet.Height - 1);

                // Agrega el logo
                string rutaLogo = Path.Combine(Application.StartupPath, "Properties", "Resources", "Logo_Club_Deportivo.png");
                    if (File.Exists(rutaLogo))
                    {
                        try
                        {
                            using (Image pblogo = Image.FromFile(rutaLogo))
                            {
                                int logoSize = 100;
                                int margenSup = 40;
                                int margenDer = 40;

                                g.DrawImage(pblogo, new Rectangle(carnet.Width - logoSize - margenDer, margenSup, logoSize, logoSize)); //  Pone al logo en el ángulo superior derecho
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar el logo: {ex.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                       // MessageBox.Show($"No se encontró el logo en: {rutaLogo}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                        // Dibuja el texto    
                        using (Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold))
                        using (Font fuenteDatos = new Font("Arial", 14, FontStyle.Regular))
                        using (SolidBrush brush = new SolidBrush(Color.Black))
                        {
                            int margenIzq = 60;
                            int posY = 40;

                            // Título
                            g.DrawString("Carnet de Socio", fuenteTitulo, brush, margenIzq, posY);
                            posY += 60;

                            // Datos del socio
                            g.DrawString($"Socio N°: {persona.Documento}", fuenteDatos, Brushes.Black, 10, 160);
                            g.DrawString($"Nombre: {persona.Nombre} {persona.Apellido}", fuenteDatos, Brushes.Black, new PointF(10, 200));                            
                        }
            }

                    //posY += 40;
                    carnet preview = new carnet(carnet);
                    preview.Show();
                }
            else
            {
                MessageBox.Show("Socio no encontrado");
            }
        }

                private static Persona ObtenerPersona(string documento)  
                {
                Persona_DAO dao = new Persona_DAO(); // Crea la instancia del DAO
                    return dao.BuscarPorDocumento(documento); // Llama al método desde Persona_Dao
                }
    }
}
