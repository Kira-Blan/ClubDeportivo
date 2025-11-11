namespace clubDeportivo
{
    partial class FormComprobanteActividad
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
            txtFecha = new TextBox();
            lblComprobante = new Label();
            txtNombreNoSocio = new TextBox();
            pibLogo = new PictureBox();
            txtTotal = new TextBox();
            txtActividad = new TextBox();
            lblTotal = new Label();
            lblImporte = new Label();
            lblSeparador2 = new Label();
            txtImporte = new TextBox();
            lblActividad = new Label();
            lblSeparador = new Label();
            btnCancelar = new Button();
            btnDescargaPDF = new Button();
            lblCuit = new Label();
            lblDireccion = new Label();
            lblClub = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDocumento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pibLogo).BeginInit();
            SuspendLayout();
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(29, 28);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 25);
            txtFecha.TabIndex = 27;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComprobante.Location = new Point(306, 53);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(218, 22);
            lblComprobante.TabIndex = 26;
            lblComprobante.Text = "Comprobante de Pago";
            // 
            // txtNombreNoSocio
            // 
            txtNombreNoSocio.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreNoSocio.Location = new Point(29, 130);
            txtNombreNoSocio.Name = "txtNombreNoSocio";
            txtNombreNoSocio.Size = new Size(199, 25);
            txtNombreNoSocio.TabIndex = 23;
            // 
            // pibLogo
            // 
            pibLogo.BackColor = Color.Transparent;
            pibLogo.Image = Properties.Resources.Logo_Club_Deportivo2;
            pibLogo.Location = new Point(612, 14);
            pibLogo.Name = "pibLogo";
            pibLogo.Size = new Size(152, 109);
            pibLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pibLogo.TabIndex = 22;
            pibLogo.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(589, 363);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 25);
            txtTotal.TabIndex = 37;
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(589, 195);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(100, 23);
            txtActividad.TabIndex = 36;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(483, 366);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 18);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "Total:";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.BackColor = Color.Transparent;
            lblImporte.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImporte.Location = new Point(32, 250);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(66, 18);
            lblImporte.TabIndex = 34;
            lblImporte.Text = "Importe:";
            // 
            // lblSeparador2
            // 
            lblSeparador2.AutoSize = true;
            lblSeparador2.BackColor = Color.Transparent;
            lblSeparador2.Location = new Point(26, 303);
            lblSeparador2.Name = "lblSeparador2";
            lblSeparador2.Size = new Size(0, 15);
            lblSeparador2.TabIndex = 33;
            // 
            // txtImporte
            // 
            txtImporte.BackColor = SystemColors.Window;
            txtImporte.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImporte.Location = new Point(589, 250);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 22);
            txtImporte.TabIndex = 32;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.BackColor = Color.Transparent;
            lblActividad.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividad.Location = new Point(32, 199);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(77, 18);
            lblActividad.TabIndex = 31;
            lblActividad.Text = "Actividad:";
            // 
            // lblSeparador
            // 
            lblSeparador.AutoSize = true;
            lblSeparador.BackColor = Color.Transparent;
            lblSeparador.Location = new Point(26, 177);
            lblSeparador.Name = "lblSeparador";
            lblSeparador.Size = new Size(0, 15);
            lblSeparador.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(532, 444);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 41);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDescargaPDF
            // 
            btnDescargaPDF.BackColor = Color.PaleGreen;
            btnDescargaPDF.FlatStyle = FlatStyle.Flat;
            btnDescargaPDF.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescargaPDF.Location = new Point(667, 444);
            btnDescargaPDF.Name = "btnDescargaPDF";
            btnDescargaPDF.Size = new Size(97, 41);
            btnDescargaPDF.TabIndex = 28;
            btnDescargaPDF.Text = "Descargar";
            btnDescargaPDF.UseVisualStyleBackColor = false;
            btnDescargaPDF.Click += btnDescargaPDF_Click;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.BackColor = Color.Transparent;
            lblCuit.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuit.Location = new Point(629, 517);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(125, 15);
            lblCuit.TabIndex = 40;
            lblCuit.Text = "CUIT: 30-61476338-4";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(10, 517);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(201, 15);
            lblDireccion.TabIndex = 39;
            lblDireccion.Text = "Avenida Siempreviva 123, Argentina";
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClub.Location = new Point(10, 495);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(101, 16);
            lblClub.TabIndex = 38;
            lblClub.Text = "Club Deportivo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(19, 295);
            label1.Name = "label1";
            label1.Size = new Size(752, 15);
            label1.TabIndex = 41;
            label1.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(19, 272);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(19, 159);
            label3.Name = "label3";
            label3.Size = new Size(752, 15);
            label3.TabIndex = 43;
            label3.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(29, 99);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(199, 25);
            txtDocumento.TabIndex = 44;
            // 
            // FormComprobanteActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 559);
            Controls.Add(txtDocumento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCuit);
            Controls.Add(lblDireccion);
            Controls.Add(lblClub);
            Controls.Add(txtTotal);
            Controls.Add(txtActividad);
            Controls.Add(lblTotal);
            Controls.Add(lblImporte);
            Controls.Add(lblSeparador2);
            Controls.Add(txtImporte);
            Controls.Add(lblActividad);
            Controls.Add(lblSeparador);
            Controls.Add(btnCancelar);
            Controls.Add(btnDescargaPDF);
            Controls.Add(txtFecha);
            Controls.Add(lblComprobante);
            Controls.Add(txtNombreNoSocio);
            Controls.Add(pibLogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormComprobanteActividad";
            Text = "FormComprobanteActividad";
            ((System.ComponentModel.ISupportInitialize)pibLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFecha;
        private Label lblComprobante;
        private TextBox txtNombreNoSocio;
        private PictureBox pibLogo;
        private TextBox txtTotal;
        private TextBox txtActividad;
        private Label lblTotal;
        private Label lblImporte;
        private Label lblSeparador2;
        private TextBox txtImporte;
        private Label lblActividad;
        private Label lblSeparador;
        private Button btnCancelar;
        private Button btnDescargaPDF;
        private Label lblCuit;
        private Label lblDireccion;
        private Label lblClub;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDocumento;
    }
}