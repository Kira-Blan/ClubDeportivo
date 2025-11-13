namespace clubDeportivo
{
    partial class FormPagarCuota
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
            lblPagarCuota = new Label();
            txtCheckDocumento = new TextBox();
            lblCheckDocumento = new Label();
            btnBuscar = new Button();
            lblFVencimiento = new Label();
            dtpFVencimiento = new DateTimePicker();
            lblTotal = new Label();
            label1 = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblUltimoVencimiento = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtUltimoVencimiento = new TextBox();
            gbMetodoPago = new GroupBox();
            rbCredito = new RadioButton();
            rbDebito = new RadioButton();
            rbEfectivo = new RadioButton();
            lblMonto = new Label();
            txtImporteCuota = new TextBox();
            rb6Cuotas = new RadioButton();
            rb3Cuotas = new RadioButton();
            rb1Cuota = new RadioButton();
            gbCuotas = new GroupBox();
            gbMetodoPago.SuspendLayout();
            gbCuotas.SuspendLayout();
            SuspendLayout();
            // 
            // lblPagarCuota
            // 
            lblPagarCuota.AutoSize = true;
            lblPagarCuota.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagarCuota.Location = new Point(37, 37);
            lblPagarCuota.Name = "lblPagarCuota";
            lblPagarCuota.Size = new Size(262, 47);
            lblPagarCuota.TabIndex = 2;
            lblPagarCuota.Text = "Pagar Cuota";
            // 
            // txtCheckDocumento
            // 
            txtCheckDocumento.Location = new Point(260, 132);
            txtCheckDocumento.Margin = new Padding(4, 5, 4, 5);
            txtCheckDocumento.Name = "txtCheckDocumento";
            txtCheckDocumento.Size = new Size(265, 31);
            txtCheckDocumento.TabIndex = 31;
            // 
            // lblCheckDocumento
            // 
            lblCheckDocumento.AutoSize = true;
            lblCheckDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckDocumento.Location = new Point(40, 133);
            lblCheckDocumento.Margin = new Padding(4, 0, 4, 0);
            lblCheckDocumento.Name = "lblCheckDocumento";
            lblCheckDocumento.Size = new Size(203, 26);
            lblCheckDocumento.TabIndex = 30;
            lblCheckDocumento.Text = "Ingrese N° de DNI:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.PowderBlue;
            btnBuscar.Location = new Point(566, 132);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 38);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFVencimiento
            // 
            lblFVencimiento.AutoSize = true;
            lblFVencimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFVencimiento.ForeColor = Color.Black;
            lblFVencimiento.Location = new Point(390, 403);
            lblFVencimiento.Margin = new Padding(4, 0, 4, 0);
            lblFVencimiento.Name = "lblFVencimiento";
            lblFVencimiento.Size = new Size(217, 26);
            lblFVencimiento.TabIndex = 32;
            lblFVencimiento.Text = "Nueva Fecha Venc.:";
            // 
            // dtpFVencimiento
            // 
            dtpFVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpFVencimiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFVencimiento.Format = DateTimePickerFormat.Custom;
            dtpFVencimiento.Location = new Point(390, 453);
            dtpFVencimiento.Margin = new Padding(4, 5, 4, 5);
            dtpFVencimiento.Name = "dtpFVencimiento";
            dtpFVencimiento.Size = new Size(207, 35);
            dtpFVencimiento.TabIndex = 33;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(40, 448);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 35;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(37, 198);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 26);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(40, 245);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 26);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(236, 195);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(338, 31);
            txtNombre.TabIndex = 38;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(236, 243);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(338, 31);
            txtApellido.TabIndex = 39;
            // 
            // lblUltimoVencimiento
            // 
            lblUltimoVencimiento.AutoSize = true;
            lblUltimoVencimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUltimoVencimiento.Location = new Point(40, 297);
            lblUltimoVencimiento.Margin = new Padding(4, 0, 4, 0);
            lblUltimoVencimiento.Name = "lblUltimoVencimiento";
            lblUltimoVencimiento.Size = new Size(201, 26);
            lblUltimoVencimiento.TabIndex = 40;
            lblUltimoVencimiento.Text = "Ultimo vencimiento";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.PaleGreen;
            btnConfirmar.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnConfirmar.Location = new Point(456, 625);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(234, 90);
            btnConfirmar.TabIndex = 42;
            btnConfirmar.Text = "Pagar y Generar Comprobante";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnPagarGenerarComprobante_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(236, 635);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 70);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtUltimoVencimiento
            // 
            txtUltimoVencimiento.BackColor = Color.White;
            txtUltimoVencimiento.ForeColor = Color.Black;
            txtUltimoVencimiento.Location = new Point(236, 295);
            txtUltimoVencimiento.Margin = new Padding(4, 5, 4, 5);
            txtUltimoVencimiento.Name = "txtUltimoVencimiento";
            txtUltimoVencimiento.ReadOnly = true;
            txtUltimoVencimiento.Size = new Size(338, 31);
            txtUltimoVencimiento.TabIndex = 43;
            // 
            // gbMetodoPago
            // 
            gbMetodoPago.Controls.Add(rbCredito);
            gbMetodoPago.Controls.Add(rbDebito);
            gbMetodoPago.Controls.Add(rbEfectivo);
            gbMetodoPago.Location = new Point(40, 367);
            gbMetodoPago.Margin = new Padding(4, 5, 4, 5);
            gbMetodoPago.Name = "gbMetodoPago";
            gbMetodoPago.Padding = new Padding(4, 5, 4, 5);
            gbMetodoPago.Size = new Size(157, 180);
            gbMetodoPago.TabIndex = 44;
            gbMetodoPago.TabStop = false;
            gbMetodoPago.Text = "Metodo de Pago";
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(9, 120);
            rbCredito.Margin = new Padding(4, 5, 4, 5);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(95, 29);
            rbCredito.TabIndex = 49;
            rbCredito.TabStop = true;
            rbCredito.Text = "Credito";
            rbCredito.UseVisualStyleBackColor = true;
            rbCredito.CheckedChanged += rbCredito_CheckedChanged;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(9, 78);
            rbDebito.Margin = new Padding(4, 5, 4, 5);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(91, 29);
            rbDebito.TabIndex = 48;
            rbDebito.TabStop = true;
            rbDebito.Text = "Debito";
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(9, 37);
            rbEfectivo.Margin = new Padding(4, 5, 4, 5);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(99, 29);
            rbEfectivo.TabIndex = 47;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(44, 573);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(81, 26);
            lblMonto.TabIndex = 45;
            lblMonto.Text = "Monto:";
            // 
            // txtImporteCuota
            // 
            txtImporteCuota.BackColor = Color.White;
            txtImporteCuota.ForeColor = Color.Black;
            txtImporteCuota.Location = new Point(120, 573);
            txtImporteCuota.Margin = new Padding(4, 5, 4, 5);
            txtImporteCuota.Name = "txtImporteCuota";
            txtImporteCuota.PlaceholderText = "Total a pagar";
            txtImporteCuota.Size = new Size(180, 31);
            txtImporteCuota.TabIndex = 46;
            // 
            // rb6Cuotas
            // 
            rb6Cuotas.AutoSize = true;
            rb6Cuotas.Location = new Point(9, 117);
            rb6Cuotas.Margin = new Padding(4, 5, 4, 5);
            rb6Cuotas.Name = "rb6Cuotas";
            rb6Cuotas.Size = new Size(107, 29);
            rb6Cuotas.TabIndex = 55;
            rb6Cuotas.TabStop = true;
            rb6Cuotas.Text = "6 Cuotas";
            rb6Cuotas.UseVisualStyleBackColor = true;
            // 
            // rb3Cuotas
            // 
            rb3Cuotas.AutoSize = true;
            rb3Cuotas.Location = new Point(9, 75);
            rb3Cuotas.Margin = new Padding(4, 5, 4, 5);
            rb3Cuotas.Name = "rb3Cuotas";
            rb3Cuotas.Size = new Size(107, 29);
            rb3Cuotas.TabIndex = 54;
            rb3Cuotas.TabStop = true;
            rb3Cuotas.Text = "3 Cuotas";
            rb3Cuotas.UseVisualStyleBackColor = true;
            // 
            // rb1Cuota
            // 
            rb1Cuota.AutoSize = true;
            rb1Cuota.Location = new Point(9, 33);
            rb1Cuota.Margin = new Padding(4, 5, 4, 5);
            rb1Cuota.Name = "rb1Cuota";
            rb1Cuota.Size = new Size(99, 29);
            rb1Cuota.TabIndex = 53;
            rb1Cuota.TabStop = true;
            rb1Cuota.Text = "1 Cuota";
            rb1Cuota.UseVisualStyleBackColor = true;
            // 
            // gbCuotas
            // 
            gbCuotas.Controls.Add(rb3Cuotas);
            gbCuotas.Controls.Add(rb6Cuotas);
            gbCuotas.Controls.Add(rb1Cuota);
            gbCuotas.Location = new Point(213, 370);
            gbCuotas.Margin = new Padding(4, 5, 4, 5);
            gbCuotas.Name = "gbCuotas";
            gbCuotas.Padding = new Padding(4, 5, 4, 5);
            gbCuotas.Size = new Size(131, 177);
            gbCuotas.TabIndex = 56;
            gbCuotas.TabStop = false;
            gbCuotas.Text = "Cuotas";
            // 
            // FormPagarCuota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(720, 725);
            Controls.Add(gbCuotas);
            Controls.Add(txtImporteCuota);
            Controls.Add(lblMonto);
            Controls.Add(gbMetodoPago);
            Controls.Add(txtUltimoVencimiento);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblUltimoVencimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(lblFVencimiento);
            Controls.Add(dtpFVencimiento);
            Controls.Add(txtCheckDocumento);
            Controls.Add(lblCheckDocumento);
            Controls.Add(btnBuscar);
            Controls.Add(lblPagarCuota);
            Name = "FormPagarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            Load += FormPagarCuota_Load;
            Shown += FormPagarCuota_Shown;
            gbMetodoPago.ResumeLayout(false);
            gbMetodoPago.PerformLayout();
            gbCuotas.ResumeLayout(false);
            gbCuotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagarCuota;
        private TextBox txtCheckDocumento;
        private Label lblCheckDocumento;
        private Button btnBuscar;
        private Label lblFVencimiento;
        private DateTimePicker dtpFVencimiento;
        private Label lblTotal;
        private Label label1;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblUltimoVencimiento;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtUltimoVencimiento;
        private GroupBox gbMetodoPago;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label lblMonto;
        private TextBox txtImporteCuota;
        private RadioButton rbEfectivo;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private RadioButton rb6Cuotas;
        private RadioButton rb3Cuotas;
        private RadioButton rb1Cuota;
        private GroupBox gbCuotas;
    }
}