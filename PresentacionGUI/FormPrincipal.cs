using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GUI_Principal;
using Login;

namespace PresentacionGUI
{
    public partial class FormPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            Menu.Controls.Add(leftBorderBtn);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
       
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconFormularioActual.IconChar = currentBtn.IconChar;
                iconFormularioActual.IconColor = color;
                TituloFormularioHijo.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                
            }
        }
        private void AbrirFormularioHijo(Form FormularioHijo)
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
            Formularios.Controls.Add(FormularioHijo);
            Formularios.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
            TituloFormularioHijo.Text = FormularioHijo.Text;

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Medico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(122, 220, 219));
            AbrirFormularioHijo(new Medico());
        }

        private void Enfermera_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(122, 220, 219));
            AbrirFormularioHijo(new Enfermera());
        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(122, 220, 219));
            AbrirFormularioHijo(new Administrador());
        }

        private void Programadores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(245, 241, 6));
            AbrirFormularioHijo(new Programadores());
        }

        

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFormularioActual.IconChar = IconChar.Home;
            iconFormularioActual.IconColor = Color.Gainsboro;
            TituloFormularioHijo.Text = "Inicio";
            TituloFormularioHijo.ForeColor = Color.Gainsboro;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconFormularioActual_Click(object sender, EventArgs e)
        {

        }
        private void Inicio_Click_1(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
            
        }

        
    }
}
