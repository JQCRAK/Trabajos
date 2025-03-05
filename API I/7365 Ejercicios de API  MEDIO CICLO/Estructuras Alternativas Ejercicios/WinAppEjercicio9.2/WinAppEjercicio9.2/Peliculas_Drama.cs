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
    public partial class Peliculas_Drama : Form
    {
        private ToolTip toolTip1 = new ToolTip();

        public Peliculas_Drama()
        {
            InitializeComponent();
            ConfigurarToolTip();
        }

        private void ConfigurarToolTip()
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(pictureBox1, "Una familia de clase baja se infiltra en la vida de una familia rica.");
            toolTip1.SetToolTip(pictureBox2, "Un hombre planea una fuga ingeniosa de la prisión.");
            toolTip1.SetToolTip(pictureBox3, "La vida de un hombre con un coeficiente intelectual bajo que vive aventuras sorprendentes.");
            toolTip1.SetToolTip(pictureBox4, "La vida extravagante de un corredor de bolsa en Wall Street.");
            toolTip1.SetToolTip(pictureBox5, "La historia del famoso villano que busca redención.");
            toolTip1.SetToolTip(pictureBox6, "La amistad entre un aristócrata cuadripléjico y su cuidador.");
        }


        private void PTBREGRESAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
