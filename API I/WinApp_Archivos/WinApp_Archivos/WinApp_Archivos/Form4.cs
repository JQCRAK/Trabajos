using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Archivos
{
    public partial class Form4 : Form
    {
        public Form4(System.Data.DataRow[] vectorAux)
        {
            
            InitializeComponent();
            lblResNombre.Text = vectorAux[0]["Codigo"].ToString();
            lblResNombre.Text = vectorAux[0]["Nombre"].ToString();
            lblResEdad.Text = vectorAux[0]["Edad"].ToString();
            lblResTlfn.Text = vectorAux[0]["Telefono"].ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
