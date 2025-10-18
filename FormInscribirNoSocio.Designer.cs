namespace clubDeportivo
{
    partial class FormInscribirNoSocio
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblFNacimiento = new Label();
            dtpFNacimiento = new DateTimePicker();
            lblAptoF = new Label();
            checkBox1 = new CheckBox();
            btnPActividad = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(164, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inscribir no socio";
            lblTitulo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(50, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(144, 100);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 26);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(50, 157);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(62, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            lblApellido.Click += lblApellido_Click;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(144, 148);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(257, 26);
            txtApellido.TabIndex = 4;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(50, 202);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(36, 17);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "DNI:";
            lblDocumento.Click += lblDocumento_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(144, 193);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(257, 26);
            txtDocumento.TabIndex = 6;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(50, 244);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(66, 17);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Click += lblTelefono_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(144, 235);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(257, 26);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lblFNacimiento
            // 
            lblFNacimiento.AutoSize = true;
            lblFNacimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFNacimiento.Location = new Point(50, 287);
            lblFNacimiento.Name = "lblFNacimiento";
            lblFNacimiento.Size = new Size(75, 17);
            lblFNacimiento.TabIndex = 9;
            lblFNacimiento.Text = "Fec. Nac.:";
            // 
            // dtpFNacimiento
            // 
            dtpFNacimiento.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFNacimiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFNacimiento.Location = new Point(144, 278);
            dtpFNacimiento.Name = "dtpFNacimiento";
            dtpFNacimiento.Size = new Size(255, 26);
            dtpFNacimiento.TabIndex = 9;
            dtpFNacimiento.ValueChanged += dtpFNacimiento_ValueChanged;
            // 
            // lblAptoF
            // 
            lblAptoF.AutoSize = true;
            lblAptoF.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAptoF.Location = new Point(50, 327);
            lblAptoF.Name = "lblAptoF";
            lblAptoF.Size = new Size(84, 17);
            lblAptoF.TabIndex = 10;
            lblAptoF.Text = "Apto Físico:";
            lblAptoF.Click += lblAptoF_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(144, 327);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 20);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Presentado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnPActividad
            // 
            btnPActividad.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPActividad.ForeColor = Color.ForestGreen;
            btnPActividad.Location = new Point(198, 396);
            btnPActividad.Name = "btnPActividad";
            btnPActividad.Size = new Size(108, 41);
            btnPActividad.TabIndex = 12;
            btnPActividad.Text = "Pagar Actividad";
            btnPActividad.UseVisualStyleBackColor = true;
            btnPActividad.Click += btnPActividad_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ActiveCaption;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(138, 488);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 41);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(269, 488);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormInscribirNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(484, 573);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnPActividad);
            Controls.Add(checkBox1);
            Controls.Add(lblAptoF);
            Controls.Add(dtpFNacimiento);
            Controls.Add(lblFNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FormInscribirNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscribir no socio";
            Load += FormInscribirNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblFNacimiento;
        private DateTimePicker dtpFNacimiento;
        private Label lblAptoF;
        private CheckBox checkBox1;
        private Button btnPActividad;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}