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
using Dominio;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == ".:.USUARIO.:.")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.FromArgb(1, 1, 2);
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = ".:.USUARIO.:.";
                Usuario.ForeColor = Color.FromArgb(40, 40, 40);
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == ".:.CONTRASEÑA.:.")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.FromArgb(1, 1, 2);
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = ".:.CONTRASEÑA.:.";
                Contraseña.ForeColor = Color.FromArgb(40, 40, 40);
                Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //metodo para mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == ".:.USUARIO.:.") {
                if (Contraseña.Text == ".:.CONTRASEÑA.:.")
                {

                }
                else {
                    msjError("Ingrese Su Contraseña De Usuario");
                }
            }
            else
            {
                msjError("Ingrese Su Nombre De Usuario");
            }
        }
        private void msjError(string msj)
        {
            Error_Mansaje.Text =  "     " + msj;
            Error_Mansaje.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Error_Mansaje_Click(object sender, EventArgs e)
        {

        }
    }
}
