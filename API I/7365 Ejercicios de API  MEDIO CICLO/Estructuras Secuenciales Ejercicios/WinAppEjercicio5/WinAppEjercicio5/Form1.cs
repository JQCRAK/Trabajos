using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio5
{
    public partial class Form1 : Form
    {
        string dato1,dato2;
        public Form1()
        {
            InitializeComponent();
        }
        private void BTNCONVERTIR_Click(object sender, EventArgs e)
        {

            string ValorSegundo = TXTBINGRESARS.Text;
            int ValorSegundo2 = int.Parse(ValorSegundo);
            ConvertirSegundos ObjHM = new ConvertirSegundos(ValorSegundo2);
            LBLRESUL.Text = ObjHM.Convertir().ToString();
            pictureBox2.Focus();
            TXTBINGRESARS.Focus();
            TXTBINGRESARS.Clear();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TXTBINGRESARS.Text = string.Empty; 
            LBLRESUL.Text = "00:00:00";
            TXTBINGRESARS.Focus();
        }

        private void TXTBINGRESARS_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    TXTBINGRESARS.Clear(); 
                    MessageBox.Show("Solo se permiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    try
                    {
                        if (int.TryParse(TXTBINGRESARS.Text, out _))
                        {
                            dato1 = TXTBINGRESARS.Text;
                            BTNCONVERTIR.Focus();
                        }
                        else
                        {
                            TXTBINGRESARS.Clear();
                            MessageBox.Show("Ingrese un número entero válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        TXTBINGRESARS.Clear();
                        MessageBox.Show("Error al procesar el número: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                TXTBINGRESARS.Clear();
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
