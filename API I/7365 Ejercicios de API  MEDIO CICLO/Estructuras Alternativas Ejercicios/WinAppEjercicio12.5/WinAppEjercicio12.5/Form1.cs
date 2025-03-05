using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio12._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBARBITRO1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                if ((sender as TextBox).Text.Contains('.'))
                {
                    string[] parts = (sender as TextBox).Text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (double.TryParse((sender as TextBox).Text, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        if (value >= 0.0 && value <= 10.0)
                        {
                            TXTBARBITRO2.Focus(); 
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingresa un valor entre 0.0 y 10.0");
                            (sender as TextBox).SelectAll();
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
                        {
                            MessageBox.Show("Por favor, ingresa un valor válido");
                            (sender as TextBox).SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTBARBITRO2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                if ((sender as TextBox).Text.Contains('.'))
                {
                    string[] parts = (sender as TextBox).Text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (double.TryParse((sender as TextBox).Text, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        if (value >= 0.0 && value <= 10.0)
                        {
                            TXTBARBITRO3.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingresa un valor entre 0.0 y 10.0");
                            (sender as TextBox).SelectAll();
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
                        {
                            MessageBox.Show("Por favor, ingresa un valor válido");
                            (sender as TextBox).SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTBARBITRO3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                if ((sender as TextBox).Text.Contains('.'))
                {
                    string[] parts = (sender as TextBox).Text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (double.TryParse((sender as TextBox).Text, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        if (value >= 0.0 && value <= 10.0)
                        {
                            TXTBARBITRO4.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingresa un valor entre 0.0 y 10.0");
                            (sender as TextBox).SelectAll();
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
                        {
                            MessageBox.Show("Por favor, ingresa un valor válido");
                            (sender as TextBox).SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTBARBITRO4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                if ((sender as TextBox).Text.Contains('.'))
                {
                    string[] parts = (sender as TextBox).Text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (double.TryParse((sender as TextBox).Text, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        if (value >= 0.0 && value <= 10.0)
                        {
                            TXTBARBITRO5.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingresa un valor entre 0.0 y 10.0");
                            (sender as TextBox).SelectAll();
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
                        {
                            MessageBox.Show("Por favor, ingresa un valor válido");
                            (sender as TextBox).SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTBARBITRO5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }

                if ((sender as TextBox).Text.Contains('.'))
                {
                    string[] parts = (sender as TextBox).Text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (double.TryParse((sender as TextBox).Text, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        if (value >= 0.0 && value <= 10.0)
                        {
                            BTNCALCULAR.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingresa un valor entre 0.0 y 10.0");
                            (sender as TextBox).SelectAll();
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
                        {
                            MessageBox.Show("Por favor, ingresa un valor válido");
                            (sender as TextBox).SelectAll();
                        }
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
            panel2.Visible = false;
        }

        private void PCBRESET_Click(object sender, EventArgs e)
        {
            TXTBARBITRO1.Clear();
            TXTBARBITRO2.Clear();
            TXTBARBITRO3.Clear();
            TXTBARBITRO4.Clear();
            TXTBARBITRO5.Clear();
            panel2.Visible = false;
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                panel2.Visible = true;

                var culture = System.Globalization.CultureInfo.InvariantCulture;

                float ValorArbitro1E = float.Parse(TXTBARBITRO1.Text, culture);
                float ValorArbitro2E = float.Parse(TXTBARBITRO2.Text, culture);
                float ValorArbitro3E = float.Parse(TXTBARBITRO3.Text, culture);
                float ValorArbitro4E = float.Parse(TXTBARBITRO4.Text, culture);
                float ValorArbitro5E = float.Parse(TXTBARBITRO5.Text, culture);

                PuntuacionGimnasta OBJPUNTUACION = new PuntuacionGimnasta(
                    ValorArbitro1E, ValorArbitro2E, ValorArbitro3E, ValorArbitro4E, ValorArbitro5E);

                LBLRESUL.Text = OBJPUNTUACION.CalcularPuntuacion().ToString("F1", culture);
                TXTBARBITRO2.Clear();
                TXTBARBITRO1.Clear();
                TXTBARBITRO3.Clear();
                TXTBARBITRO4.Clear();
                TXTBARBITRO5.Clear();
                TXTBARBITRO1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
