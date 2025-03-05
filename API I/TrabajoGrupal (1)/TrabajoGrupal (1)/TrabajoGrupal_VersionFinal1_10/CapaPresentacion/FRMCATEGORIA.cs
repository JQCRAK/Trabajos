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
    public partial class FRMCATEGORIA : Form
    {
        LogicaDatos objLogica = new LogicaDatos();
        Entidades objEntidades = new Entidades();
        public FRMCATEGORIA()
        {
            InitializeComponent();
        }

        private void TXTBNOMBRECATEGORIA_KeyPress(object sender, KeyPressEventArgs e)
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
                    TXTBPRECIO.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la frase: " + ex.Message);
            }


        }

        private void TXTBPRECIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
                else if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
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

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidades.categE = TXTBNOMBRECATEGORIA.Text;

                List<string> categoriaExistentes = objLogica.ObtenerCategorias();

                if (categoriaExistentes.Contains(objEntidades.categE))
                {
                    MessageBox.Show("El nombre de la categoria ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK);
                    TXTBNOMBRECATEGORIA.Clear();
                    TXTBPRECIO.Clear();
                    TXTBNOMBRECATEGORIA.Focus();
                    return;
                }

                string precioTexto = TXTBPRECIO.Text.Replace(',', '.');

                objEntidades.precioE = decimal.Parse(precioTexto, System.Globalization.CultureInfo.InvariantCulture);

                objLogica.IngresarCategoria(objEntidades);

                MessageBox.Show("Datos Ingresados");
                TXTBNOMBRECATEGORIA.Clear();
                TXTBPRECIO.Clear();
                TXTBNOMBRECATEGORIA.Focus();
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

        private void FRMCATEGORIA_Load(object sender, EventArgs e)
        {

        }
    }
}
