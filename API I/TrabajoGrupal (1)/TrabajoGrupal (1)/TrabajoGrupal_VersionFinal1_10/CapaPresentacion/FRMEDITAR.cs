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
    public partial class FRMEDITAR : Form
    {
        LogicaDatos objLogica = new LogicaDatos();
        Entidades proveedor;
        public FRMEDITAR(Entidades proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
        }

        private void FRMEDITAR_Load(object sender, EventArgs e)
        {
            if (proveedor != null)
            {
                lblNombreProv.Text = proveedor.nombreE;
                txtDireccion.Text = proveedor.direccionE;
                txtCiudad.Text = proveedor.ciudadE;
                txtProvincia.Text = proveedor.provinciaE;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtCiudad.Focus();
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtProvincia.Focus();
            }
        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BTNGUARDAR.Focus();
            }
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (proveedor != null)
            {
                proveedor.direccionE = txtDireccion.Text.Trim();
                proveedor.ciudadE = txtCiudad.Text.Trim();
                proveedor.provinciaE = txtProvincia.Text.Trim();

                objLogica.ModificarProveedor(proveedor);
                MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
