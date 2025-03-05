using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio9._2
{
    public partial class Listadepeliculasdeanimacion : Form
    {
        public Listadepeliculasdeanimacion()
        {
            InitializeComponent();
            ConfigurarToolTip();
        }

        private ToolTip toolTip1 = new ToolTip();

        private void ConfigurarToolTip()
        {
            toolTip1.AutoPopDelay = 5000; 
            toolTip1.InitialDelay = 500;  
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(pictureBox1, "Una aventura épica en el multiverso Spider-Man.");
            toolTip1.SetToolTip(pictureBox2, "Po enfrenta nuevos desafíos en su viaje de autodescubrimiento.");
            toolTip1.SetToolTip(pictureBox3, "Un anciano y un niño exploran tierras remotas en una casa flotante.");
            toolTip1.SetToolTip(pictureBox4, "Una historia sobre la familia y la conexión cultural.");
            toolTip1.SetToolTip(pictureBox5, "Un robot solitario descubre el amor y la naturaleza humana.");
            toolTip1.SetToolTip(pictureBox6, "Un amor improbable bajo cielos cambiantes en Tokio.");

        }

        private void PTBREGRESAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para abrir un enlace en el navegador
        private void AbrirEnlace(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://cuevana.biz/pelicula/569094/spider-man-a-traves-del-spider-verso");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://cuevana.biz/pelicula/1011985/kung-fu-panda-4");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://cuevana.biz/pelicula/14160/up-una-aventura-de-altura");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://cuevana.biz/pelicula/354912/coco");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://cuevana.biz/pelicula/10681/walle");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirEnlace("https://cuevana.biz/pelicula/568160/el-tiempo-contigo");
        }
    }
}
