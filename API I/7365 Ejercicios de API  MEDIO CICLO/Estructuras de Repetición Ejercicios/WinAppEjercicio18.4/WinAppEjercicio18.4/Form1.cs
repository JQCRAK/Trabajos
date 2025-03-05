using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppEjercicio18._4
{
    public partial class Form1 : Form
    {
        private Matriz matriz;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellValidating += dataGridView1_CellValidating;
        }

        private void TXTBFILA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrWhiteSpace(TXTBFILA.Text) || int.Parse(TXTBFILA.Text) <= 0)
                {
                    MessageBox.Show("Ingrese un número válido para las filas (mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TXTBCOLUMNA.Focus();
                }
            }
        }

        private void TXTBCOLUMNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 

                if (string.IsNullOrWhiteSpace(TXTBCOLUMNA.Text) || int.Parse(TXTBCOLUMNA.Text) <= 0)
                {
                    MessageBox.Show("Ingrese un número válido para las columnas (mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BTNCREARM.Focus();
                }
            }

        }

        

        private void BTNCALCULARM_Click(object sender, EventArgs e)
        {
            try
            {
                string ValorMatrizF = TXTBFILA.Text;
                string ValorMatrizC = TXTBCOLUMNA.Text;

                int ValorMatrizFE = int.Parse(ValorMatrizF);
                int ValorMatrizCE = int.Parse(ValorMatrizC);

                Matriz objMatriz = new Matriz(ValorMatrizFE, ValorMatrizCE);
                GPBRESULTADOS.Visible = true;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            int valor;
                            if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out valor))
                            {
                                objMatriz.AsignarValor(i, j, valor);
                            }
                            else
                            {
                                MessageBox.Show($"El valor en la fila {i + 1}, columna {j + 1} no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"El valor en la fila {i + 1}, columna {j + 1} está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }


                LBLEPOSITIVO.Text = objMatriz.ContarPositivos().ToString();
                LBLENEGATIVOS.Text = objMatriz.ContarNegativos().ToString();
                LBLSCPARES.Text = objMatriz.SumarColumnasPares().ToString();
                LBLSUMATOTAL.Text = objMatriz.SumarElementos().ToString();
                LBLMLTIPLICACIONN.Text = objMatriz.MultiplicarNegativos().ToString();
                TXTBCOLUMNA.Clear();
                TXTBFILA.Clear();
                TXTBFILA.Focus();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en las filas y columnas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void BTNCREARM_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTBFILA.Text) || string.IsNullOrWhiteSpace(TXTBCOLUMNA.Text))
                {
                    MessageBox.Show("Por favor, ingrese valores para filas y columnas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int filas = int.Parse(TXTBFILA.Text);
                int columnas = int.Parse(TXTBCOLUMNA.Text);

                if (filas <= 0 || columnas <= 0)
                {
                    MessageBox.Show("El número de filas y columnas debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.AllowUserToAddRows = false; 

                for (int i = 0; i < columnas; i++)
                {
                    dataGridView1.Columns.Add($"Columna{i + 1}", $"Columna {i + 1}");
                }

                for (int i = 0; i < filas; i++)
                {
                    dataGridView1.Rows.Add();
                }

                matriz = new Matriz(filas, columnas);

                MessageBox.Show($"Matriz de {filas}x{columnas} creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en las filas y columnas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                MessageBox.Show("El valor no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                return;
            }

            int valor;
            bool esNumero = int.TryParse(e.FormattedValue.ToString(), out valor);

            if (!esNumero)
            {
                MessageBox.Show("Por favor, ingrese un número válido (positivo o negativo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GPBRESULTADOS.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TXTBCOLUMNA.Clear();
            TXTBFILA.Clear();
            GPBRESULTADOS.Visible=false;
            dataGridView1.Rows.Clear(); 
            dataGridView1.Columns.Clear(); 
        }
    }

}
