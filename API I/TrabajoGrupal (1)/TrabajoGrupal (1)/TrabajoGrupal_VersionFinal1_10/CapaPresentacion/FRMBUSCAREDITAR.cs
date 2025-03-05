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
    public partial class FRMBUSCAREDITAR : Form
    {
        LogicaDatos logica = new LogicaDatos();
        public FRMBUSCAREDITAR()
        {
            InitializeComponent();
        }

        private void txtNombreProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = txtNombreProv.Text.Trim();

            if (string.IsNullOrEmpty(nombreProveedor))
            {
                MessageBox.Show("Por favor, ingrese un nombre de proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Entidades proveedor = logica.ObtenerProveedor(nombreProveedor);

            if (proveedor != null)
            {
                FRMEDITAR frm = new FRMEDITAR(proveedor);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("El proveedor no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FRMBUSCAREDITAR_Load(object sender, EventArgs e)
        {

        }
    }
}
