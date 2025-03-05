using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windoappPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            string ValorBase = textBase.Text;
            string ValorAltura = textAltura.Text;
            int ValorBaseE = int.Parse(ValorBase);
            int ValorAlturaE = int.Parse(ValorAltura);
            // declaración del objeto
            Class1 ObjTriangulo = new Class1(ValorBaseE, ValorAlturaE);
            Resultado.Text = ObjTriangulo.AreaTrian().ToString();
        }
    }
}
