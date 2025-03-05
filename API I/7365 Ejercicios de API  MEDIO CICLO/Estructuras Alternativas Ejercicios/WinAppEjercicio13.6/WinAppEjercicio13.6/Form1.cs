using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio13._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTB1.Text) && e.KeyChar == (char)Keys.Enter)
                {
                    MessageBox.Show("El campo 1 debe estar lleno.");
                    e.Handled = true;
                    return;
                }

                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(TXTB1.Text))
                {
                    e.Handled = true;
                    TXTB2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTB2.Text) && e.KeyChar == (char)Keys.Enter)
                {
                    MessageBox.Show("El campo 2 debe estar lleno.");
                    e.Handled = true;
                    return;
                }

                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(TXTB2.Text))
                {
                    e.Handled = true;
                    TXTB3.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTB3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTB3.Text) && e.KeyChar == (char)Keys.Enter)
                {
                    MessageBox.Show("El campo 3 debe estar lleno.");
                    e.Handled = true;
                    return;
                }

                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(TXTB3.Text))
                {
                    e.Handled = true;
                    TXTB4.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTB4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTB4.Text) && e.KeyChar == (char)Keys.Enter)
                {
                    MessageBox.Show("El campo 4 debe estar lleno.");
                    e.Handled = true;
                    return;
                }

                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(TXTB4.Text))
                {
                    e.Handled = true;
                    BTNINICIAR.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BTNINICIAR_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TXTB1.Text) || string.IsNullOrWhiteSpace(TXTB2.Text) ||
                string.IsNullOrWhiteSpace(TXTB3.Text) || string.IsNullOrWhiteSpace(TXTB4.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                return;
            }
            
            Ruleta ruleta = new Ruleta
            {
                Usuario1 = TXTB1.Text,
                Usuario2 = TXTB2.Text,
                Usuario3 = TXTB3.Text,
                Usuario4 = TXTB4.Text
            };

            ruleta.Show();
            TXTB1.Clear();
            TXTB2.Clear();
            TXTB3.Clear();
            TXTB4.Clear();

        }

        private void BTNINICIAR_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TXTB1.Text) || string.IsNullOrWhiteSpace(TXTB2.Text) ||
                string.IsNullOrWhiteSpace(TXTB3.Text) || string.IsNullOrWhiteSpace(TXTB4.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
                e.Handled = true;
                return;
            }

            Ruleta ruleta = new Ruleta
            {
                Usuario1 = TXTB1.Text,
                Usuario2 = TXTB2.Text,
                Usuario3 = TXTB3.Text,
                Usuario4 = TXTB4.Text
            };

            ruleta.Show();
            TXTB1.Clear();
            TXTB2.Clear();
            TXTB3.Clear();
            TXTB4.Clear();
        }
    }
}
