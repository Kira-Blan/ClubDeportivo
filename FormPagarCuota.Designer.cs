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
            txtMonto = new TextBox();
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
            lblPagarCuota.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagarCuota.Location = new Point(26, 22);
            lblPagarCuota.Margin = new Padding(2, 0, 2, 0);
            lblPagarCuota.Name = "lblPagarCuota";
            lblPagarCuota.Size = new Size(145, 31);
            lblPagarCuota.TabIndex = 2;
            lblPagarCuota.Text = "Pagar Cuota";
            // 
            // txtCheckDocumento
            // 
            txtCheckDocumento.Location = new Point(182, 79);
            txtCheckDocumento.Name = "txtCheckDocumento";
            txtCheckDocumento.Size = new Size(187, 23);
            txtCheckDocumento.TabIndex = 31;
            // 
            // lblCheckDocumento
            // 
            lblCheckDocumento.AutoSize = true;
            lblCheckDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckDocumento.Location = new Point(28, 80);
            lblCheckDocumento.Name = "lblCheckDocumento";
            lblCheckDocumento.Size = new Size(128, 17);
            lblCheckDocumento.TabIndex = 30;
            lblCheckDocumento.Text = "Ingrese N° de DNI:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.PowderBlue;
            btnBuscar.Location = new Point(396, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblFVencimiento
            // 
            lblFVencimiento.AutoSize = true;
            lblFVencimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFVencimiento.ForeColor = Color.Black;
            lblFVencimiento.Location = new Point(273, 242);
            lblFVencimiento.Name = "lblFVencimiento";
            lblFVencimiento.Size = new Size(138, 17);
            lblFVencimiento.TabIndex = 32;
            lblFVencimiento.Text = "Nueva Fecha Venc.:";
            // 
            // dtpFVencimiento
            // 
            dtpFVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpFVencimiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFVencimiento.Format = DateTimePickerFormat.Custom;
            dtpFVencimiento.Location = new Point(273, 272);
            dtpFVencimiento.Name = "dtpFVencimiento";
            dtpFVencimiento.Size = new Size(146, 26);
            dtpFVencimiento.TabIndex = 33;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(28, 269);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 126);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 35;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(26, 119);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(28, 147);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 17);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(165, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 38;
            txtNombre.Text = "Nombre del socio";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = SystemColors.InactiveCaption;
            txtApellido.Location = new Point(165, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(238, 23);
            txtApellido.TabIndex = 39;
            txtApellido.Text = "Apellido del socio";
            // 
            // lblUltimoVencimiento
            // 
            lblUltimoVencimiento.AutoSize = true;
            lblUltimoVencimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUltimoVencimiento.Location = new Point(28, 178);
            lblUltimoVencimiento.Name = "lblUltimoVencimiento";
            lblUltimoVencimiento.Size = new Size(131, 17);
            lblUltimoVencimiento.TabIndex = 40;
            lblUltimoVencimiento.Text = "Ultimo vencimiento";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.PaleGreen;
            btnConfirmar.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnConfirmar.Location = new Point(232, 381);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(137, 42);
            btnConfirmar.TabIndex = 42;
            btnConfirmar.Text = "Confirmar Pago";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(387, 381);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 42);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUltimoVencimiento
            // 
            txtUltimoVencimiento.ForeColor = SystemColors.InactiveCaption;
            txtUltimoVencimiento.Location = new Point(165, 177);
            txtUltimoVencimiento.Name = "txtUltimoVencimiento";
            txtUltimoVencimiento.Size = new Size(238, 23);
            txtUltimoVencimiento.TabIndex = 43;
            txtUltimoVencimiento.Text = "Ultimo vencimiento registrado";
            // 
            // gbMetodoPago
            // 
            gbMetodoPago.Controls.Add(rbCredito);
            gbMetodoPago.Controls.Add(rbDebito);
            gbMetodoPago.Controls.Add(rbEfectivo);
            gbMetodoPago.Location = new Point(28, 220);
            gbMetodoPago.Name = "gbMetodoPago";
            gbMetodoPago.Size = new Size(110, 108);
            gbMetodoPago.TabIndex = 44;
            gbMetodoPago.TabStop = false;
            gbMetodoPago.Text = "Metodo de Pago";
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(6, 72);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(64, 19);
            rbCredito.TabIndex = 49;
            rbCredito.TabStop = true;
            rbCredito.Text = "Credito";
            rbCredito.UseVisualStyleBackColor = true;
            rbCredito.CheckedChanged += rbCredito_CheckedChanged;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(6, 47);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(60, 19);
            rbDebito.TabIndex = 48;
            rbDebito.TabStop = true;
            rbDebito.Text = "Debito";
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(6, 22);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 47;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(31, 344);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(47, 17);
            lblMonto.TabIndex = 45;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.ForeColor = SystemColors.InactiveCaption;
            txtMonto.Location = new Point(84, 344);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(127, 23);
            txtMonto.TabIndex = 46;
            txtMonto.Text = "Total a pagar";
            // 
            // rb6Cuotas
            // 
            rb6Cuotas.AutoSize = true;
            rb6Cuotas.Location = new Point(6, 70);
            rb6Cuotas.Name = "rb6Cuotas";
            rb6Cuotas.Size = new Size(71, 19);
            rb6Cuotas.TabIndex = 55;
            rb6Cuotas.TabStop = true;
            rb6Cuotas.Text = "6 Cuotas";
            rb6Cuotas.UseVisualStyleBackColor = true;
            // 
            // rb3Cuotas
            // 
            rb3Cuotas.AutoSize = true;
            rb3Cuotas.Location = new Point(6, 45);
            rb3Cuotas.Name = "rb3Cuotas";
            rb3Cuotas.Size = new Size(71, 19);
            rb3Cuotas.TabIndex = 54;
            rb3Cuotas.TabStop = true;
            rb3Cuotas.Text = "3 Cuotas";
            rb3Cuotas.UseVisualStyleBackColor = true;
            // 
            // rb1Cuota
            // 
            rb1Cuota.AutoSize = true;
            rb1Cuota.Location = new Point(6, 20);
            rb1Cuota.Name = "rb1Cuota";
            rb1Cuota.Size = new Size(66, 19);
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
            gbCuotas.Location = new Point(149, 222);
            gbCuotas.Name = "gbCuotas";
            gbCuotas.Size = new Size(92, 106);
            gbCuotas.TabIndex = 56;
            gbCuotas.TabStop = false;
            gbCuotas.Text = "Cuotas";
            // 
            // FormPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(504, 435);
            Controls.Add(gbCuotas);
            Controls.Add(txtMonto);
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
            Margin = new Padding(2);
            Name = "FormPagarCuota";
            Text = "Pagar Cuota";
            Load += FormPagarCuota_Load;
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
        private TextBox txtMonto;
        private RadioButton rbEfectivo;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private RadioButton rb6Cuotas;
        private RadioButton rb3Cuotas;
        private RadioButton rb1Cuota;
        private GroupBox gbCuotas;
    }
}