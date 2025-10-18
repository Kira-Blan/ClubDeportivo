namespace clubDeportivo
{
    partial class FormSocio
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
            lblSocio = new Label();
            btnGenerarCarnet = new Button();
            btnPagarCuota = new Button();
            SuspendLayout();
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(331, 60);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(148, 22);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Panel de Socio";
            // 
            // btnGenerarCarnet
            // 
            btnGenerarCarnet.BackColor = Color.LightBlue;
            btnGenerarCarnet.FlatStyle = FlatStyle.Flat;
            btnGenerarCarnet.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarCarnet.Location = new Point(174, 203);
            btnGenerarCarnet.Name = "btnGenerarCarnet";
            btnGenerarCarnet.Size = new Size(103, 50);
            btnGenerarCarnet.TabIndex = 1;
            btnGenerarCarnet.Text = "Generar Carnet";
            btnGenerarCarnet.UseVisualStyleBackColor = false;
            btnGenerarCarnet.Click += btnGenerarCarnet_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.PowderBlue;
            btnPagarCuota.FlatStyle = FlatStyle.Flat;
            btnPagarCuota.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagarCuota.Location = new Point(526, 203);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(105, 50);
            btnPagarCuota.TabIndex = 2;
            btnPagarCuota.Text = "Pagar Cuota";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // FormSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnGenerarCarnet);
            Controls.Add(lblSocio);
            Name = "FormSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSocio";
            Load += FormSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSocio;
        private Button btnGenerarCarnet;
        private Button btnPagarCuota;
    }
}