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
    public partial class FRMREPORTE1 : Form
    {
        public FRMREPORTE1()
        {
            InitializeComponent();
        }

        private void FRMREPORTE1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet1.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.ejercicio5DataSet1.prov);

            this.reportViewer1.RefreshReport();
        }
    }
}
