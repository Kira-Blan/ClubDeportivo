using clubDeportivo.Datos;
using iText.Layout.Properties;
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace clubDeportivo
{
    public partial class FormComprobantePago : Form
    {
        private Persona _datosPago; // Campo para almacenar los datos del pago

        public FormComprobantePago()
        {
            InitializeComponent();
        }

        public FormComprobantePago(Persona datosPago)

        {
            InitializeComponent();

            _datosPago = datosPago;

            // Llena automáticamente la  fecha del día
            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
           
            if (!string.IsNullOrEmpty(_datosPago.Documento))
            {
                CargarDatosSocio(_datosPago.Documento);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del socio.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblClub_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_datosPago == null)
                {
                    MessageBox.Show("No hay datos del pago para generar el comprobante.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear ruta del archivo
                string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Comprobantes");
            
                 if (!Directory.Exists(carpetaDestino))
                     Directory.CreateDirectory(carpetaDestino);

                 string nombreArchivo = $"Comprobante_{_datosPago.Documento}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                 string rutaArchivo = Path.Combine(carpetaDestino, nombreArchivo);

                 // Generar el comprobante PDF
                 GenerarComprobantePago(_datosPago, rutaArchivo);

                if (File.Exists(rutaArchivo))
                {
                    MessageBox.Show($"Comprobante generado correctamente.\n\nUbicación: {rutaArchivo}",
                     "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 👉 Abrir automáticamente el PDF generado
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = rutaArchivo,
                        UseShellExecute = true
                    });

                    // Cierra el formulario después de la descarga
                    this.BeginInvoke(new Action(() => this.Close()));
                }
                else
                {
                    MessageBox.Show("El comprobante no se generó. Verificá el método GenerarComprobantePago.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al generar el comprobante: " + ex.Message,
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void GenerarComprobantePago(Persona datos, string rutaArchivo)
        {
            try
            { 
                   // Crea el documento con márgenes (izq, der, sup, inf)
                   Document document = new Document(PageSize.A4, 50, 50, 50, 50);

                // Crea el escritor y asigna la ruta donde se guardará el PDF
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));

                // Abrir el documento para comenzar a escribir
                document.Open();

                try
                {
                    // 1. Obtener la imagen de tus recursos (asumo que se llama 'Logo_Club_Deportivo2')                   
                    iTextSharp.text.Image logo;

                    using (var ms = new System.IO.MemoryStream())
                    {
                        //  iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        System.Drawing.Image img = Properties.Resources.Logo_Club_Deportivo2;
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    }
                    

                    // Ajusta el tamaño 
                    logo.ScaleToFit(120f, 120f);
                    logo.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                  
                    // 4. Agrega la imagen al documento
                    document.Add(logo);
                }
                catch (Exception exLogo)
                {
               
                }

                // Título               
                Paragraph titulo = new Paragraph("COMPROBANTE DE PAGO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                titulo.Alignment = Element.ALIGN_CENTER;
                document.Add(titulo);
                // Espacio
                document.Add(new Paragraph("\n")); 
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));

                // Datos del pago
                document.Add(new Paragraph($"Nombre: {datos.Nombre} {datos.Apellido}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                document.Add(new Paragraph($"Documento: {datos.Documento}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                document.Add(new Paragraph($"Concepto: Cuota mensual", FontFactory.GetFont(FontFactory.HELVETICA, 12)));

                // Usa el importe de la BD
                decimal importe = datos.Importe != 0 ? datos.Importe :
                                  (datos.ImporteCuota ?? 0);

                document.Add(new Paragraph($"Importe: ${importe:0.00}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));         
                document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                document.Add(new Paragraph("\n"));

                // Footer
                Paragraph pie = new Paragraph("Gracias por su pago.", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12));
                pie.Alignment = Element.ALIGN_CENTER;
                document.Add(pie);

                // Cierre
                document.Close();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                      

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblSocio_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoSocio_Click(object sender, EventArgs e)
        {

        }       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatosSocio(string documento)
        {                  
             string connectionString = "server=localhost;database=proyecto;uid=root;pwd=;";

            using (MySqlConnection con = clubDeportivo.Datos.Conexion.getInstancia().CrearConexion())
            {
                string query = @"SELECT s.IdSocio, CONCAT(s.Nombre, ' ', s.Apellido) AS NombreCompleto, 
                                c.IdCuota, c.ImporteCuota, FechaVencimientoCuota 
                         FROM socio s
                         LEFT JOIN cuota c ON s.IdSocio = c.IdSocio
                         WHERE s.Documento = @Documento
                         ORDER BY c.FechaVencimientoCuota DESC
                         LIMIT 1"; // trae la última cuota

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
                            txtIdSocio.Text = dr["IdSocio"].ToString();
                            txtNombreSocio.Text = dr["NombreCompleto"].ToString();
                           // txtCuota.Text = dr["NumeroCuota"].ToString();                           
                            txtTotal.Text = dr["ImporteCuota"].ToString(); // suma si hay más ítems

                            // Comprobando si los datos de la cuota son nulos
                            object fechaVencimientoObj = dr["FechaVencimientoCuota"];
                            object importeCuotaObj = dr["ImporteCuota"];

                            if (fechaVencimientoObj != DBNull.Value)
                            {
                                DateTime fechaVencimiento = (DateTime)fechaVencimientoObj;
                                txtCuota.Text = fechaVencimiento.ToShortDateString();
                            }
                            else
                            {
                                txtCuota.Text = "No aplica"; // O "Socio sin cuotas"
                            }
                            // Manejo de Importe
                            if (importeCuotaObj != DBNull.Value)
                            {
                                txtImporte.Text = importeCuotaObj.ToString();
                                txtTotal.Text = importeCuotaObj.ToString();
                            }
                            else
                            {
                                txtImporte.Text = "0.00";
                                txtTotal.Text = "0.00";
                            }

                            //txtCuota.Text = (numeroCuota == DBNull.Value) ? "N/A" : numeroCuota.ToString();
                            txtImporte.Text = (importeCuotaObj == DBNull.Value) ? "0.00" : importeCuotaObj.ToString();
                            txtTotal.Text = txtImporte.Text; // o manejar el total en nulo
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se encontraron datos para ese socio.");
                }
            }
        }

        private void txtCuota_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}