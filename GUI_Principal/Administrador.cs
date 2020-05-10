using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Principal
{
    public partial class Administrador : Form
    {
        private Form currentChildForm;
        public Administrador()
        {
            InitializeComponent();
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
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
