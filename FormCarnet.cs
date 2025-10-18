using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq.Expressions;
using Google.Protobuf;


namespace clubDeportivo
{
    public partial class carnet : Form
    {
        private Bitmap carnetOriginal; // Guarda el Bitmap original

        public carnet(Bitmap carnet)
        {
            InitializeComponent();

            // Guarda el Bitmap original (776, 427)
            // carnetOriginal = (Bitmap)carnet.Clone(); //Clonna para evitar problemas
            carnetOriginal = carnet;

            // Muestra la imagen del pictureBox del Form
            pbCarnet.Image = carnet;
            pbCarnet.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void FormCarnet_Load(object sender, EventArgs e)
        {

        }

        private void pbCarnet_Click(object sender, EventArgs e)
        {

        }

        private void btnDescrgarPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDF Files|*.pdf",
                FileName = "Carnet.pdf"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = null;
                    PdfWriter writer = null;
                    FileStream fs = null;

                    try
                    {
                        // Crea un bitmap que capture TODO el contenido visible del panel/formulario          
                        Bitmap carnetCompleto = new Bitmap(pbCarnet.Width, pbCarnet.Height);

                        using (Graphics g = Graphics.FromImage(carnetCompleto))
                        {
                            // Primero dibuja la imagen del carnet original
                            if (carnetOriginal != null)
                            {
                                g.DrawImage(carnetOriginal, 0, 0, pbCarnet.Width, pbCarnet.Height);
                            }

                            // Luego dibuja el logo del PictureBox encima
                            if (pbLogo != null && pbLogo.Image != null)
                            {
                                // Calcula la posición relativa del pbLogo respecto a pbCarnet
                                int logoX = pbLogo.Location.X - pbCarnet.Location.X;
                                int logoY = pbLogo.Location.Y - pbCarnet.Location.Y;
                                g.DrawImage(pbLogo.Image, logoX, logoY, pbLogo.Width, pbLogo.Height);
                            }
                        }

                        // Guardar temporalmente la imagen completa
                        string tempPath = Path.Combine(Path.GetTempPath(), "temp_carnet_completo.png");
                        carnetCompleto.Save(tempPath, System.Drawing.Imaging.ImageFormat.Png);

                        // Crear el PDF
                        fs = new FileStream(sfd.FileName, FileMode.Create);
                        doc = new Document(PageSize.A4.Rotate());
                        writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        // Cargar imagen desde archivo temporal
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(tempPath);

                        // Escalar para que quepa en la página
                        float maxWidth = doc.PageSize.Width - 100;
                        float maxHeight = doc.PageSize.Height - 100;
                        img.ScaleToFit(maxWidth, maxHeight);

                        // Calcular posición centrada
                        float x = (doc.PageSize.Width - img.ScaledWidth) / 2;
                        float y = (doc.PageSize.Height - img.ScaledHeight) / 2;
                        img.SetAbsolutePosition(x, y);

                        // Agregar imagen al documento
                        doc.Add(img);

                        // Limpiar
                        carnetCompleto.Dispose();
                        if (File.Exists(tempPath))
                            File.Delete(tempPath);

                        MessageBox.Show("Carnet descargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el PDF:\n{ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (doc != null && doc.IsOpen())
                            doc.Close();
                        if (writer != null)
                            writer.Close();
                        if (fs != null)
                            fs.Close();
                    }
                }
            }
        }
    



/*  if (carnetOriginal == null)
  {
    MessageBox.Show($"Bitmap: {carnetOriginal.Width}x{carnetOriginal.Height}\n" +
                    $"PixelFormat: {carnetOriginal.PixelFormat}");
    //pixeles", "Debug Info"
   }

  // DEBUG: Verifica el tamaño del bitmap
  MessageBox.Show($"Bitmap: {carnetOriginal.Width}x{carnetOriginal.Height} pixeles", "Debug Info");

  // Captura el PictureBox como Bitmap
  Bitmap bitmap = new Bitmap(pbCarnet.Width, pbCarnet.Height);
  pbCarnet.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, pbCarnet.Width, pbCarnet.Height));
  pbCarnet.Dispose();

  using (SaveFileDialog sfd = new SaveFileDialog()
  {
      Filter = "PDF Files|*.pdf",
      FileName = "Carnet.pdf"
  })
  {

      if (sfd.ShowDialog() == DialogResult.OK)
      {
          try
          {
              // Convierte primero el Bitmap en array de bytes
              byte[] imageBytes;
              using (MemoryStream ms = new MemoryStream())
              {
                  carnetOriginal.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                  imageBytes = ms.ToArray();
              }
              MessageBox.Show($"Imagen convertida: {imageBytes.Length}bytes", "Debug Info");


              using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
              {
                  Document doc = new Document(PageSize.A4.Rotate());
                  PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                  doc.Open();

                  // Crea la imagen desde los bytes
                  iTextSharp.text.Image pbLogo = iTextSharp.text.Image.GetInstance(imageBytes);

                  MessageBox.Show($"Imagen en PDF: {pbLogo.Width}x{pbLogo.Height}", "Debug Info");

                  // Escala la imagen para que quepa bien en la página
                  pbLogo.ScaleToFit(500f, 300f);

                  // Calcula la posición para centrar
                  float pageWidth = doc.PageSize.Width;
                  float pageHeight = doc.PageSize.Height;
                  float x = (pageWidth - pbLogo.ScaledWidth) / 2;
                  float y = (pageHeight - pbLogo.ScaledHeight) / 2;

                  pbLogo.SetAbsolutePosition(x, y);

                  // Agrega la imagen al documento
                  doc.Add(pbLogo);

                  doc.Close();*/
// }

/*  using (MemoryStream ms = new MemoryStream())
  {
      bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
      iTextSharp.text.Image carnetImg = iTextSharp.text.Image.GetInstance(ms.ToArray());
      carnetImg.ScaleToFit(500f, 300f);
      doc.Add(carnetImg);
  }

  doc.Close();*/



/*     MessageBox.Show("Carnet descargado correctamente en: \n" + sfd.FileName, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
  }
  catch (Exception ex)
  {
      MessageBox.Show($"Error al descargar el PDF:\n{ex.Message}\n\nStackTrace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
}
}
} */

private void pbLogo_Click(object sender, EventArgs e)
{

}
  }

}








