using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml("C:\\Users\\Jostin\\Documents\\QUINTO\\API I\\WinApp_Archivos\\WinApp_Archivos\\ArchivoE.xml");
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            dataSet1.ReadXml("C:\\Users\\Jostin\\Documents\\QUINTO\\API I\\WinApp_Archivos\\WinApp_Archivos\\ArchivoE.xml");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
