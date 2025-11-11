namespace clubDeportivo
{
    partial class FormPagarActividad
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
            gbCuotas = new GroupBox();
            rb3Cuotas = new RadioButton();
            rb6Cuotas = new RadioButton();
            rb1Cuota = new RadioButton();
            txtMonto = new TextBox();
            lblMonto = new Label();
            gbMetodoPago = new GroupBox();
            rbCredito = new RadioButton();
            rbDebito = new RadioButton();
            rbEfectivo = new RadioButton();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            lblActividad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            label1 = new Label();
            lblTotal = new Label();
            txtCheckDocumento = new TextBox();
            lblCheckDocumento = new Label();
            btnBuscar = new Button();
            lblPagarActividad = new Label();
            lblNombreEncontrado = new Label();
            lblApellidoEncontrado = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            comboBoxActividades = new ComboBox();
            gbCuotas.SuspendLayout();
            gbMetodoPago.SuspendLayout();
            SuspendLayout();
            // 
            // gbCuotas
            // 
            gbCuotas.Controls.Add(rb3Cuotas);
            gbCuotas.Controls.Add(rb6Cuotas);
            gbCuotas.Controls.Add(rb1Cuota);
            gbCuotas.Location = new Point(147, 223);
            gbCuotas.Name = "gbCuotas";
            gbCuotas.Size = new Size(92, 106);
            gbCuotas.TabIndex = 76;
            gbCuotas.TabStop = false;
            gbCuotas.Text = "Cuotas";
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
            // txtMonto
            // 
            txtMonto.ForeColor = SystemColors.InactiveCaption;
            txtMonto.Location = new Point(298, 233);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Total a pagar";
            txtMonto.Size = new Size(127, 23);
            txtMonto.TabIndex = 75;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(245, 234);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(47, 17);
            lblMonto.TabIndex = 74;
            lblMonto.Text = "Monto";
            // 
            // gbMetodoPago
            // 
            gbMetodoPago.Controls.Add(rbCredito);
            gbMetodoPago.Controls.Add(rbDebito);
            gbMetodoPago.Controls.Add(rbEfectivo);
            gbMetodoPago.Location = new Point(26, 221);
            gbMetodoPago.Name = "gbMetodoPago";
            gbMetodoPago.Size = new Size(110, 108);
            gbMetodoPago.TabIndex = 73;
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(388, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 42);
            btnCancelar.TabIndex = 71;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.PaleGreen;
            btnConfirmar.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnConfirmar.Location = new Point(245, 287);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(137, 42);
            btnConfirmar.TabIndex = 70;
            btnConfirmar.Text = "Confirmar Pago";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActividad.Location = new Point(26, 179);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(70, 17);
            lblActividad.TabIndex = 69;
            lblActividad.Text = "Actividad:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(26, 148);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(62, 17);
            lblApellido.TabIndex = 66;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(24, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 17);
            lblNombre.TabIndex = 65;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 127);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 64;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(26, 270);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 63;
            // 
            // txtCheckDocumento
            // 
            txtCheckDocumento.Location = new Point(180, 80);
            txtCheckDocumento.Name = "txtCheckDocumento";
            txtCheckDocumento.Size = new Size(187, 23);
            txtCheckDocumento.TabIndex = 60;
            txtCheckDocumento.KeyDown += txtCheckDocumento_KeyDown;
            // 
            // lblCheckDocumento
            // 
            lblCheckDocumento.AutoSize = true;
            lblCheckDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckDocumento.Location = new Point(26, 81);
            lblCheckDocumento.Name = "lblCheckDocumento";
            lblCheckDocumento.Size = new Size(128, 17);
            lblCheckDocumento.TabIndex = 59;
            lblCheckDocumento.Text = "Ingrese N° de DNI:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.PowderBlue;
            btnBuscar.Location = new Point(394, 80);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 58;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblPagarActividad
            // 
            lblPagarActividad.AutoSize = true;
            lblPagarActividad.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagarActividad.Location = new Point(24, 23);
            lblPagarActividad.Margin = new Padding(2, 0, 2, 0);
            lblPagarActividad.Name = "lblPagarActividad";
            lblPagarActividad.Size = new Size(219, 31);
            lblPagarActividad.TabIndex = 57;
            lblPagarActividad.Text = "Pagar Actividad";
            // 
            // lblNombreEncontrado
            // 
            lblNombreEncontrado.AutoSize = true;
            lblNombreEncontrado.BackColor = Color.Transparent;
            lblNombreEncontrado.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEncontrado.Location = new Point(163, 120);
            lblNombreEncontrado.Name = "lblNombreEncontrado";
            lblNombreEncontrado.Size = new Size(0, 17);
            lblNombreEncontrado.TabIndex = 77;
            // 
            // lblApellidoEncontrado
            // 
            lblApellidoEncontrado.AutoSize = true;
            lblApellidoEncontrado.BackColor = Color.Transparent;
            lblApellidoEncontrado.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoEncontrado.Location = new Point(163, 148);
            lblApellidoEncontrado.Name = "lblApellidoEncontrado";
            lblApellidoEncontrado.Size = new Size(0, 17);
            lblApellidoEncontrado.TabIndex = 78;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 79;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(163, 149);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(187, 23);
            txtApellido.TabIndex = 80;
            // 
            // comboBoxActividades
            // 
            comboBoxActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActividades.FormattingEnabled = true;
            comboBoxActividades.Location = new Point(163, 179);
            comboBoxActividades.Name = "comboBoxActividades";
            comboBoxActividades.Size = new Size(238, 23);
            comboBoxActividades.TabIndex = 81;
            // 
            // FormPagarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 342);
            Controls.Add(comboBoxActividades);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellidoEncontrado);
            Controls.Add(lblNombreEncontrado);
            Controls.Add(gbCuotas);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(gbMetodoPago);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblActividad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(txtCheckDocumento);
            Controls.Add(lblCheckDocumento);
            Controls.Add(btnBuscar);
            Controls.Add(lblPagarActividad);
            Name = "FormPagarActividad";
            Text = "Form1";
            Load += FormPagarActividad_Load;
            Shown += FormPagarActividad_Shown;
            gbCuotas.ResumeLayout(false);
            gbCuotas.PerformLayout();
            gbMetodoPago.ResumeLayout(false);
            gbMetodoPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCuotas;
        private RadioButton rb3Cuotas;
        private RadioButton rb6Cuotas;
        private RadioButton rb1Cuota;
        private TextBox txtMonto;
        private Label lblMonto;
        private GroupBox gbMetodoPago;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private RadioButton rbEfectivo;
        private TextBox txtUltimoVencimiento;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label lblActividad;
        private Label lblApellido;
        private Label lblNombre;
        private Label label1;
        private Label lblTotal;
        private TextBox txtCheckDocumento;
        private Label lblCheckDocumento;
        private Button btnBuscar;
        private Label lblPagarActividad;
        private Label lblNombreEncontrado;
        private Label lblApellidoEncontrado;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox comboBoxActividades;
    }
}