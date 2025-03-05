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
    public partial class FRMPIEZA : Form
    {
        LogicaDatos objLogica = new LogicaDatos();
        Entidades objEntidades = new Entidades();
        public FRMPIEZA()
        {
            InitializeComponent();
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            try
            {

                List<string> categorias = objLogica.ObtenerCategorias();

                if (categorias.Count > 0)
                {
                    CMBCATEGORIA.DataSource = categorias;
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

        private void PCBCOLOR_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = Color.Black;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    PCBCOLOR.BackColor = colorDialog.Color;

                    LBLCOLOR.Text = colorDialog.Color.Name;
                    TXTBCENTRO.Focus();
                }
            }

        }

        private void TXTBNOMBREPIEZA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    PCBCOLOR.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la frase: " + ex.Message);
            }

        }

        private void TXTBCENTRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    CMBCATEGORIA.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la frase: " + ex.Message);
            }

        }

        

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidades.nombrePE = TXTBNOMBREPIEZA.Text;

                List<string> piezasExistentes = objLogica.ObtenerPieza();

                if (piezasExistentes.Contains(objEntidades.nombrePE))
                {
                    MessageBox.Show("El nombre de la pieza ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK);
                    TXTBNOMBREPIEZA.Clear();
                    LBLCOLOR.Text = " ";
                    TXTBCENTRO.Clear();
                    TXTBNOMBREPIEZA.Focus();
                    return; 
                }

                objEntidades.colorE = LBLCOLOR.Text;
                objEntidades.centroE = TXTBCENTRO.Text;
                objEntidades.categE = CMBCATEGORIA.Text;

                // Proceder a guardar los datos
                objLogica.InsertarPieza(objEntidades);
                MessageBox.Show("Datos Ingresados");
                TXTBNOMBREPIEZA.Clear();
                LBLCOLOR.Text = " ";
                TXTBCENTRO.Clear();
                TXTBNOMBREPIEZA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la pieza: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CMBCATEGORIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (CMBCATEGORIA.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una categoría antes de continuar.", "Advertencia", MessageBoxButtons.OK);
                        CMBCATEGORIA.Focus(); 
                    }
                    else
                    {
                        MessageBox.Show("Categoría seleccionada: " + CMBCATEGORIA.SelectedItem.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la entrada: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void FRMPIEZA_Load(object sender, EventArgs e)
        {

        }
    }
}
