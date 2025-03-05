using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio6
{
    public partial class Form1 : Form
    {
        string dato1, dato2, dato3;
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTVALOR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                    TXTVALOR2.Clear();
                    MessageBox.Show("Solo se permiten números decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (e.KeyChar == '.' && TXTVALOR2.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    try
                    {
                        if (double.TryParse(TXTVALOR2.Text, out _))
                        {
                            dato2 = TXTVALOR2.Text;
                            TXTVALOR3.Focus();
                        }
                        else
                        {
                            TXTVALOR2.Clear();
                            MessageBox.Show("Ingrese un número decimal válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        TXTVALOR2.Clear();
                        MessageBox.Show("Error al procesar el número: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                TXTVALOR2.Clear();
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXTVALOR3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                    TXTVALOR3.Clear();
                    MessageBox.Show("Solo se permiten números decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (e.KeyChar == '.' && TXTVALOR3.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    try
                    {
                        if (double.TryParse(TXTVALOR3.Text, out _))
                        {
                            dato3 = TXTVALOR3.Text;
                            BTNCALCULAR.Focus();
                        }
                        else
                        {
                            TXTVALOR3.Clear();
                            MessageBox.Show("Ingrese un número decimal válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        TXTVALOR3.Clear();
                        MessageBox.Show("Error al procesar el número: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                TXTVALOR3.Clear();
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PCBRESET_Click(object sender, EventArgs e)
        {
            TXTVALOR1.Text = string.Empty;
            TXTVALOR2.Text = string.Empty;
            TXTVALOR3.Text = string.Empty;
            LBLRESUL.Text = "  0.0   N";
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                string ValorMasa1 = TXTVALOR1.Text;
                string ValorMasa2 = TXTVALOR2.Text;
                string ValorDistancia = TXTVALOR3.Text;

                double ValorMasa1E = double.Parse(ValorMasa1);
                double ValorMasa2E = double.Parse(ValorMasa2);
                double ValorMasa3E = double.Parse(ValorDistancia);

                CalcularFuerzaG ObjFuerzaGr = new CalcularFuerzaG(ValorMasa1E, ValorMasa2E, ValorMasa3E);
                double resultado = ObjFuerzaGr.FuerzaGra();

                string resultadoFormateado;
                if (resultado != 0)
                {
                    int exponente = (int)Math.Floor(Math.Log10(Math.Abs(resultado)));
                    double mantisa = resultado / Math.Pow(10, exponente);
                    resultadoFormateado = $"{mantisa:F4} × 10^{exponente}";
                    TXTVALOR1.Clear();
                    TXTVALOR1.Focus();
                    TXTVALOR2.Clear();
                    TXTVALOR3.Clear();
                }
                else
                {
                    resultadoFormateado = "0";
                }

                LBLRESUL.Text = resultadoFormateado+" N";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXTVALOR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                    TXTVALOR1.Clear();
                    MessageBox.Show("Solo se permiten números decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (e.KeyChar == '.' && TXTVALOR1.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    try
                    {
                        if (double.TryParse(TXTVALOR1.Text, out _))
                        {
                            dato1 = TXTVALOR1.Text;
                            TXTVALOR2.Focus();
                        }
                        else
                        {
                            TXTVALOR1.Clear();
                            MessageBox.Show("Ingrese un número decimal válido", "Error", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        TXTVALOR1.Clear();
                        MessageBox.Show("Error al procesar el número: " + ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                TXTVALOR1.Clear();
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }    
    }
}
