using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;


namespace CapaPresentacion
{
    public partial class FRMPROVEDOR : Form
    {
        LogicaDatos objLogica = new LogicaDatos();
        Entidades objEntidades = new Entidades();
        public FRMPROVEDOR()
        {
            InitializeComponent();
        }

        private void TXTBNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    TXTBDIRECCION.Focus();
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

        private void TXTBDIRECCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
                if (e.KeyChar == (char)Keys.Enter) 
                {
                    e.Handled = true; 
                    TXTBCIUDAD.Focus(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }

        }

        private void TXTBCIUDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    TXTBPROVINCIA.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTBPROVINCIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
                objEntidades.nombreE = TXTBNOMBRE.Text;

                List<string> provedorExistentes = objLogica.ObtenerProvedor();

                if (provedorExistentes.Contains(objEntidades.nombreE))
                {
                    MessageBox.Show("El nombre del provedor ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK);
                    TXTBNOMBRE.Clear();
                    TXTBDIRECCION.Clear();
                    TXTBCIUDAD.Clear();
                    TXTBPROVINCIA.Clear();
                    TXTBNOMBRE.Focus();
                    return;
                }

                objEntidades.nombreE = TXTBNOMBRE.Text;
                objEntidades.direccionE = TXTBDIRECCION.Text;
                objEntidades.ciudadE = TXTBCIUDAD.Text;
                objEntidades.provinciaE = TXTBPROVINCIA.Text;
                objLogica.InsertarProv(objEntidades);
                MessageBox.Show("Datos Ingresados");
                TXTBNOMBRE.Clear();
                TXTBDIRECCION.Clear();
                TXTBCIUDAD.Clear();
                TXTBPROVINCIA.Clear();
                TXTBNOMBRE.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la pieza: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        private void FRMPROVEDOR_Load(object sender, EventArgs e)
        {

        }
    }
}
