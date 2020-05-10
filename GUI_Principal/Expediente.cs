using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Principal
{
    public partial class FrmExpediente : Form
    {
        public FrmExpediente()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            
            TxtEstatura.Clear();
            TxtFecha.Clear();
            TxtPeso.Clear();
            TxtPresion.Clear();
            TxtTemperatura.Clear();
            txtEnfermedad.Clear();
            txtEstado.Clear();
            rtbRecomendaciones.Clear();
            RtbDetalles.Clear();

            

        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }
    }
}
