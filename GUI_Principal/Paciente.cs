using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Dominio;
using CapaComun.Cache;

using System.Runtime.InteropServices;


namespace GUI_Principal
{
    public partial class Paciente : Form
    {
        private Form currentChildForm;
        public Paciente()
        {
            InitializeComponent();

        }
        private IconButton currentBtn;
   

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
              
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            


        }

        private void AbrirFormularioHijoPaciente(Form FormularioHijo)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = FormularioHijo;
            //End
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelPaciente.Controls.Add(FormularioHijo);
            PanelPaciente.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
            

        }

        private void NewConsulta_Click(object sender, EventArgs e)
        {
         
            AbrirFormularioHijoPaciente(new FrmExpediente());
        }

        private void lblFechaExpedientePaciente_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (SearchExp.Text == "Buscar Expediente")
            {
                SearchExp.Text = "";
                //SearchExp.ForeColor = Color.FromArgb(253, 138, 114);
                SearchExp.ForeColor = Color.Gainsboro;
            }
        }

        private void SearchExp_Leave(object sender, EventArgs e)
        {
            if (SearchExp.Text == "")
            {
                SearchExp.Text = "Buscar Expediente";
                SearchExp.ForeColor = Color.FromArgb(120, 116, 127);
            }
        }

        private void NewSearch_Click(object sender, EventArgs e)
        {
            SearchExp.Focus();
        }

        private void SerachExpediente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(253, 138, 114));
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            this.BringToFront();
        }

        private void addPaciente_Click(object sender, EventArgs e)
        {
            btnPrueba.Visible = false;
            ActivateButton(sender, Color.FromArgb(253, 138, 114));
            
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            SearchExp.Focus();
        }

        private void SerachExpediente_Leave(object sender, EventArgs e)
        {
       
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoPaciente(new ActualizarExp());
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            this.BringToFront();
        }


        private void msjError(string msj)
        {
            Errorlbl.Text = msj;
            Errorlbl.Visible = true;
            ErrorBusquedad.Visible = true;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchExp.Text != "Buscar Expediente")
            {
                ModeloUsuario usuario = new ModeloUsuario();
                try
                {
                    var BusquedadValida = usuario.BusquedadPaciente(Convert.ToInt32(SearchExp.Text));
                    if (BusquedadValida == true)
                    {
                        lblDuiPaciente.Text = Convert.ToString(CachePaciente.Dui);
                        lblNombrePaciente.Text = CachePaciente.NombrePaciente;
                        lblApellidoPaciente.Text = CachePaciente.ApellidoPaciente;
                        lblFechaNacPaciente.Text = Convert.ToString( CachePaciente.FechaNacimientoPaciente);
                        lblFechaExpedientePaciente.Text =Convert.ToString( CacheExpediente.FechaCreacionExpediente);
                        numExpedientePaciente.Text = Convert.ToString( CacheExpediente.NumExpediente);
                        Errorlbl.Visible = false;
                        ErrorBusquedad.Visible = false;


                    }
                    else
                    {

                        msjError("Usuario No Encontrado");
                    }
                }
                catch (FormatException) {
                    msjError("Dui Invalido");
                }
            }
            else
            {
                msjError("Ingrese Un Usuario");
            }
        }
    }
}
