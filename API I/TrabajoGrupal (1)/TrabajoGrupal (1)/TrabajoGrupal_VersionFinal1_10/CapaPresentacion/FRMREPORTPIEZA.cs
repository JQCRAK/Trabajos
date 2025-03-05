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
    public partial class FRMREPORTPIEZA : Form
    {
        public FRMREPORTPIEZA()
        {
            InitializeComponent();
        }

        private void FRMREPORTPIEZA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter.Fill(this.ejercicio5DataSet.pieza);

            this.reportViewer1.RefreshReport();
        }
    }
}
