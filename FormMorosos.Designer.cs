namespace clubDeportivo
{
    partial class FormMorosos
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
            pHeader = new Panel();
            lblTitulo = new Label();
            lblFecha = new Label();
            dgvMorosos = new DataGridView();
            lblCantidad = new Label();
            btnExportar = new Button();
            btnCerrar = new Button();
            pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMorosos).BeginInit();
            SuspendLayout();
            // 
            // pHeader
            // 
            pHeader.BackColor = Color.LightSteelBlue;
            pHeader.Controls.Add(lblFecha);
            pHeader.Controls.Add(lblTitulo);
            pHeader.Location = new Point(-1, 22);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(884, 109);
            pHeader.TabIndex = 0;
            pHeader.Paint += pHeader_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(233, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(346, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clientes cuya cuota vence a la fecha";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(20, 73);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // dgvMorosos
            // 
            dgvMorosos.AllowUserToAddRows = false;
            dgvMorosos.AllowUserToDeleteRows = false;
            dgvMorosos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMorosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMorosos.BackgroundColor = Color.AliceBlue;
            dgvMorosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMorosos.Location = new Point(21, 134);
            dgvMorosos.Name = "dgvMorosos";
            dgvMorosos.ReadOnly = true;
            dgvMorosos.RowHeadersVisible = false;
            dgvMorosos.Size = new Size(840, 350);
            dgvMorosos.TabIndex = 2;
            dgvMorosos.CellContentClick += dgvMorosos_CellContentClick;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidad.Location = new Point(21, 509);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(89, 17);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Total de hoy:";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.MediumAquamarine;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(421, 542);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 40);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.DarkSalmon;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(659, 542);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 40);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormMorosos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(884, 591);
            Controls.Add(btnCerrar);
            Controls.Add(btnExportar);
            Controls.Add(lblCantidad);
            Controls.Add(dgvMorosos);
            Controls.Add(pHeader);
            Name = "FormMorosos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socios cuya cuota vence hoy";
            Load += FormMorosos_Load;
            pHeader.ResumeLayout(false);
            pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMorosos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pHeader;
        private Label lblTitulo;
        private Label lblFecha;
        private DataGridView dgvMorosos;
        private Label lblCantidad;
        private Button btnExportar;
        private Button btnCerrar;
    }
}