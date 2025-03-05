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
    public partial class FRMELIMINAR2 : Form
    {
        string nombreProveedor; 
        LogicaDatos logicaDatos = new LogicaDatos();
        public FRMELIMINAR2(string nombre)
        {
            InitializeComponent();
            nombreProveedor = nombre;
            CargarDatosProveedor();
        }

        private void CargarDatosProveedor()
        {
            // Buscar información del proveedor
            Entidades proveedor = logicaDatos.ObtenerProveedor(nombreProveedor);

            if (proveedor != null)
            {
                lblNombre.Text = proveedor.nombreE;
                lblDireccion.Text = proveedor.direccionE;
                lblCiudad.Text = proveedor.ciudadE;
                lblProvincia.Text = proveedor.provinciaE;
            }
            else
            {
                MessageBox.Show("El proveedor no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                logicaDatos.EliminarProveedor(nombreProveedor);

                MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
