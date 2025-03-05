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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FRMELIMINAR : Form
    {
        LogicaDatos objLogica = new LogicaDatos();
        Entidades objEntidades = new Entidades();
        public FRMELIMINAR()
        {
            InitializeComponent();

        }
        

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                    btnBuscar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void FRMELIMINAR_Load(object sender, EventArgs e)
        {

        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
           

        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = txtNombreProv.Text.Trim();

            Entidades proveedor = objLogica.ObtenerProveedor(nombreProveedor);

            if (proveedor != null)
            {
                FRMELIMINAR2 frm = new FRMELIMINAR2(nombreProveedor);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
