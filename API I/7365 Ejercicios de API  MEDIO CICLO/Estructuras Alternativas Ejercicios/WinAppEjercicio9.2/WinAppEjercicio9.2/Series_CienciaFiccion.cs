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
    public partial class Series_CienciaFiccion : Form
    {
        private ToolTip toolTip3 = new ToolTip();

        public Series_CienciaFiccion()
        {
            InitializeComponent();
            ConfigurarToolTip();
        }

        private void ConfigurarToolTip()
        {
            toolTip3.AutoPopDelay = 5000;
            toolTip3.InitialDelay = 500;
            toolTip3.ReshowDelay = 500;

            toolTip3.SetToolTip(pictureBox1, "Un grupo de amigos se enfrenta a fenómenos paranormales en su pequeña ciudad.");
            toolTip3.SetToolTip(pictureBox2, "La historia de un cazarrecompensas que protege a un joven ser de otro mundo en el espacio.");
            toolTip3.SetToolTip(pictureBox3, "Un mundo donde los personajes de videojuegos luchan por el control de su ciudad.");
            toolTip3.SetToolTip(pictureBox4, "Una antología de historias oscuras que exploran la relación entre la tecnología y la humanidad.");
            toolTip3.SetToolTip(pictureBox5, "Las aventuras interdimensionales de un científico loco y su nieto en su viaje por el multiverso.");
            toolTip3.SetToolTip(pictureBox6, "Las misteriosas y divertidas aventuras de dos hermanos que descubren secretos en su pequeño pueblo.");
        }

        private void PTBREGRESAR_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar este formulario al hacer clic en el botón regresar
        }
    }
}
