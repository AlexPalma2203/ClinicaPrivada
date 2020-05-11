using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Principal
{
    public partial class FrmCrearExpediente : Form
    {
        public FrmCrearExpediente()
        {
            InitializeComponent();
        }


        private void BtnCrear_Click(object sender, EventArgs e)
        {

          
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            
            TxtNombre.Focus();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDui.Clear();
            TxtFechaNaciemiemto.Clear();
            TxtNombreEmergicia.Clear();
            TxtContantoEmergencia.Clear();
            
            RtbDireccion.Clear();
            TxtNumero.Clear();
            CboEstadoCivil.Text="Seleccione una opcion";
            CboSexo.Text = "Seleccione una opcion";
            CboTipoSangre.Text = "Seleccione una opcion";
        }

        private void CboSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CboEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboEstadoCivil.Items.Add("Soltero");
            CboEstadoCivil.Items.Add("Casado");
            CboEstadoCivil.Items.Add("Divorsiado");
            CboEstadoCivil.Items.Add("Viudo");
        }

        private void FrmCrearExpediente_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboTipoSangre.Items.Add("O negativo");
            CboTipoSangre.Items.Add("O positivo");
            CboTipoSangre.Items.Add("A negativo");
            CboTipoSangre.Items.Add("A positivo");
            CboTipoSangre.Items.Add("B negativo");
            CboTipoSangre.Items.Add("B positivo");
            CboTipoSangre.Items.Add("AB negativo");
            CboTipoSangre.Items.Add("AB positivo");
        }

        private void CboTipoSangre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        


      
    }
}
