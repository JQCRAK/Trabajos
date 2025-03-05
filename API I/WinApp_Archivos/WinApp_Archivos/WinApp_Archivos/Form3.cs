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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml("C:\\Users\\angel\\OneDrive\\Documents\\5 Semestre\\Aplicaciones\\WinApp\\WinApp_Archivos\\ArchivoE.xml");
            System.Data.DataRow[] vector;

            vector = dataSet11.tblDatos.Select("Codigo = '"+txtCodigo+"'");
            if(vector.Length > 0)
            {
                Form4 f4 = new Form4(vector);
                f4.ShowDialog();
            }
            else
            {
                MessageBox.Show("EL ESTUDIANTE NO SE ENCONTRÓ!!!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
