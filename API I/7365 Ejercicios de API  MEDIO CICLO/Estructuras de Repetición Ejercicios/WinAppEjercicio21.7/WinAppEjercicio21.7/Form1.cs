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


namespace WinAppEjercicio21._7
{
    public partial class Form1 : Form
    {
        double[,] Matri_Ent = new double[4, 3];
        int f = 0; 
        int c = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV.ColumnCount = 4; 
            DGV.Columns[0].Name = "Producto";
            DGV.Columns[1].Name = "Enero";
            DGV.Columns[2].Name = "Febrero";
            DGV.Columns[3].Name = "Marzo";

            DGV.Rows.Add("Smartphone");
            DGV.Rows.Add("Laptop");
            DGV.Rows.Add("Tablet");
            DGV.Rows.Add("Smartwatch");

            DGV2.ColumnCount = 2;
            DGV2.Columns[0].Name = "Producto";
            DGV2.Columns[1].Name = "Total Ventas";

            DGV3.ColumnCount = 2;
            DGV3.Columns[0].Name = "Mes";
            DGV3.Columns[1].Name = "Total Ventas";

            foreach (DataGridViewRow row in DGV.Rows)
            {
                row.Cells[0].ReadOnly = true; 
            }
            DGV.ReadOnly = true; 

            DGV.SelectionMode = DataGridViewSelectionMode.CellSelect; 
            DGV.ClearSelection(); 

            TXTBA.Focus();
            MessageBox.Show("Ingrese la venta para Smartphone, Enero:");
            LBLMOTRAR.Visible = false;
            DGV.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

        }

        private void TXTBA_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] productos = { "Smartphone", "Laptop", "Tablet", "Smartwatch" };
            string[] meses = { "Enero", "Febrero", "Marzo" };

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = double.Parse(TXTBA.Text, CultureInfo.InvariantCulture);

                    Matri_Ent[f, c] = valor;
                    DGV.Rows[f].Cells[c + 1].Value = valor.ToString("F2"); 

                    TXTBA.Clear();

                    c++;
                    if (c == 3) 
                    {
                        f++;
                        c = 0; 
                    }

                    if (f == 4 && c == 0)
                    {
                        TXTBA.Enabled = false; 
                        MessageBox.Show("Ingreso completo de la matriz.");

                        VentasTotales vt = new VentasTotales(Matri_Ent);

                        double[] totalesPorProducto = vt.CalcularTotalesPorProducto();
                        double[] totalesPorMes = vt.CalcularTotalesPorMes();

                        for (int i = 0; i < 4; i++)
                        {
                            DGV2.Rows.Add(productos[i], totalesPorProducto[i].ToString("F2"));
                        }

                        for (int j = 0; j < 3; j++)
                        {
                            DGV3.Rows.Add(meses[j], totalesPorMes[j].ToString("F2"));
                        }
                        LBLMOTRAR.Visible = true;
                        DGV.Visible = true;
                        groupBox1.Visible = true;
                        groupBox2.Visible = true;
                        TXTBA.Clear();
                        TXTBA.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Ingrese la venta para {productos[f]}, {meses[c]}:");
                        TXTBA.Focus(); 
                    }
                }
                catch
                {
                    MessageBox.Show("Por favor, ingrese un número válido (puede ser decimal).");
                    TXTBA.Clear();
                    TXTBA.Focus();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Matri_Ent = new double[4, 3];
            f = 0;
            c = 0;

            DGV.Rows.Clear();
            DGV2.Rows.Clear();
            DGV3.Rows.Clear();

            DGV.Rows.Add("Smartphone");
            DGV.Rows.Add("Laptop");
            DGV.Rows.Add("Tablet");
            DGV.Rows.Add("Smartwatch");

            foreach (DataGridViewRow row in DGV.Rows)
            {
                row.Cells[0].ReadOnly = true;
            }

            LBLMOTRAR.Visible = false;
            DGV.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            TXTBA.Clear();
            TXTBA.Enabled = true;
            TXTBA.Focus();

            MessageBox.Show("Ingrese la venta para Smartphone, Enero:");
        }
    }
}
