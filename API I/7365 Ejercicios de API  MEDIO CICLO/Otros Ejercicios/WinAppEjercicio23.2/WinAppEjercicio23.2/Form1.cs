using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppEjercicio23._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBVALOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                {
                    e.Handled = true; 
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    
                    BTNSUMAR.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BTNSUMAR_Click(object sender, EventArgs e)
        {
            string ValorSumar = TXTBVALOR.Text;
            SumarNumeros objSuma = new SumarNumeros(ValorSumar);
            LBLRESUL.Text = objSuma.CalcularSuma().ToString();
            TXTBVALOR.Focus();
            TXTBVALOR.Clear();

        }
    }
}
