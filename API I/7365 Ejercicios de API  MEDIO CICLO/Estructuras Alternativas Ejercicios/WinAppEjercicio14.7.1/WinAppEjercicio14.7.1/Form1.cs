using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio14._7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNPANES_Click(object sender, EventArgs e)
        {
            PNPANES.Visible = true;
            PNDULCES.Visible = false;
            PNLACTEOS.Visible = false;
            PNBEBIDAS.Visible = false;
            PNOTRO.Visible = false;

            ResetButtonColors();

            BTNPANES.BackColor = Color.Gainsboro;
        }

        private void BTNDULCES_Click(object sender, EventArgs e)
        {
            PNPANES.Visible = false;
            PNDULCES.Visible = true;
            PNLACTEOS.Visible = false;
            PNBEBIDAS.Visible = false;
            PNOTRO.Visible = false;

            ResetButtonColors();

            BTNDULCES.BackColor = Color.Gainsboro;
        }

        private void BTNLACTEOS_Click(object sender, EventArgs e)
        {
            PNPANES.Visible = false;
            PNDULCES.Visible = false;
            PNLACTEOS.Visible = true;
            PNBEBIDAS.Visible = false;
            PNOTRO.Visible = false;

            ResetButtonColors();

            BTNLACTEOS.BackColor = Color.Gainsboro;
        }

        private void BTNBEBIDAS_Click(object sender, EventArgs e)
        {
            PNPANES.Visible = false;
            PNDULCES.Visible = false;
            PNLACTEOS.Visible = false;
            PNBEBIDAS.Visible = true;
            PNOTRO.Visible = false;

            ResetButtonColors();

            BTNBEBIDAS.BackColor = Color.Gainsboro;
        }

        private void BTNOTRO_Click(object sender, EventArgs e)
        {
            PNPANES.Visible = false;
            PNDULCES.Visible = false;
            PNLACTEOS.Visible = false;
            PNBEBIDAS.Visible = false;
            PNOTRO.Visible = true;

            ResetButtonColors();

            BTNOTRO.BackColor = Color.Gainsboro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PNPANES.Visible = true;
            PNDULCES.Visible = false;
            PNLACTEOS.Visible = false;
            PNBEBIDAS.Visible = false;
            PNOTRO.Visible = false;

            ResetButtonColors();

            BTNPANES.BackColor = Color.Gainsboro;
        }

        private void ResetButtonColors()
        {
            BTNPANES.BackColor = SystemColors.Control;
            BTNDULCES.BackColor = SystemColors.Control;
            BTNLACTEOS.BackColor = SystemColors.Control;
            BTNBEBIDAS.BackColor = SystemColors.Control;
            BTNOTRO.BackColor = SystemColors.Control;
        }


        private void BTNPANSAL_Click(object sender, EventArgs e)
        {
            string producto = "Pan Sal"; 
            decimal precioUnitario = 0.15m;
            int cantidad = 1; 

            decimal total = precioUnitario * cantidad; 

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad; 

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            } 

            ActualizarTotales();
        }



        private void ActualizarTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalC"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["TotalC"].Value);
                }
            }

            Calculos calculos = new Calculos(0, 0, subtotal);

            decimal iva = calculos.CIva();
            decimal total = calculos.Ctotal();

            LBLRESULSUBTOTAL.Text = $"${subtotal:F2}";
            LBLRESULIVA.Text = $"${iva:F2}";
            LBLRESULTOTAL.Text = $"${total:F2}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "AumentarC")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int cantidad = Convert.ToInt32(row.Cells["CantidadC"].Value);

                cantidad++;

                row.Cells["CantidadC"].Value = cantidad;

                decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioC"].Value);
                row.Cells["TotalC"].Value = cantidad * precioUnitario;
            }
            else if (columnName == "DisminuirC")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int cantidad = Convert.ToInt32(row.Cells["CantidadC"].Value);

                if (cantidad > 1)
                {
                    cantidad--;
                    row.Cells["CantidadC"].Value = cantidad;

                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioC"].Value);
                    row.Cells["TotalC"].Value = cantidad * precioUnitario;
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }

            ActualizarTotales();
        }

        private void BTNPANDULCE_Click(object sender, EventArgs e)
        {
            string producto = "Pan Dulce";
            decimal precioUnitario = 0.20m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNPANINTEGRAL_Click(object sender, EventArgs e)
        {
            string producto = "Pan Integral";
            decimal precioUnitario = 0.25m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNPANEMPANADAS_Click(object sender, EventArgs e)
        {
            string producto = "Pan Empanadas";
            decimal precioUnitario = 0.20m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNPANPALANQUETA_Click(object sender, EventArgs e)
        {
            string producto = "Pan Palanqueta";
            decimal precioUnitario = 0.30m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNPANFRANCES_Click(object sender, EventArgs e)
        {
            string producto = "Pan Frances";
            decimal precioUnitario = 0.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNPANENROLLADO_Click(object sender, EventArgs e)
        {
            string producto = "Pan Enrollado";
            decimal precioUnitario = 0.25m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNPANCACHITO_Click(object sender, EventArgs e)
        {
            string producto = "Pan Cachito";
            decimal precioUnitario = 0.20m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNEMBUTIDOS_Click(object sender, EventArgs e)
        {
            string producto = "Embutidos";
            decimal precioUnitario = 2.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNSNACKS_Click(object sender, EventArgs e)
        {
            string producto = "Snacks";
            decimal precioUnitario = 1.00m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNHELADOS_Click(object sender, EventArgs e)
        {
            string producto = "Helados";
            decimal precioUnitario = 0.75m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNHARINA_Click(object sender, EventArgs e)
        {
            string producto = "Harina";
            decimal precioUnitario = 0.75m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNLEVADURAS_Click(object sender, EventArgs e)
        {
            string producto = "Levadura";
            decimal precioUnitario = 1.00m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNAZUCAR_Click(object sender, EventArgs e)
        {
            string producto = "Azúcar";
            decimal precioUnitario = 2.00m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNLECHETONI_Click(object sender, EventArgs e)
        {
            string producto = "Leche Toni";
            decimal precioUnitario = 0.95m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNYOGURTTONI_Click(object sender, EventArgs e)
        {
            string producto = "Yogurt Toni";
            decimal precioUnitario = 1.25m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNQUESOFRESCO_Click(object sender, EventArgs e)
        {
            string producto = "Queso Fresco";
            decimal precioUnitario = 2.25m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNMANTEQUILLA_Click(object sender, EventArgs e)
        {
            string producto = "Mantequilla";
            decimal precioUnitario = 0.75m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNMANJARDELECHE_Click(object sender, EventArgs e)
        {
            string producto = "Manjar de Leche";
            decimal precioUnitario = 1.00m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNMONCAYBA_Click(object sender, EventArgs e)
        {
            string producto = "Moncayba";
            decimal precioUnitario = 0.35m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNOREJAS_Click(object sender, EventArgs e)
        {
            string producto = "Orejas de Dulce";
            decimal precioUnitario = 0.20m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNEMPANDASDEVIENTO_Click(object sender, EventArgs e)
        {
            string producto = "Empanadas de Viento";
            decimal precioUnitario = 0.25m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNBIZCOCHO_Click(object sender, EventArgs e)
        {
            string producto = "Bizcochos";
            decimal precioUnitario = 0.10m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNDONAS_Click(object sender, EventArgs e)
        {
            string producto = "Donas";
            decimal precioUnitario = 0.30m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNCONCHAS_Click(object sender, EventArgs e)
        {
            string producto = "Conchas";
            decimal precioUnitario = 0.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNTORTACHO_Click(object sender, EventArgs e)
        {
            string producto = "Torta Chocolate";
            decimal precioUnitario = 3.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNTORTAFRUTA_Click(object sender, EventArgs e)
        {
            string producto = "Torta de Frutas";
            decimal precioUnitario = 5.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNCAFE_Click(object sender, EventArgs e)
        {
            string producto = "Cafe";
            decimal precioUnitario = 0.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNCHOCOLATEC_Click(object sender, EventArgs e)
        {
            string producto = "Chocolate Caliente";
            decimal precioUnitario = 1.00m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNAGUAEMB_Click(object sender, EventArgs e)
        {
            string producto = "Agua Embotellada";
            decimal precioUnitario = 0.50m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNJUGOSN_Click(object sender, EventArgs e)
        {
            string producto = "Jugos Naturales";
            decimal precioUnitario = 0.75m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNBEBIDASE_Click(object sender, EventArgs e)
        {
            string producto = "Bebidas Energeticas";
            decimal precioUnitario = 1.00m;
            int cantidad = 1;

            decimal total = precioUnitario * cantidad;

            bool existe = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoC"].Value?.ToString() == producto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadC"].Value);
                    cantidadActual += cantidad;

                    row.Cells["CantidadC"].Value = cantidadActual;
                    row.Cells["TotalC"].Value = cantidadActual * precioUnitario;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                dataGridView1.Rows.Add(producto, precioUnitario, cantidad, total);
            }

            ActualizarTotales();
        }

        private void BTNCOMPRAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                bool carritoVacio = true;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ProductoC"].Value != null && row.Cells["ProductoC"].Value.ToString() != "")
                    {
                        carritoVacio = false;
                        break;  
                    }
                }

                if (carritoVacio)
                {
                    MessageBox.Show("Tu carrito está vacío. No hay productos para comprar.", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tu orden se está procesando. ¡Gracias por preferirnos!", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.Rows.Clear();
                    LBLRESULSUBTOTAL.Text = "$0.00";
                    LBLRESULIVA.Text = "$0.00";
                    LBLRESULTOTAL.Text = "$0.00";
                }
            }
            else
            {
                MessageBox.Show("Tu carrito está vacío. No hay productos para comprar.", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PCBRESET_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            LBLRESULSUBTOTAL.Text = "$0.00";
            LBLRESULIVA.Text = "$0.00";
            LBLRESULTOTAL.Text = "$0.00";
        }
    }
}
