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
    public partial class FRMREPORTSUMINSITRO : Form
    {
        public FRMREPORTSUMINSITRO()
        {
            InitializeComponent();
        }

        private void FRMREPORTSUMINSITRO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet1.suministra' Puede moverla o quitarla según sea necesario.
            this.suministraTableAdapter1.Fill(this.ejercicio5DataSet1.suministra);
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet1.total_por_categoria' Puede moverla o quitarla según sea necesario.
            this.total_por_categoriaTableAdapter.Fill(this.ejercicio5DataSet1.total_por_categoria);
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet.suministra' Puede moverla o quitarla según sea necesario.
            this.suministraTableAdapter.Fill(this.ejercicio5DataSet.suministra);

            this.reportViewer1.RefreshReport();
        }
    }
}
