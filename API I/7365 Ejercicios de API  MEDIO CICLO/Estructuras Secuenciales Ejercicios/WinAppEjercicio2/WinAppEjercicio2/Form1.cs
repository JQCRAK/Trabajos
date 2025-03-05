using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            string Valormasa = TXTBMASA.Text;
            string ValorVelocidad = TXTVELOCIDAD.Text;

            // Convertir valores con formato invariante
            if (!double.TryParse(Valormasa, System.Globalization.NumberStyles.Float,
                                 System.Globalization.CultureInfo.InvariantCulture, out double ValormasaE) ||
                !double.TryParse(ValorVelocidad, System.Globalization.NumberStyles.Float,
                                 System.Globalization.CultureInfo.InvariantCulture, out double ValorVelocidadE))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de entrada", MessageBoxButtons.OK);
                return;
            }

            if (ValormasaE <= 0)
            {
                MessageBox.Show("Por favor, ingrese una masa válida mayor que 0.", "Error de entrada", MessageBoxButtons.OK);
                TXTBMASA.Text = string.Empty;
                TXTBMASA.Focus();
                return;
            }
            else if (ValorVelocidadE < 0)
            {
                MessageBox.Show("Por favor, ingrese una velocidad válida mayor o igual a 0.", "Error de entrada", MessageBoxButtons.OK);
                TXTVELOCIDAD.Text = string.Empty;
                TXTVELOCIDAD.Focus();
                return;
            }

            CalcularEnergiaCinetica ObjCalcular = new CalcularEnergiaCinetica(ValormasaE, ValorVelocidadE);
            LBLRESULTADO.Text = ObjCalcular.EnergiaCinetica().ToString("F2") + " J";
            TXTBMASA.Clear();
            TXTVELOCIDAD.Clear();
            BTNCALCULAR.Focus();
            TXTBMASA.Focus();
        }

        private void TXTVELOCIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, TXTVELOCIDAD);
        }

        private void TXTBMASA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaDecimal(e, TXTBMASA);
        }

        private void ValidarEntradaDecimal(KeyPressEventArgs e, TextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            if (textBox.Text.Contains("."))
            {
                string[] partes = textBox.Text.Split('.');
                if (partes.Length > 1 && partes[1].Length >= 4 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(textBox, true, true, true, true);
            }
        }
    }
}