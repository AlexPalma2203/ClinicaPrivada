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
    public partial class Registros : Form
    {
        private Form currentChildForm;
        public Registros()
        {
            InitializeComponent();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

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
        private void Enfermera_Load(object sender, EventArgs e)
        {
            
        }
    }
}
