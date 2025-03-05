using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        LogicaDatos logicaDatos = new LogicaDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMPROVEDOR objProvedor = new FRMPROVEDOR();
            objProvedor.ShowDialog();
        }

        private void piezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMPIEZA objPieza = new FRMPIEZA();
            objPieza.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCATEGORIA objCategoria = new FRMCATEGORIA();
            objCategoria.ShowDialog();
        }

        private void suministroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMSUMINISTRAR OBJSUMINITRAR = new FRMSUMINISTRAR();
            OBJSUMINITRAR.ShowDialog();
        }

        private void piezaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscar objbuscarP = new frmBuscar();
            objbuscarP.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMREPORTE1 OBJREPORTE1 = new FRMREPORTE1();   
            OBJREPORTE1.ShowDialog();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMREPORTE2 OBJREPORTE2 = new FRMREPORTE2();
            OBJREPORTE2.ShowDialog();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMREPORTPIEZA OBJPIEZA = new FRMREPORTPIEZA();
            OBJPIEZA.ShowDialog();
        }

        private void reporte4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMREPORTSUMINSITRO OBJREPORTSUMINISTRO = new FRMREPORTSUMINSITRO();
            OBJREPORTSUMINISTRO.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMELIMINAR OBJELIMINAR = new FRMELIMINAR();
            OBJELIMINAR.ShowDialog();
        }

        private void reporte5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMREPORTERESUMENCATEGORIA OBJPCATEGORIA = new FRMREPORTERESUMENCATEGORIA();
            OBJPCATEGORIA.ShowDialog();
        }

        private void reporte6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMREPORTRESUMENPROVEDORES OBJPROVDEOR = new FRMREPORTRESUMENPROVEDORES();
            OBJPROVDEOR.ShowDialog();
        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMBUSCAREDITAR OBJBUSCAREDITAR = new FRMBUSCAREDITAR();
            OBJBUSCAREDITAR.ShowDialog();
        }

        private void TXTBNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // Bloquea el carácter si no es una letra o la tecla de retroceso
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    BTNCONOCER.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BTNCONOCER_Click(object sender, EventArgs e)
        {
            string nombreProveedor = TXTBNOMBRE.Text.Trim();

            if (string.IsNullOrEmpty(nombreProveedor))
            {
                MessageBox.Show("Por favor, ingrese el nombre del proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable datosProveedorYPiezas = logicaDatos.ObtenerProveedorYPiezas(nombreProveedor);

            if (datosProveedorYPiezas != null && datosProveedorYPiezas.Rows.Count > 0)
            {
                dataGridView1.DataSource = datosProveedorYPiezas;
            }
            else
            {
                MessageBox.Show("No se encontró información para el proveedor ingresado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
