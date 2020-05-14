﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
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
            try {
                ModeloPaciente createPaciente = new ModeloPaciente(dui: Convert.ToInt32(TxtDui.Text),
              nombreP: TxtNombre.Text,
              apellidosP: TxtApellido.Text,
              sexoP: Convert.ToString(CboSexo.SelectedItem),
              numeroTeleP: Convert.ToInt32(TxtNumero.Text),
              direccionP: RtbDireccion.Text,
              estadoCivilP: Convert.ToString(CboEstadoCivil.SelectedItem),
              fechaNaciemientoP: TxtFechaNaciemiemto.Text,
              antecedentes: rtbAntecedentes.Text,
              medicamentos: rtbMedicamentos.Text,
              tipoSangre: Convert.ToString(CboTipoSangre.SelectedItem)


              );
                var resultado = createPaciente.CrearExpediente();
                MessageBox.Show(resultado);
                rtbMedicamentos.Clear();
                rtbAntecedentes.Clear();
                TxtNombre.Clear();
                TxtApellido.Clear();
                TxtDui.Clear();
                TxtFechaNaciemiemto.Clear();
                RtbDireccion.Clear();
                TxtNumero.Clear();
                CboSexo.Text = "";
                CboEstadoCivil.Text= "";
                CboTipoSangre.Text = "";
            }
            catch (Exception) {

                MessageBox.Show("Error Al Crear Expediente");
            }
            

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            Reset();

        }

      

      

        private void FrmCrearExpediente_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboTipoSangre.Items.Add("O -");
            CboTipoSangre.Items.Add("O +");
            CboTipoSangre.Items.Add("A -");
            CboTipoSangre.Items.Add("A +");
            CboTipoSangre.Items.Add("B -");
            CboTipoSangre.Items.Add("B +");
            CboTipoSangre.Items.Add("AB -");
            CboTipoSangre.Items.Add("AB +");
        }

        private void CboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboSexo.Items.Add("F");
            CboSexo.Items.Add("M");
        }

        private void CboEstadoCivil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CboEstadoCivil.Items.Add("Soltero");
            CboEstadoCivil.Items.Add("Casado");
            CboEstadoCivil.Items.Add("Divorsiado");
            CboEstadoCivil.Items.Add("Viudo");

        }
        private void Reset()
        {
            rtbMedicamentos.Clear();
            rtbAntecedentes.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDui.Clear();
            TxtFechaNaciemiemto.Clear();
            RtbDireccion.Clear();
            TxtNumero.Clear();

            CboSexo.Items.Clear();
            CboSexo.Items.Add("F");
            CboSexo.Items.Add("M");

            CboEstadoCivil.Items.Clear();
            CboEstadoCivil.Items.Add("Soltero");
            CboEstadoCivil.Items.Add("Casado");
            CboEstadoCivil.Items.Add("Divorsiado");
            CboEstadoCivil.Items.Add("Viudo");

            CboTipoSangre.Items.Clear();
            CboTipoSangre.Items.Add("O -");
            CboTipoSangre.Items.Add("O +");
            CboTipoSangre.Items.Add("A -");
            CboTipoSangre.Items.Add("A +");
            CboTipoSangre.Items.Add("B -");
            CboTipoSangre.Items.Add("B +");
            CboTipoSangre.Items.Add("AB -");
            CboTipoSangre.Items.Add("AB +");
        }
    }
}
