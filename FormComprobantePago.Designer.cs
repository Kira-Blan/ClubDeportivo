namespace clubDeportivo
{
    partial class FormComprobantePago
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
            dataGridView1 = new DataGridView();
            pibLogo = new PictureBox();
            btnDescargaPDF = new Button();
            btnCancelar = new Button();
            txtNombreSocio = new TextBox();
            lblSocio = new Label();
            txtIdSocio = new TextBox();
            lblClub = new Label();
            lblSeparador = new Label();
            lblComprobante = new Label();
            lblConcepto = new Label();
            lblDireccion = new Label();
            lblCuit = new Label();
            txtImporte = new TextBox();
            lblSeparador2 = new Label();
            lblImporte = new Label();
            lblTotal = new Label();
            txtCuota = new TextBox();
            txtTotal = new TextBox();
            txtFecha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pibLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 701);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pibLogo
            // 
            pibLogo.BackColor = Color.Transparent;
            pibLogo.Image = Properties.Resources.Logo_Club_Deportivo2;
            pibLogo.Location = new Point(616, 16);
            pibLogo.Name = "pibLogo";
            pibLogo.Size = new Size(152, 109);
            pibLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pibLogo.TabIndex = 2;
            pibLogo.TabStop = false;
            // 
            // btnDescargaPDF
            // 
            btnDescargaPDF.BackColor = Color.PaleGreen;
            btnDescargaPDF.FlatStyle = FlatStyle.Flat;
            btnDescargaPDF.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescargaPDF.Location = new Point(654, 654);
            btnDescargaPDF.Name = "btnDescargaPDF";
            btnDescargaPDF.Size = new Size(97, 41);
            btnDescargaPDF.TabIndex = 3;
            btnDescargaPDF.Text = "Descargar";
            btnDescargaPDF.UseVisualStyleBackColor = false;
            btnDescargaPDF.Click += btnDescargar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(518, 654);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 41);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreSocio
            // 
            txtNombreSocio.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreSocio.Location = new Point(54, 233);
            txtNombreSocio.Name = "txtNombreSocio";
            txtNombreSocio.Size = new Size(199, 25);
            txtNombreSocio.TabIndex = 5;
            txtNombreSocio.TextChanged += textBox1_TextChanged;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.BackColor = Color.Transparent;
            lblSocio.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(64, 199);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(73, 18);
            lblSocio.TabIndex = 6;
            lblSocio.Text = "Socio N°:";
            lblSocio.Click += lblSocio_Click;
            // 
            // txtIdSocio
            // 
            txtIdSocio.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdSocio.Location = new Point(148, 194);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(100, 25);
            txtIdSocio.TabIndex = 7;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClub.Location = new Point(22, 730);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(101, 16);
            lblClub.TabIndex = 8;
            lblClub.Text = "Club Deportivo";
            lblClub.Click += lblClub_Click;
            // 
            // lblSeparador
            // 
            lblSeparador.AutoSize = true;
            lblSeparador.BackColor = Color.Transparent;
            lblSeparador.Location = new Point(22, 290);
            lblSeparador.Name = "lblSeparador";
            lblSeparador.Size = new Size(752, 15);
            lblSeparador.TabIndex = 9;
            lblSeparador.Text = "_____________________________________________________________________________________________________________________________________________________";
            lblSeparador.Click += label1_Click;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComprobante.Location = new Point(311, 55);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(218, 22);
            lblComprobante.TabIndex = 10;
            lblComprobante.Text = "Comprobante de Pago";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.BackColor = Color.Transparent;
            lblConcepto.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConcepto.Location = new Point(54, 350);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(75, 18);
            lblConcepto.TabIndex = 11;
            lblConcepto.Text = "Cuota N°:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(22, 752);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(201, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Avenida Siempreviva 123, Argentina";
            lblDireccion.Click += lblDireccion_Click;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.BackColor = Color.Transparent;
            lblCuit.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuit.Location = new Point(654, 742);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(125, 15);
            lblCuit.TabIndex = 13;
            lblCuit.Text = "CUIT: 30-61476338-4";
            // 
            // txtImporte
            // 
            txtImporte.BackColor = SystemColors.Window;
            txtImporte.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImporte.Location = new Point(612, 413);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 22);
            txtImporte.TabIndex = 14;
            // 
            // lblSeparador2
            // 
            lblSeparador2.AutoSize = true;
            lblSeparador2.BackColor = Color.Transparent;
            lblSeparador2.Location = new Point(23, 486);
            lblSeparador2.Name = "lblSeparador2";
            lblSeparador2.Size = new Size(752, 15);
            lblSeparador2.TabIndex = 16;
            lblSeparador2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.BackColor = Color.Transparent;
            lblImporte.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImporte.Location = new Point(54, 413);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(66, 18);
            lblImporte.TabIndex = 17;
            lblImporte.Text = "Importe:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(505, 526);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 18);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTipoSocio_Click;
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(611, 349);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(100, 23);
            txtCuota.TabIndex = 19;
            txtCuota.TextChanged += txtCuota_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(611, 523);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 25);
            txtTotal.TabIndex = 20;
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(33, 30);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 25);
            txtFecha.TabIndex = 21;
            // 
            // FormComprobantePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 786);
            Controls.Add(txtFecha);
            Controls.Add(txtTotal);
            Controls.Add(txtCuota);
            Controls.Add(lblTotal);
            Controls.Add(lblImporte);
            Controls.Add(lblSeparador2);
            Controls.Add(txtImporte);
            Controls.Add(lblCuit);
            Controls.Add(lblDireccion);
            Controls.Add(lblConcepto);
            Controls.Add(lblComprobante);
            Controls.Add(lblSeparador);
            Controls.Add(lblClub);
            Controls.Add(txtIdSocio);
            Controls.Add(lblSocio);
            Controls.Add(txtNombreSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnDescargaPDF);
            Controls.Add(pibLogo);
            Controls.Add(dataGridView1);
            Name = "FormComprobantePago";
            Text = "FormComprobantePago";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pibLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private PictureBox pibLogo;
        private Button btnDescargaPDF;
        private Button btnCancelar;
        private TextBox txtNombreSocio;
        private Label lblSocio;
        private TextBox txtIdSocio;
        private Label lblClub;
        private Label lblSeparador;
        private Label lblComprobante;
        private Label lblConcepto;
        private Label lblDireccion;
        private Label lblCuit;
        private TextBox txtImporte;
        private Label lblSeparador2;
        private Label lblImporte;
        private Label lblTotal;
        private TextBox txtCuota;
        private TextBox txtTotal;
        private TextBox txtFecha;
    }
}