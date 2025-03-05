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

namespace WinAppEjercicio15._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBN_KeyPress(object sender, KeyPressEventArgs e)
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
                    BTNGENERAR.Focus(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PNRESUL.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PNRESUL.Visible=false;
            TXTBN.Clear();
        }

        private void BTNGENERAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            PNRESUL.Visible = true;
            string ValorSerie = TXTBN.Text;
            int ValorSerieE = int.Parse(ValorSerie);
            SerieFibonacci objSerie = new SerieFibonacci(ValorSerieE);
            LBLRESUL.Text = objSerie.GenerarSerie().ToString();
            TXTBN.Clear();
            TXTBN.Focus();
        }

        private void BTNGENERAR_Click(object sender, EventArgs e)
        {
            TXTBN.Clear();
            TXTBN.Focus();
        }
    }
}
