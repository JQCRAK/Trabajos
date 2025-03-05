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

namespace WinAppEjercicio7
{
    public partial class Form1 : Form
    {
        private void HandleNumericInput(TextBox textBox, KeyPressEventArgs e, TextBox nextControl = null)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (nextControl != null)
                {
                    nextControl.Focus();
                }
                return;
            }

            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar.ToString() != decimalSeparator || textBox.Text.Contains(decimalSeparator)))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un decimal", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTBCALORIFICA_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(TXTBCALORIFICA, e, TXTBTINICIAL);
        }

        private void TXTBTINICIAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(TXTBTINICIAL, e, TXTBTFINAL);
        }

        private void TXTBTFINAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(TXTBTFINAL, e, null);

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                BTNCALCULAR.Focus();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TXTBMASA.Text = string.Empty;
            TXTBCALORIFICA.Text = string.Empty;
            TXTBTINICIAL.Text = string.Empty;
            TXTBTFINAL.Text = string.Empty;
            LBLRESUL.Text = "0.00 J";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                var numberStyle = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
                var culture = CultureInfo.CurrentCulture;

                if (!double.TryParse(TXTBMASA.Text, numberStyle, culture, out double masa))
                {
                    MessageBox.Show("Valor de masa inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(TXTBCALORIFICA.Text, numberStyle, culture, out double capacidad))
                {
                    MessageBox.Show("Valor de capacidad calorífica inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(TXTBTINICIAL.Text, numberStyle, culture, out double tInicial))
                {
                    MessageBox.Show("Valor de temperatura inicial inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(TXTBTFINAL.Text, numberStyle, culture, out double tFinal))
                {
                    MessageBox.Show("Valor de temperatura final inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var calculo = new CalorNecesarioparaS(masa, capacidad, tInicial, tFinal);
                LBLRESUL.Text = calculo.CNecesario().ToString("F2", culture) + " J";
                TXTBMASA.Clear();
                TXTBCALORIFICA.Clear();
                TXTBTINICIAL.Clear();
                TXTBTFINAL.Clear();
                TXTBMASA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXTBMASA_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(TXTBMASA, e, TXTBCALORIFICA);
        }
    }
}
