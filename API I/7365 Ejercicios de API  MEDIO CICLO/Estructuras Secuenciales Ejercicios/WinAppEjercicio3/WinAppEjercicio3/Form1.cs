using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WinAppEjercicio3
{
    public partial class Form1 : Form
    {
        string dato1;
        public Form1()
        {
            InitializeComponent();
            LBLRESUL.Visible = false;
            LBLTERESUL.Visible = false;
            LBLTIRESUL.Visible = false;  
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            string ValorTiempo = TXTBINGRESARV.Text.Replace(',', '.'); 

            if (!double.TryParse(ValorTiempo, NumberStyles.Any, CultureInfo.InvariantCulture, out double ValorTiempoE))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK);
                TXTBINGRESARV.Clear();
                TXTBINGRESARV.Focus();
                return;
            }

            if (ValorTiempoE < 0)
            {
                MessageBox.Show("El tiempo no puede ser negativo.", "Error de entrada", MessageBoxButtons.OK);
                TXTBINGRESARV.Clear();
                TXTBINGRESARV.Focus();
                return;
            }

            CalcularAltura Objaltura = new CalcularAltura(ValorTiempoE);

            LBLRESUL.Text = Objaltura.Caltura().ToString("F2", CultureInfo.InvariantCulture) + " metros";
            LBLRESUL.Visible = true;
            LBLTERESUL.Visible = true;
            LBLTIRESUL.Visible = true;
            TXTBINGRESARV.Clear();
            TXTBINGRESARV.Focus();
        }

        private void TXTBINGRESARV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (TXTBINGRESARV.Text.Contains('.') || TXTBINGRESARV.Text.Contains(',')))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(TXTBINGRESARV.Text))
                {
                    MessageBox.Show("Por favor, ingrese un valor antes de continuar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; 
                    TXTBINGRESARV.Focus();
                }
                else
                {
                    e.Handled = true;
                    BTNCALCULAR.PerformClick();
                }
            }
        }

        private void PCBRESET_Click(object sender, EventArgs e)
        {
            TXTBINGRESARV.Text = string.Empty;

            LBLRESUL.Text = "0";
            LBLRESUL.Visible = false;
            LBLTERESUL.Visible = false;
            LBLTIRESUL.Visible = false;

            TXTBINGRESARV.Focus();
        }
    }
}
