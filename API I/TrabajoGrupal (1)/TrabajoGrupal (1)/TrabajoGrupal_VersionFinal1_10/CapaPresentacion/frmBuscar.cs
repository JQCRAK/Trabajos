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
    public partial class frmBuscar : Form
    {
        LogicaDatos objLogica = new LogicaDatos();

        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {

        }

        private void txtNombrePieza_KeyPress(object sender, KeyPressEventArgs e)
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
                    btnBuscar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombrePieza = txtNombrePieza.Text.Trim();

            if (!string.IsNullOrEmpty(nombrePieza))
            {

                Entidades pieza = objLogica.ObtenerPiezaPorNombre(nombrePieza);


                listBox1.Items.Clear();

                if (pieza != null)
                {

                    listBox1.Items.Add("Nombre: " + pieza.nombrePE);
                    listBox1.Items.Add("Color: " + pieza.colorE);
                    listBox1.Items.Add("Centro: " + pieza.centroE);
                    listBox1.Items.Add("Categoría: " + pieza.categE);
                }
                else
                {
                    listBox1.Items.Add("Pieza no encontrada.");
                }
            }
        }
    }
}
