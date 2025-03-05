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
    public partial class Listas_Series_Drama : Form
    {
        private ToolTip toolTip1 = new ToolTip();

        public Listas_Series_Drama()
        {
            InitializeComponent();
            ConfigurarToolTip();
        }

        private void ConfigurarToolTip()
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(pictureBox1, "Un grupo de niños se enfrenta a criaturas sobrenaturales en su pequeño pueblo.");
            toolTip1.SetToolTip(pictureBox2, "Un cazarrecompensas de otro mundo protege a un niño misterioso en una galaxia lejana.");
            toolTip1.SetToolTip(pictureBox3, "Una serie animada que explora diferentes mundos de magia y fantasía.");
            toolTip1.SetToolTip(pictureBox4, "Una antología de historias oscuras que examinan la sociedad moderna.");
            toolTip1.SetToolTip(pictureBox5, "Las aventuras de un científico loco y su nieto a través de realidades alternas.");
            toolTip1.SetToolTip(pictureBox6, "Las extrañas y misteriosas aventuras de dos hermanos en un pueblo lleno de secretos.");
        }

        private void PTBREGRESAR_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
