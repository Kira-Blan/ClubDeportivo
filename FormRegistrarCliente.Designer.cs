using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using clubDeportivo.Datos;

namespace clubDeportivo
{
    public partial class FormRegistrarCliente : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;
        private IContainer components = null;

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
            lblRegistroCliente = new Label();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblFNacimiento = new Label();
            dtpFNacimiento = new DateTimePicker();
            lblAptoF = new Label();
            chkPresentado = new CheckBox();
            btnCancelar = new Button();
            btnSocio = new Button();
            btnNoSocio = new Button();
            lblCheckDocumento = new Label();
            txtCheckDocumento = new TextBox();
            panelDatosPersona = new Panel();
            panelDatosPersona.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistroCliente
            // 
            lblRegistroCliente.AutoSize = true;
            lblRegistroCliente.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroCliente.Location = new Point(152, 37);
            lblRegistroCliente.Name = "lblRegistroCliente";
            lblRegistroCliente.Size = new Size(185, 22);
            lblRegistroCliente.TabIndex = 0;
            lblRegistroCliente.Text = "Registro de Cliente";
            lblRegistroCliente.Click += lblRegistrarCliente_Click;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Enabled = false;
            lblDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(37, 101);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(36, 17);
            lblDocumento.TabIndex = 26;
            lblDocumento.Text = "DNI:";
            // 
            // txtDocumento
            // 
            txtDocumento.Enabled = false;
            txtDocumento.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(157, 99);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(257, 26);
            txtDocumento.TabIndex = 6;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.PowderBlue;
            btnBuscar.Location = new Point(371, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(37, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(157, 10);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 26);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Enabled = false;
            lblApellido.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(37, 55);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(62, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(157, 53);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(257, 26);
            txtApellido.TabIndex = 4;
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Enabled = false;
            lblTelefono.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(37, 146);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(66, 17);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(157, 144);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(257, 26);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtTelefono_TextChanged_1;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblFNacimiento
            // 
            lblFNacimiento.AutoSize = true;
            lblFNacimiento.Enabled = false;
            lblFNacimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFNacimiento.ForeColor = Color.Black;
            lblFNacimiento.Location = new Point(37, 198);
            lblFNacimiento.Name = "lblFNacimiento";
            lblFNacimiento.Size = new Size(75, 17);
            lblFNacimiento.TabIndex = 9;
            lblFNacimiento.Text = "Fec. Nac.:";
            lblFNacimiento.Click += lblFNacimiento_Click;
            // 
            // dtpFNacimiento
            // 
            dtpFNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFNacimiento.Enabled = false;
            dtpFNacimiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFNacimiento.Location = new Point(157, 191);
            dtpFNacimiento.Name = "dtpFNacimiento";
            dtpFNacimiento.Size = new Size(257, 26);
            dtpFNacimiento.TabIndex = 9;
            dtpFNacimiento.Click += dtpFNacimiento_Click;
            dtpFNacimiento.ValueChanged += dtpFNacimiento_ValueChanged;
            // 
            // lblAptoF
            // 
            lblAptoF.AutoSize = true;
            lblAptoF.Enabled = false;
            lblAptoF.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAptoF.Location = new Point(37, 254);
            lblAptoF.Name = "lblAptoF";
            lblAptoF.Size = new Size(84, 17);
            lblAptoF.TabIndex = 10;
            lblAptoF.Text = "Apto Físico:";
            lblAptoF.Click += lblAptoF_Click;
            // 
            // chkPresentado
            // 
            chkPresentado.AutoSize = true;
            chkPresentado.Enabled = false;
            chkPresentado.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPresentado.Location = new Point(140, 254);
            chkPresentado.Name = "chkPresentado";
            chkPresentado.Size = new Size(92, 20);
            chkPresentado.TabIndex = 11;
            chkPresentado.Text = "Presentado";
            chkPresentado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSalmon;
            btnCancelar.Enabled = false;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(193, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSocio
            // 
            btnSocio.BackColor = Color.White;
            btnSocio.Enabled = false;
            btnSocio.FlatStyle = FlatStyle.System;
            btnSocio.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSocio.ForeColor = Color.SteelBlue;
            btnSocio.Location = new Point(64, 312);
            btnSocio.Name = "btnSocio";
            btnSocio.Size = new Size(108, 42);
            btnSocio.TabIndex = 22;
            btnSocio.Text = "Inscribir Socio";
            btnSocio.UseVisualStyleBackColor = false;
            btnSocio.Visible = false;
            btnSocio.Click += btnInscribirSocio_Click;
            // 
            // btnNoSocio
            // 
            btnNoSocio.BackColor = Color.White;
            btnNoSocio.Enabled = false;
            btnNoSocio.FlatStyle = FlatStyle.System;
            btnNoSocio.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoSocio.ForeColor = Color.RoyalBlue;
            btnNoSocio.Location = new Point(298, 312);
            btnNoSocio.Name = "btnNoSocio";
            btnNoSocio.Size = new Size(100, 42);
            btnNoSocio.TabIndex = 23;
            btnNoSocio.Text = "Inscribir No Socio";
            btnNoSocio.UseVisualStyleBackColor = false;
            btnNoSocio.Visible = false;
            btnNoSocio.Click += btnInscribirNoSocio_Click;
            // 
            // lblCheckDocumento
            // 
            lblCheckDocumento.AutoSize = true;
            lblCheckDocumento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckDocumento.Location = new Point(39, 103);
            lblCheckDocumento.Name = "lblCheckDocumento";
            lblCheckDocumento.Size = new Size(128, 17);
            lblCheckDocumento.TabIndex = 27;
            lblCheckDocumento.Text = "Ingrese N° de DNI:";
            lblCheckDocumento.Click += lblChekDocumento_Click;
            // 
            // txtCheckDocumento
            // 
            txtCheckDocumento.Location = new Point(169, 97);
            txtCheckDocumento.Name = "txtCheckDocumento";
            txtCheckDocumento.Size = new Size(187, 23);
            txtCheckDocumento.TabIndex = 0;
            txtCheckDocumento.TextChanged += txtCheckDocumento_Click;
            txtCheckDocumento.KeyPress += txtChekDocumento_KeyPress;
            // 
            // panelDatosPersona
            // 
            panelDatosPersona.Controls.Add(lblNombre);
            panelDatosPersona.Controls.Add(txtNombre);
            panelDatosPersona.Controls.Add(lblApellido);
            panelDatosPersona.Controls.Add(lblDocumento);
            panelDatosPersona.Controls.Add(btnCancelar);
            panelDatosPersona.Controls.Add(btnNoSocio);
            panelDatosPersona.Controls.Add(btnSocio);
            panelDatosPersona.Controls.Add(txtApellido);
            panelDatosPersona.Controls.Add(txtDocumento);
            panelDatosPersona.Controls.Add(chkPresentado);
            panelDatosPersona.Controls.Add(txtTelefono);
            panelDatosPersona.Controls.Add(lblAptoF);
            panelDatosPersona.Controls.Add(lblTelefono);
            panelDatosPersona.Controls.Add(lblFNacimiento);
            panelDatosPersona.Controls.Add(dtpFNacimiento);
            panelDatosPersona.Location = new Point(12, 157);
            panelDatosPersona.Name = "panelDatosPersona";
            panelDatosPersona.Size = new Size(460, 466);
            panelDatosPersona.TabIndex = 29;
            panelDatosPersona.Visible = false;
            panelDatosPersona.Paint += panelDatosPersona_Paint;
            // 
            // FormRegistrarCliente
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(484, 635);
            Controls.Add(panelDatosPersona);
            Controls.Add(txtCheckDocumento);
            Controls.Add(lblCheckDocumento);
            Controls.Add(btnBuscar);
            Controls.Add(lblRegistroCliente);
            Name = "FormRegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscribir Socio";
            Load += FormRegistrarCliente_Load;
            panelDatosPersona.ResumeLayout(false);
            panelDatosPersona.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void btnInscribirSocio_Click(object sender, EventArgs e)
         {
             // Obtener los datos ingresados
             string nombre = txtNombre.Text.Trim();
             string apellido = txtApellido.Text.Trim();
             string documento = txtDocumento.Text.Trim();
             string telefono = txtTelefono.Text.Trim();
             DateTime fNacimiento = dtpFNacimiento.Value;

             // Guardar los datos usando PersonaDAO (si querés guardar directamente ahora)
             Persona_DAO dao = new Persona_DAO();
             bool exito = dao.InscribirSocio(nombre, apellido, documento, telefono, fNacimiento);

             if (exito)
             {
                 // Abrir FormRegistrarSocio pasando los datos
                 FormInscribirSocio formSocio = new FormInscribirSocio(nombre, apellido, documento, telefono, fNacimiento);
                 formSocio.Show();
                 this.Hide(); // Oculta el formulario actual
             }


             // MessageBox.Show("Será redirigido al panel de  Socios");
         }

         private void btnInscribirNoSocio_Click(object sender, EventArgs e)
         {
             MessageBox.Show("Será redirigido al panel de No Socios");
         }*/

        #endregion

        private Label lblRegistroCliente;
        private Label lblCheckDocumento;
        private TextBox txtCheckDocumento;
        private Button btnBuscar;
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
        private CheckBox chkPresentado;
        private Button btnSocio;
        private Button btnCancelar;
        private Panel panelDatosPersona;
        private Button btnNoSocio;
        
    }
}