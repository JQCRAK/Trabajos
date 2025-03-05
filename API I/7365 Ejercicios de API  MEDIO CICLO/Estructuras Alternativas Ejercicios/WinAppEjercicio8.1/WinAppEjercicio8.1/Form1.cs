using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBINGRESAR_TextChanged(object sender, EventArgs e)
        {
            if (TXTBINGRESAR.Text.Length > 0)
            {
                try
                {
                    int valoringresado = int.Parse(TXTBINGRESAR.Text);

                    if (valoringresado < 1 || valoringresado > 12)
                    {
                        MessageBox.Show("Por favor, ingrese un número entre 1 y 12.");
                        TXTBINGRESAR.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese solo números enteros entre 1 y 12.");
                    TXTBINGRESAR.Clear();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTNRESUL.Visible = false;
        }


        private void BTNCONVERTIR_Click(object sender, EventArgs e)
        {
            CalcularMes();
            TXTBINGRESAR.Clear();
        }

        private void CalcularMes()
        {
            try
            {
                int valoringresado = int.Parse(TXTBINGRESAR.Text);
                string mes;

                switch (valoringresado)
                {
                    case 1: mes = "Enero"; break;
                    case 2: mes = "Febrero"; break;
                    case 3: mes = "Marzo"; break;
                    case 4: mes = "Abril"; break;
                    case 5: mes = "Mayo"; break;
                    case 6: mes = "Junio"; break;
                    case 7: mes = "Julio"; break;
                    case 8: mes = "Agosto"; break;
                    case 9: mes = "Septiembre"; break;
                    case 10: mes = "Octubre"; break;
                    case 11: mes = "Noviembre"; break;
                    case 12: mes = "Diciembre"; break;
                    default:
                        mes = "Número fuera de rango.";
                        break;
                }

                BTNRESUL.Text = mes;
                BTNRESUL.Visible = true;
                TXTBINGRESAR.Clear();
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void TXTBINGRESAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CalcularMes();
                
            }
        }
    }
}
