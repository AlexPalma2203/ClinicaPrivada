using CapaComun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;

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
            Nombre_newcita.Text = CachePaciente.NombrePaciente;
            numExpe_newcita.Text = Convert.ToString( CacheExpediente.NumExpediente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDianostPacie CrearDianostico = new ModeloDianostPacie(EnfermedadP: txtEnfermedad.Text,
              EstadoP: txtEstado.Text,
              pesoP: Convert.ToSingle(TxtPeso.Text),
              estaturaP: Convert.ToSingle(TxtEstatura.Text),
              presionP: Convert.ToSingle(TxtPresion.Text),
              temperaturaP: Convert.ToSingle(TxtTemperatura.Text),
              detallesP: RtbDetalles.Text,
              recomendacionesP: rtbRecomendaciones.Text,
              NumExped: CacheExpediente.NumExpediente
              );
                var resultado = CrearDianostico.Dianostico();
                MessageBox.Show(resultado);
                this.Hide();
            }
            catch (Exception) {
                MessageBox.Show("Datos Incorrectos");
            }
               
        }
    }
}
