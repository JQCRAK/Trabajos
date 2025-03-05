using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio4
{
    public partial class Form1 : Form

    {
        double valor1, valor2;
        double ResultSalarioB, ResulImpu, ResulSalarioN;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TXTBHORA.Text = string.Empty;
            TXTBTRABAJAS.Text = string.Empty;
            LBLRESULSALARIOBRUTO.Text = "0";
            LBLIRESULMPUESTOS.Text = "0";
            LBLRESULSALARIONETO.Text = "0";
            TXTBHORA.Focus();
        }

        

        private void TXTBTRABAJAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                if (ValidarYAsignar(TXTBTRABAJAS, ref valor2)) 
                {
                    BTNCALCULARS.Focus(); 
                }
            }
        }

        private void TXTBHORA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                if (ValidarYAsignar(TXTBHORA, ref valor1))
                {
                    TXTBTRABAJAS.Focus(); 
                }
            }
        }

        private bool ValidarYAsignar(TextBox textBox, ref double valor)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Entrada inválida", MessageBoxButtons.OK);
                    textBox.Focus();
                    return false;
                }

                if (!double.TryParse(textBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                {
                    MessageBox.Show("Solo se permiten números válidos.", "Entrada inválida", MessageBoxButtons.OK);
                    textBox.Focus();
                    return false;
                }

                if (textBox.Text.Contains(".") && textBox.Text.Split('.')[1].Length > 2)
                {
                    MessageBox.Show("Solo se permiten hasta tres decimales.", "Entrada inválida", MessageBoxButtons.OK);
                    textBox.Focus();
                    return false;
                }

                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK);
                textBox.Focus();
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCALCULARS_Click(object sender, EventArgs e)
        {
            if (ValidarYAsignar(TXTBHORA, ref valor1) && ValidarYAsignar(TXTBTRABAJAS, ref valor2))
            {
                CalcularSalarioN ObjSalario = new CalcularSalarioN(valor1, valor2);

                LBLRESULSALARIOBRUTO.Text = ObjSalario.ObtenerSalarioBruto().ToString("F2");
                LBLIRESULMPUESTOS.Text = ObjSalario.ObtenerImpuestos().ToString("F2");
                LBLRESULSALARIONETO.Text = ObjSalario.ObtenerSalarioNeto().ToString("F2");
                TXTBHORA.Clear();
                TXTBTRABAJAS.Clear();
                TXTBHORA.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores válidos para la tarifa por hora y las horas trabajadas.", "Entrada inválida", MessageBoxButtons.OK);
            }
        }
    }
}
