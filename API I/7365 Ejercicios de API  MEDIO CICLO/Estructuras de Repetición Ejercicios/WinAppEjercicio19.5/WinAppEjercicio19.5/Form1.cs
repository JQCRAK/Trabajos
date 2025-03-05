using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio19._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(TXTBN.Text)) 
                {
                    MessageBox.Show("Debe ingresar un número antes de continuar.", "Advertencia", MessageBoxButtons.OK);
                    e.SuppressKeyPress = true; 
                    return;
                }

                CrearMatriz(); 
                e.SuppressKeyPress = true; 
            }
        }

        private void CrearMatriz()
        {
            TXTBN.Enabled = false;
            TXTBN.ReadOnly = true;
            if (!int.TryParse(TXTBN.Text, out int tamaño) || tamaño <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.", "Advertencia", MessageBoxButtons.OK);
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.AllowUserToAddRows = false;  

            // Crear columnas
            for (int i = 0; i < tamaño; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = $"Col{i}";
                column.HeaderText = $"Col {i + 1}";
                dataGridView1.Columns.Add(column);
            }

            // Crear filas
            for (int i = 0; i < tamaño; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                dataGridView1.Rows.Add(row);
                row.HeaderCell.Value = $"Fila {i + 1}";
            }

            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

            MessageBox.Show($"Matriz de {tamaño}x{tamaño} creada. Por favor, ingrese los valores.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                GPBRESULTADOS.Visible = true;
                if (dataGridView1.Rows.Count == 0 || dataGridView1.Columns.Count == 0)
                {
                    MessageBox.Show("Primero debe crear la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int tamaño = dataGridView1.Rows.Count;
                Matriz matriz = new Matriz(tamaño);
                bool hayError = false;

                for (int i = 0; i < tamaño && !hayError; i++)
                {
                    for (int j = 0; j < tamaño && !hayError; j++)
                    {
                        var celda = dataGridView1.Rows[i].Cells[j];
                        if (celda.Value == null || string.IsNullOrWhiteSpace(celda.Value.ToString()))
                        {
                            MessageBox.Show($"La celda en la fila {i + 1}, columna {j + 1} está vacía.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hayError = true;
                            return;
                        }

                        if (!int.TryParse(celda.Value.ToString(), out int valor))
                        {
                            MessageBox.Show($"El valor en la fila {i + 1}, columna {j + 1} no es un número válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hayError = true;
                            return;
                        }

                        matriz.EstablecerValor(i, j, valor);
                    }
                }

                if (!hayError)
                {
                    LBLMTS.Text = matriz.ObtenerMayorTrianguloSuperior().ToString();
                    LBLMDP.Text = matriz.ObtenerMenorDiagonal().ToString();
                    LBLSTI.Text = matriz.CalcularSumaTrianguloInferior().ToString();
                    
                    TXTBN.Enabled = true;
                    TXTBN.ReadOnly = false;
                    TXTBN.Clear();
                    TXTBN.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
            
            

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                textBox.KeyPress -= DataGridViewTextBox_KeyPress;
                textBox.KeyPress += DataGridViewTextBox_KeyPress;
            }
        }

        private void DataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GPBRESULTADOS.Visible = false;
            TXTBN.Enabled = true;
            TXTBN.ReadOnly = false;
            TXTBN.Clear();
            TXTBN.Focus();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GPBRESULTADOS.Visible = false;
        }
    }
}
