using clubDeportivo.Datos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo
{
    public partial class FormComprobanteActividad : Form
    {
        private readonly Persona _persona;
        private readonly string _actividad;
        private readonly decimal _importe;

        // >>> CONSTRUCTOR CORRECTO: recibe los datos <<<
        public FormComprobanteActividad(Persona persona, string actividad, decimal importe)
        {
            InitializeComponent();

            _persona = persona ?? throw new ArgumentNullException(nameof(persona));
            _actividad = actividad ?? "";
            _importe = importe;

            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            txtDocumento.Text = _persona.Documento;
            txtNombreNoSocio.Text = $"{_persona.Nombre} {_persona.Apellido}";
            txtActividad.Text = _actividad;
            txtImporte.Text = _importe.ToString("0.00");
            txtTotal.Text = _importe.ToString("0.00");
        }

        private void GenerarComprobanteActividad(Persona datos, string actividad, decimal importe, string rutaArchivo)
        {
            try
            {
                var document = new Document(PageSize.A4, 50, 50, 50, 50);
                var writer = PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));
                document.Open();

                // Logo (opcional)
                try
                {
                    iTextSharp.text.Image logo;
                    using (var ms = new MemoryStream())
                    {
                        var img = Properties.Resources.Logo_Club_Deportivo2;
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    }
                    logo.ScaleToFit(120f, 120f);
                    logo.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                    document.Add(logo);
                }
                catch { /* si falla el logo, seguimos */ }

                var f18b = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                var f12 = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                var titulo = new Paragraph("COMPROBANTE DE PAGO - ACTIVIDAD", f18b)
                { Alignment = Element.ALIGN_CENTER };
                document.Add(titulo);
                document.Add(new Paragraph("\n\n"));

                document.Add(new Paragraph($"Nombre: {datos.Nombre} {datos.Apellido}", f12));
                document.Add(new Paragraph($"Documento: {datos.Documento}", f12));
                document.Add(new Paragraph($"Actividad: {actividad}", f12));
                document.Add(new Paragraph($"Importe: ${importe:0.00}", f12));
                document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}", f12));
                document.Add(new Paragraph("\n"));

                var pie = new Paragraph("Gracias por su pago.", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12))
                { Alignment = Element.ALIGN_CENTER };
                document.Add(pie);

                document.Close();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarDatosNoSocio(string documento)
        {
            string connectionString = "server=localhost;database=proyecto;uid=root;pwd=;";

            using (MySqlConnection con = clubDeportivo.Datos.Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT CONCAT(Nombre, ' ', Apellido) AS NombreCompleto, Documento 
                         FROM socio";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Documento", documento);

                try
                {
                    con.Open();

                    // Mensaje para verificar si el documento llega bien
                    MessageBox.Show($"Ejecutando consulta para documento: {documento}");

                    MessageBox.Show($"Documento que se envía a la consulta: {documento}");


                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Mensaje para confirmar si la consulta se ejecutó
                        MessageBox.Show("Consulta ejecutada, verificando resultados...");


                        if (dr.Read())
                        {
                            MessageBox.Show("Datos encontrados. Cargando comprobante...");

                            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                            txtNombreNoSocio.Text = dr["NombreCompleto"].ToString();                           
                            txtTotal.Text = dr["ImporteActividad"].ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se encontraron datos para ese socio.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargaPDF_Click(object sender, EventArgs e)
        {
            // carpeta Descargas/Comprobantes
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads", "Comprobantes"
            );
            if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);

            string nombre = $"Comprobante_Actividad_{_persona.Documento}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string ruta = Path.Combine(carpeta, nombre);

            GenerarComprobanteActividad(_persona, _actividad, _importe, ruta);

            if (File.Exists(ruta))
            {
                MessageBox.Show($"Comprobante generado en:\n{ruta}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });

                Close();
            }
            else
            {
                MessageBox.Show("No se generó el PDF. Revisá el método.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
    

