using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsAppPractica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnsubArcSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CBXCURSOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBXCURSOR.SelectedIndex)
            {
                case 0:
                    Cursor = Cursors.Cross;
                    break;

                case 1:
                    Cursor = Cursors.Arrow;
                    break;

                case 2:
                    Cursor = Cursors.Help;
                    break;

                default:
                    Cursor = Cursors.Default;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNBEEP_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void BTNASTERIS_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void BTNEXCLAMACION_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();    
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FRMFELIZ ObjFRMFELIZ = new FRMFELIZ();
            ObjFRMFELIZ.ShowDialog();
        }

        private void BTNVENTANA_Click(object sender, EventArgs e)
        {
            Form2 ObjForm2 = new Form2();
            ObjForm2.ShowDialog();
        }

        private void pROYECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsAppCalcularnumcifras.Form1 ObjPractica = new WindowsAppCalcularnumcifras.Form1();
            ObjPractica.ShowDialog();
        }
    }
}
