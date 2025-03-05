using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio17._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
               
                    if (!string.IsNullOrWhiteSpace(((TextBox)sender).Text))
                    {
                        BTNCALCULAR.Focus(); 
                    }
                    else
                    {
                        MessageBox.Show("El campo no puede estar vacío. Por favor, ingresa un número.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BTNCALCULAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ValorN = TXTBN.Text;
            int ValorNE = int.Parse(ValorN);
            Serie objSerie = new Serie(ValorNE);
            LBLRESUL.Text = objSerie.CalcularSerie().ToString();
            label3.Visible = true;
            LBLRESUL.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            LBLRESUL.Visible = false;
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            
            string ValorN = TXTBN.Text;
            int ValorNE = int.Parse(ValorN);
            Serie objSerie = new Serie(ValorNE);
            LBLRESUL.Text = objSerie.CalcularSerie().ToString("F2");
            label3.Visible = true;
            LBLRESUL.Visible = true;
            TXTBN.Clear();
            TXTBN.Focus();
        }
    }
}
