using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSlide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Final = false;
        int slide = 0; 

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(slide == 0)
            {
                panel1.Left -= 10;
                if (panel1.Left <= -251)
                {
                    timer1.Stop();
                    slide = 1;
                    next.IconColor = Color.FromArgb(92, 75, 212);
                    slidePass.IconColor = Color.Gainsboro;
                    pass1.IconColor = Color.FromArgb(92, 75, 212);
                }
            }
            else if (slide == 1)
            {
                panel1.Left -= 10;
                if (panel1.Left <= -502)
                {
                    timer1.Stop();
                    slide = 2;
                    slidePass.IconColor = Color.Gainsboro;
                    pass1.IconColor = Color.Gainsboro;
                    pass2.IconColor = Color.FromArgb(242, 133, 110);
                    next.IconColor = Color.FromArgb(242, 133, 110);

                }
            }
            else if (slide == 2)
            {
                panel1.Left -= 10;
                if (panel1.Left <= -758)
                {
                    timer1.Stop();
                    slide = 3;
                    slidePass.IconColor = Color.Gainsboro;
                    pass1.IconColor = Color.Gainsboro;
                    pass2.IconColor = Color.Gainsboro;
                    pass3.IconColor = Color.FromArgb(81, 169, 236);
                    next.IconColor = Color.FromArgb(81, 169, 236);
                    
                }
            }
            else if (slide == 3)
            {
                panel1.Left -= 10;
                if (panel1.Left <= -1010)
                {
                    timer1.Stop();
                    slide = 4;
                    slidePass.IconColor = Color.Gainsboro;
                    pass1.IconColor = Color.Gainsboro;
                    pass2.IconColor = Color.Gainsboro;
                    pass3.IconColor = Color.Gainsboro;
                    pass4.IconColor = Color.FromArgb(164, 121, 230);
                    next.IconColor = Color.FromArgb(164, 121, 230);
                    Final = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblReportes.Text = "Podras Vizualizar Cuanto Dinero\nHaz Ganado Por Mes, Hasta El Dia\nActual, Tambien Veras El Total De\nLas Citas Citas Y El Total Del Dinero\nGanado Hasta El Presente Dia";
            lblProgramadores.Text = "Aqui Se Encontraran Las Personas\nQue Trabajaron En Este Proyecto\nDesde La Investigacion, Hasta\n La Programacion y Creacion de\nBase la Base de Datos. ";
            lblPaciente.Text = "Aqui Podras Buscar Al Paciente\nSegun El Dui Para Pasar Consulta\nRecuerda Que El Paciente Tiene\nQue Tener Un Expediente Creado\nPreviamente Este Expediente Se\nPuede Actualizar O Modificar\n\nTambien Encontras Todos Los \nRegistros De Las Consultas Hechas";
            lblCitas.Text =    "En Este Apartada Podras Buscar\nPor El Numero de Dui,Se Mostrara\nLa Fecha De La Cita Mas Proxima\nPodras Crear Nuevas Citas Y \nActualizarlas, Tambien Dispone De\nUn Apartado Para Vizualizar Todas\nLas Citas.\n\nPodras Hacer La Busquedad Solo \nPor Dui,Solo Por Fecha O Ambas ";
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (Final==true) {
                this.Close();
            }
            timer1.Start();
        }
    }
}
