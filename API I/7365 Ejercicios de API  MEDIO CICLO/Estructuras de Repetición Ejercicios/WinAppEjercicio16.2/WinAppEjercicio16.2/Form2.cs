using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio16._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GenerarTabla();
        }

        private void GenerarTabla()
        {
            dataGridView1.Rows.Clear();

            var conversion = new Conversion(48, 84);

            var tabla = conversion.GenerarTabla();

            if (tabla == null)
            {
                MessageBox.Show("El rango de pulgadas es inválido. Debe estar entre 48 y 84.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTBN.Clear();
                TXTBN.Focus();
                return;
            }

            foreach (var (pulgadas, centimetros) in tabla)
            {
                dataGridView1.Rows.Add(pulgadas, centimetros);
            }
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
                    BTNBUSCAR.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                string textoIngresado = TXTBN.Text;

                if (int.TryParse(textoIngresado, out int valorIngresado))
                {
                    if (valorIngresado >= 48 && valorIngresado <= 84)
                    {
                        MostrarEnDataGridView(valorIngresado);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor entre 48 y 84 pulgadas.", "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXTBN.Clear();
                        TXTBN.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MostrarEnDataGridView(int pulgadas)
        {
            double centimetros = pulgadas * 2.54;

            DataGridViewRow nuevaFila = new DataGridViewRow();
            nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = pulgadas + "\"" });
            nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = centimetros.ToString("F2") + " cm" });

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(nuevaFila);
            TXTBN.Clear();
            TXTBN.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                TXTBN.Clear();

                dataGridView1.Rows.Clear();

                TXTBN.Focus();
                GenerarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BTNBUSCAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string textoIngresado = TXTBN.Text;

                if (int.TryParse(textoIngresado, out int valorIngresado))
                {
                    if (valorIngresado >= 48 && valorIngresado <= 84)
                    {
                        MostrarEnDataGridView(valorIngresado);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor entre 48 y 84 pulgadas.", "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXTBN.Clear();
                        TXTBN.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
