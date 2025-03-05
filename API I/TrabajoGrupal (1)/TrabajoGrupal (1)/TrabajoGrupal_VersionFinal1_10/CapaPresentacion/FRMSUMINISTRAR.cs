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
    public partial class FRMSUMINISTRAR : Form
    {
        LogicaDatos objLogica = new LogicaDatos();
        Entidades objEntidades = new Entidades();
        public FRMSUMINISTRAR()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {

                List<string> Provedores = objLogica.ObtenerProvedor();
                List<string> Piezas = objLogica.ObtenerPieza();

                if (Provedores.Count > 0 && Piezas.Count>0)
                {
                    comboBox1.DataSource = Provedores;
                    comboBox2.DataSource = Piezas;
                }
                else
                {
                    MessageBox.Show("No se encontraron categorías en la base de datos.", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una categoría antes de continuar.", "Advertencia", MessageBoxButtons.OK);
                        comboBox2.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Categoría seleccionada: " + comboBox1.SelectedItem.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la entrada: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (comboBox2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una categoría antes de continuar.", "Advertencia", MessageBoxButtons.OK);
                        TXTBCANTIDAD.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Categoría seleccionada: " + comboBox1.SelectedItem.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la entrada: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void TXTBCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
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
                    BTNGUARDAR.Focus(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidades.nombreE = comboBox1.Text;
                objEntidades.nombrePE = comboBox2.Text;
                objEntidades.cantidadE = int.Parse(TXTBCANTIDAD.Text);
                objLogica.IngresarSuministro(objEntidades);
                MessageBox.Show("Datos Ingresados");
                TXTBCANTIDAD.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la pieza: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void FRMSUMINISTRAR_Load(object sender, EventArgs e)
        {

        }
    }
}
