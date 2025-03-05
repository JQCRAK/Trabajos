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
    public partial class FRMREPORTRESUMENPROVEDORES : Form
    {
        public FRMREPORTRESUMENPROVEDORES()
        {
            InitializeComponent();
        }

        private void FRMREPORTRESUMENPROVEDORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet1.total_suministros_proveedor' Puede moverla o quitarla según sea necesario.
            this.total_suministros_proveedorTableAdapter.Fill(this.ejercicio5DataSet1.total_suministros_proveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
