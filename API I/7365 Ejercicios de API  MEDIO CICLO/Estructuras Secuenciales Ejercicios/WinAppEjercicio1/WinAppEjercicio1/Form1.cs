using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppEjercicio1
{
    public partial class Form1 : Form
    {
        private int progreso = 0;

        public Form1()
        {
            InitializeComponent();
            progressBarCifras.Minimum = 0;
            progressBarCifras.Maximum = 100;
            progressBarCifras.Value = 0;
        }

        private async void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            string ValorNumero = TXTBINGRESARV.Text;
            long ValorNumeroE;

            if (long.TryParse(ValorNumero, out ValorNumeroE))
            {
                progreso = 0;
                progressBarCifras.Value = progreso;

                await SimularProgreso();

                ContarCifras ObjCifra = new ContarCifras(ValorNumeroE);
                LBLRESUL.Text = ObjCifra.CifraNumero().ToString();
                PTBRESET.Focus();

            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTBINGRESARV.Text = string.Empty;
                TXTBINGRESARV.Focus();
            }
        }

        private async Task SimularProgreso()
        {
            while (progreso < 100)
            {
                progreso += 10;
                progressBarCifras.Value = progreso;

                await Task.Delay(300); 
            }
        }

        private void PTBRESET_Click(object sender, EventArgs e)
        {
            TXTBINGRESARV.Text = string.Empty;
            progressBarCifras.Value = 0;
            LBLRESUL.Text = string.Empty;
            TXTBINGRESARV.Focus();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTBINGRESARV_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(TXTBINGRESARV.Text))
                    {
                        e.Handled = true; 
                        MessageBox.Show("Please fill in the required field.");
                    }
                    else
                    {
                        e.Handled = true; 
                        BTNCALCULAR.Focus(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXTBINGRESARV.Focus();
        }
    }
}
