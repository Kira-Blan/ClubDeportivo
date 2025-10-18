using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo
{
    public partial class FormPagarCuota : Form
    {
        public FormPagarCuota()
        {
            InitializeComponent();

        }
        private void FormPagarCuota_Load(object sender, EventArgs e)
        {
            gbCuotas.Enabled = false;
            rb1Cuota.Checked = false;
        }



        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredito.Checked)
            {
                gbCuotas.Enabled = true; // Habilita el grupo de cuota
                rb1Cuota.Checked = true; // Selecciona automáticamente la opción de 1 cuota

            }
            else // Si Crédito no está seleccionado (se deseleccionó)
            {
                gbCuotas.Enabled = false; // Deshabilita el grupo de cuota
                rb1Cuota.Checked = false;
                rb3Cuotas.Checked = false;
                rb6Cuotas.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}