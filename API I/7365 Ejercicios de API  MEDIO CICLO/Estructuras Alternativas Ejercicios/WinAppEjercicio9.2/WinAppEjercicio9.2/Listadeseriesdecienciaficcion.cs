using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio9._2
{
    public partial class Peliculas_CienciaFiccion : Form
    {
        private ToolTip toolTip1 = new ToolTip();

        public Peliculas_CienciaFiccion()
        {
            InitializeComponent();
            ConfigurarToolTip();
        }

        private void ConfigurarToolTip()
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;

            // Asumiendo que tienes seis PictureBox
            toolTip1.SetToolTip(pictureBox1, "Un nuevo blade runner desentierra un secreto que podría sumergir lo que queda de la sociedad en el caos.");
            toolTip1.SetToolTip(pictureBox2, "En un mundo alienígena, un exmarine se infiltra en la cultura de los Na'vi y descubre un nuevo propósito.");
            toolTip1.SetToolTip(pictureBox3, "Un joven viaja al pasado en una máquina del tiempo y debe asegurarse de que sus padres se conozcan.");
            toolTip1.SetToolTip(pictureBox4, "Los Autobots y los Decepticons se unen a un nuevo grupo de Transformers en una guerra intergaláctica.");
            toolTip1.SetToolTip(pictureBox5, "Un científico lucha por encontrar una cura en un mundo devastado por un virus mortal que transforma a las personas en monstruos.");
            toolTip1.SetToolTip(pictureBox6, "Una organización secreta controla las actividades extraterrestres en la Tierra y protege a la humanidad de sus amenazas.");
        }

        private void PTBREGRESAR_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
