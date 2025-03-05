using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicioPresentacionG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetButtonColors()
        {
            // Restablece el color de todos los botones a Crimson
            BTNINICIO.BackColor = Color.Crimson;
            BTNEJERCICIOSSECUENCIALES.BackColor = Color.Crimson;
            BTNEJERCICIOSALTERNATIVAS.BackColor = Color.Crimson;
            BTNEJERREPETICION.BackColor = Color.Crimson;
            BTNEJEROTROS.BackColor = Color.Crimson;
        }
        private void BTNINICIO_Click(object sender, EventArgs e)
        {
            ResetButtonColors(); // Restablece colores a Crimson
            BTNINICIO.BackColor = Color.DarkRed; // Cambia a DarkRed para resaltar el botón activo

            PNINICIO.Visible = true;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = false;
        }

        private void BTNEJERCICIOSSECUENCIALES_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BTNEJERCICIOSSECUENCIALES.BackColor = Color.DarkRed;
            PNINICIO.Visible = false;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = true;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = false;
        }

        private void BTNEJERCICIOSALTERNATIVAS_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BTNEJERCICIOSALTERNATIVAS.BackColor = Color.DarkRed;
            PNINICIO.Visible = false;
            PNALTERNATIVAS.Visible = true;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = false;
        }

        private void BTNEJERREPETICION_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BTNEJERREPETICION.BackColor = Color.DarkRed;
            PNINICIO.Visible = false;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = true;
            PNPERFIL.Visible = false;
        }

        private void BTNEJEROTROS_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            BTNEJEROTROS.BackColor = Color.DarkRed;
            PNINICIO.Visible = false;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = true;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = false;
        }

        private void PCBPERFIL_Click(object sender, EventArgs e)
        {
            PNINICIO.Visible = false;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = true;
        }

        private void PCTBINICIO_Click(object sender, EventArgs e)
        {
            PNINICIO.Visible = true;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PNINICIO.Visible = true;
            PNALTERNATIVAS.Visible = false;
            PNOTRO.Visible = false;
            PNSECUENCIAL.Visible = false;
            PNREPETICIONES.Visible = false;
            PNPERFIL.Visible = false;

        }

        private void PCTBEJERCICIO1_Click(object sender, EventArgs e)
        {
            WinAppEjercicio1.Form1 objEjercicio1  = new WinAppEjercicio1.Form1();
            objEjercicio1.ShowDialog();
        }

        private void PCTBEJERCICIO2_Click(object sender, EventArgs e)
        {
            WinAppEjercicio2.Form1 objEjercicio2 = new WinAppEjercicio2.Form1();
            objEjercicio2.ShowDialog();
        }

        private void PCTBEJERCICIO3_Click(object sender, EventArgs e)
        {
            WinAppEjercicio3.Form1 objEjercicio3 = new WinAppEjercicio3.Form1();
            objEjercicio3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WinAppEjercicio4.Form1 objEjercicio4 = new WinAppEjercicio4.Form1();
            objEjercicio4.ShowDialog();
        }

        private void PCTBEJERCICIO5_Click(object sender, EventArgs e)
        {
            WinAppEjercicio5.Form1 objEjercicio5 = new WinAppEjercicio5.Form1();
            objEjercicio5.ShowDialog();
        }

        private void PCTBEJERCICIO6_Click(object sender, EventArgs e)
        {
            WinAppEjercicio6.Form1 objEjercicio6 = new WinAppEjercicio6.Form1();
            objEjercicio6.ShowDialog();
        }

        private void PCTBEJERCICIO7_Click(object sender, EventArgs e)
        {
            WinAppEjercicio7.Form1 objEjercicio7 = new WinAppEjercicio7.Form1();
            objEjercicio7.ShowDialog();
        }

        private void PCTBEJERCICIO8_Click(object sender, EventArgs e)
        {
            WinAppEjercicio8._1.Form1 objEjercicio8 = new WinAppEjercicio8._1.Form1();
            objEjercicio8.ShowDialog();
        }

        private void PCTBEJERCICIO9_Click(object sender, EventArgs e)
        {
            WinAppEjercicio9._2.Form1 objEjercicio9 = new WinAppEjercicio9._2.Form1();
            objEjercicio9.ShowDialog();
        }

        private void PCTBEJERCICIO10_Click(object sender, EventArgs e)
        {
            WinAppEjercicio10._3.Form1 objEjercicio10 = new WinAppEjercicio10._3.Form1();
            objEjercicio10.ShowDialog();
        }

        private void PCTBEJERCICIO11_Click(object sender, EventArgs e)
        {
            WinAppEjercicio11._4.Form1 objEjercicio11 = new WinAppEjercicio11._4.Form1();
            objEjercicio11.ShowDialog();
        }

        private void PCTBEJERCICIO12_Click(object sender, EventArgs e)
        {
            WinAppEjercicio12._5.Form1 objEjercicio12 = new WinAppEjercicio12._5.Form1();
            objEjercicio12.ShowDialog();
        }

        private void PCTBEJERCICIO13_Click(object sender, EventArgs e)
        {
            WinAppEjercicio13._6.Form1 objEjercicio13 = new WinAppEjercicio13._6.Form1();
            objEjercicio13.ShowDialog();
        }

        private void PCTBEJERCICIO14_Click(object sender, EventArgs e)
        {
            WinAppEjercicio14._7._1.Form1 objEjercicio14 = new WinAppEjercicio14._7._1.Form1();
            objEjercicio14.ShowDialog();
        }

        private void PCTBEJERCICIO15_Click(object sender, EventArgs e)
        {
            WinAppEjercicio15._1.Form1 objEjercicio15 = new WinAppEjercicio15._1.Form1();
            objEjercicio15.ShowDialog();
        }

        private void PCTBEJERCICIO16_Click(object sender, EventArgs e)
        {
            WinAppEjercicio16._2.Form1 objEjercicio16 = new WinAppEjercicio16._2.Form1();
            objEjercicio16.ShowDialog();
        }

        private void PCTBEJERCICIO17_Click(object sender, EventArgs e)
        {
            WinAppEjercicio17._3.Form1 objEjercicio17 = new WinAppEjercicio17._3.Form1();
            objEjercicio17.ShowDialog();
        }

        private void PCTBEJERCICIO18_Click(object sender, EventArgs e)
        {
            WinAppEjercicio18._4.Form1 objEjercicio18 = new WinAppEjercicio18._4.Form1();
            objEjercicio18.ShowDialog();    
        }

        private void PCTBEJERCICIO19_Click(object sender, EventArgs e)
        {
            WinAppEjercicio19._5.Form1 objEjercicio19 = new WinAppEjercicio19._5.Form1();
            objEjercicio19.ShowDialog();
        }

        private void PCTBEJERCICIO20_Click(object sender, EventArgs e)
        {
            WinAppEjercicio20._6.Form1 objEjercicio20 = new WinAppEjercicio20._6.Form1();
            objEjercicio20.ShowDialog();

        }

        private void PCTBEJERCICIO21_Click(object sender, EventArgs e)
        {
            WinAppEjercicio21._7.Form1 objEjercicio21 = new WinAppEjercicio21._7.Form1();
            objEjercicio21.ShowDialog();
        }

        private void PCTBEJERCICIO22_Click(object sender, EventArgs e)
        {
            WinAppEjercicio22._1.Form1 objEjercicio22 = new WinAppEjercicio22._1.Form1();
            objEjercicio22.ShowDialog();
        }

        private void PCTBEJERCICIO23_Click(object sender, EventArgs e)
        {
            WinAppEjercicio23._2.Form1 objEjercicio23 = new WinAppEjercicio23._2.Form1();
            objEjercicio23.ShowDialog();
        }

        private void PCTBEJERCICIO24_Click(object sender, EventArgs e)
        {
            WinAppEjercicio24._3.Form1 objEjercicio24 = new WinAppEjercicio24._3.Form1();
            objEjercicio24.ShowDialog();
        }
    }
}
