namespace clubDeportivo
{
    partial class FormMenuPpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnRegistarCliente = new Button();
            btnPagoCuota = new Button();
            btnListaMorosos = new Button();
            btnPagoActividad = new Button();
            btnCierreSesion = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(162, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(264, 49);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Club Deportivo";
            // 
            // btnRegistarCliente
            // 
            btnRegistarCliente.BackColor = Color.White;
            btnRegistarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistarCliente.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistarCliente.Location = new Point(145, 144);
            btnRegistarCliente.Name = "btnRegistarCliente";
            btnRegistarCliente.Size = new Size(213, 43);
            btnRegistarCliente.TabIndex = 2;
            btnRegistarCliente.Text = "Registrar Cliente";
            btnRegistarCliente.UseVisualStyleBackColor = false;
            btnRegistarCliente.Click += BtnRegistrarCliente_Click;
            // 
            // btnPagoCuota
            // 
            btnPagoCuota.BackColor = Color.White;
            btnPagoCuota.FlatStyle = FlatStyle.Flat;
            btnPagoCuota.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagoCuota.Location = new Point(145, 210);
            btnPagoCuota.Name = "btnPagoCuota";
            btnPagoCuota.Size = new Size(213, 43);
            btnPagoCuota.TabIndex = 3;
            btnPagoCuota.Text = "Pago de Cuota";
            btnPagoCuota.UseVisualStyleBackColor = false;
            btnPagoCuota.Click += btnPagoCuota_Click;
            // 
            // btnListaMorosos
            // 
            btnListaMorosos.BackColor = Color.White;
            btnListaMorosos.FlatStyle = FlatStyle.Flat;
            btnListaMorosos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaMorosos.Location = new Point(145, 342);
            btnListaMorosos.Name = "btnListaMorosos";
            btnListaMorosos.Size = new Size(213, 43);
            btnListaMorosos.TabIndex = 5;
            btnListaMorosos.Text = "Vencimientos Diarios";
            btnListaMorosos.UseVisualStyleBackColor = false;
            btnListaMorosos.Click += btnListaMorosos_Click;
            // 
            // btnPagoActividad
            // 
            btnPagoActividad.BackColor = Color.White;
            btnPagoActividad.FlatStyle = FlatStyle.Flat;
            btnPagoActividad.Location = new Point(145, 277);
            btnPagoActividad.Name = "btnPagoActividad";
            btnPagoActividad.Size = new Size(213, 43);
            btnPagoActividad.TabIndex = 4;
            btnPagoActividad.Text = "Pago de Actividad";
            btnPagoActividad.UseVisualStyleBackColor = false;
            btnPagoActividad.Click += btnPagoActividad_Click;
            // 
            // btnCierreSesion
            // 
            btnCierreSesion.BackColor = Color.LightSkyBlue;
            btnCierreSesion.FlatStyle = FlatStyle.Flat;
            btnCierreSesion.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCierreSesion.Location = new Point(389, 9);
            btnCierreSesion.Name = "btnCierreSesion";
            btnCierreSesion.Size = new Size(85, 38);
            btnCierreSesion.TabIndex = 6;
            btnCierreSesion.Text = "Cerrar Sesión";
            btnCierreSesion.UseVisualStyleBackColor = false;
            btnCierreSesion.Click += btnCierreSesion_Click;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(484, 437);
            Controls.Add(btnCierreSesion);
            Controls.Add(btnPagoActividad);
            Controls.Add(btnListaMorosos);
            Controls.Add(btnPagoCuota);
            Controls.Add(btnRegistarCliente);
            Controls.Add(lblTitulo);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMenuPpal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Menú Principal";
            Load += FormMenuPpal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente frm = new FormRegistrarCliente();
            frm.Show();
        }

        #endregion

        private Label lblTitulo;
        private Button btnRegistarCliente;
        private Button btnPagoCuota;
        private Button btnListaMorosos;
        private Button btnPagoActividad;
        private Button btnPagarActividad;
        private Button btnCierreSesion;
    }
}
