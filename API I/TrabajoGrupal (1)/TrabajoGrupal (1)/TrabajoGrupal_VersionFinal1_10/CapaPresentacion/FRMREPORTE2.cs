﻿using System;
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
    public partial class FRMREPORTE2 : Form
    {
        public FRMREPORTE2()
        {
            InitializeComponent();
        }

        private void FRMREPORTE2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicio5DataSet.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.ejercicio5DataSet.categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
