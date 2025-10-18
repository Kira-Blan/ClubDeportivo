namespace clubDeportivo
{
    partial class FormLogin
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            btnIngresar = new Button();
            lblAcceso = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(142, 100);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(51, 16);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(265, 98);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(149, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(142, 146);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(73, 16);
            lblPass.TabIndex = 2;
            lblPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(265, 144);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(149, 23);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.PowderBlue;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(239, 197);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(78, 38);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblAcceso
            // 
            lblAcceso.AutoSize = true;
            lblAcceso.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcceso.Location = new Point(229, 30);
            lblAcceso.Name = "lblAcceso";
            lblAcceso.Size = new Size(79, 22);
            lblAcceso.TabIndex = 6;
            lblAcceso.Text = "Acceso";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblAcceso);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Location = new Point(12, 157);
            Margin = new Padding(2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblPass;
        private TextBox txtPass;
        private Button btnIngresar;
        private Label lblAcceso;
    }
}