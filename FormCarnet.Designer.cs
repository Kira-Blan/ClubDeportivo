namespace clubDeportivo
{
    partial class carnet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbCarnet = new PictureBox();
            btnDescargaPDF = new Button();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCarnet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbCarnet
            // 
            pbCarnet.BackColor = Color.Cornsilk;
            pbCarnet.BorderStyle = BorderStyle.FixedSingle;
            pbCarnet.Image = Properties.Resources.Logo_Club_Deportivo;
            pbCarnet.ImageLocation = "";
            pbCarnet.Location = new Point(97, 59);
            pbCarnet.Name = "pbCarnet";
            pbCarnet.Size = new Size(618, 317);
            pbCarnet.TabIndex = 0;
            pbCarnet.TabStop = false;
            pbCarnet.Click += pbCarnet_Click;
            // 
            // btnDescargaPDF
            // 
            btnDescargaPDF.BackColor = Color.SandyBrown;
            btnDescargaPDF.FlatStyle = FlatStyle.Flat;
            btnDescargaPDF.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescargaPDF.Location = new Point(578, 295);
            btnDescargaPDF.Name = "btnDescargaPDF";
            btnDescargaPDF.Size = new Size(122, 59);
            btnDescargaPDF.TabIndex = 1;
            btnDescargaPDF.Text = "Descargar en PDF";
            btnDescargaPDF.UseVisualStyleBackColor = false;
            btnDescargaPDF.Click += btnDescrgarPDF_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Cornsilk;
            pbLogo.ErrorImage = null;
            pbLogo.Image = Properties.Resources.Logo_Club_Deportivo;
            pbLogo.Location = new Point(489, 76);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(200, 166);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbLogo);
            Controls.Add(btnDescargaPDF);
            Controls.Add(pbCarnet);
            Name = "carnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarnet";
            Load += FormCarnet_Load;
            ((System.ComponentModel.ISupportInitialize)pbCarnet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCarnet;
        private Button btnDescargaPDF;
        private PictureBox pbLogo;
    }
}