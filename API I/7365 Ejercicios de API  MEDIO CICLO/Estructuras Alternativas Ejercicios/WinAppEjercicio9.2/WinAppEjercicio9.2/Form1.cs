using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio9._2
{
    public partial class Form1 : Form
    {
        string dato1, dato2, dato3;
        public Form1()
        {
            InitializeComponent();
        }

        private void CMBGENEROP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNOBTENERR_Click(object sender, EventArgs e)
        {
            bool validado = true;

            if (string.IsNullOrWhiteSpace(TXTBEDAD.Text) || !int.TryParse(TXTBEDAD.Text, out int edad) || edad < 1 || edad > 100)
            {
                MessageBox.Show("Por favor, ingrese una edad válida entre 1 y 100.");
                TXTBEDAD.BackColor = Color.Red;
                TXTBEDAD.Focus();
                validado = false;
            }
            else
            {
                TXTBEDAD.BackColor = Color.White; 
            }

            if (CMBGENEROP.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un género preferido.");
                CMBGENEROP.BackColor = Color.Red;
                CMBGENEROP.Focus();
                validado = false;
            }
            else
            {
                CMBGENEROP.BackColor = Color.White;
            }

            if (!RBTNSERIES.Checked && !RBTNPELICULAS.Checked)
            {
                MessageBox.Show("Por favor, seleccione si prefiere series o películas.");
                GPBPREFERENCIA.ForeColor = Color.Red; 
                validado = false;
            }
            else
            {
                GPBPREFERENCIA.ForeColor = Color.Black;
            }

            if (validado)
            {
            }

            int edade = int.Parse(TXTBEDAD.Text);
            string generoPreferido = CMBGENEROP.SelectedItem?.ToString();
            bool prefiereSeries = RBTNSERIES.Checked;
            bool prefierePeliculas = RBTNPELICULAS.Checked;

            if (!prefiereSeries && !prefierePeliculas)
            {
                MessageBox.Show("Por favor, seleccione si prefiere series o películas.");
                return;
            }

            if (edade < 13 && generoPreferido == "Animación" && prefierePeliculas)
            {
                Listadepeliculasdeanimacion formulario = new Listadepeliculasdeanimacion();
                formulario.Show();
                TXTBEDAD.Clear();
                RBTNSERIES.Checked = false;
                RBTNPELICULAS.Checked = false;

            }
            else if (edade >= 13 && edade <= 18 && generoPreferido == "Ciencia Ficción")
            {
                if (prefiereSeries)
                {
                    Series_CienciaFiccion formulario2 = new Series_CienciaFiccion();
                    formulario2.Show();
                    TXTBEDAD.Clear();
                    RBTNSERIES.Checked = false;
                    RBTNPELICULAS.Checked = false;

                }
                else if (prefierePeliculas)
                {
                    Peliculas_CienciaFiccion formulario1 = new Peliculas_CienciaFiccion();
                    formulario1.Show();
                    TXTBEDAD.Clear();
                    RBTNSERIES.Checked = false;
                    RBTNPELICULAS.Checked = false;
                }
            }
            else if (edade > 18 && generoPreferido == "Drama")
            {
                if (prefiereSeries)
                {
                    Listas_Series_Drama formulario3 = new Listas_Series_Drama();
                    formulario3.Show();
                    TXTBEDAD.Clear();
                    RBTNSERIES.Checked = false;
                    RBTNPELICULAS.Checked = false;
                }
                else if (prefierePeliculas)
                {
                    Peliculas_Drama formulario4 = new Peliculas_Drama();
                    formulario4.Show();
                    TXTBEDAD.Clear();
                    RBTNSERIES.Checked = false;
                    RBTNPELICULAS.Checked = false;
                }
            }
            else
            {
                películasdelmomento formulario5 = new películasdelmomento();
                formulario5.Show();
                TXTBEDAD.Clear();
                RBTNSERIES.Checked = false;
                RBTNPELICULAS.Checked = false;
            }

        }

        private void RBTNSERIES_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTNSERIES.Checked)
            {
                RBTNPELICULAS.Checked = false;
            }
            else
            {
                RBTNPELICULAS.Enabled = true;
            }
        }

        private void RBTNPELICULAS_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTNPELICULAS.Checked)
            {
                RBTNSERIES.Checked = false;
            }
            else
            {
                RBTNSERIES.Enabled = true;
            }
        }

        private void TXTBEDAD_TextChanged(object sender, EventArgs e)
        {
            if (TXTBEDAD.Text.Length > 0)
            {
                try
                {
                    int edad = int.Parse(TXTBEDAD.Text);

                    if (edad < 1 || edad > 100)
                    {
                        MessageBox.Show("Por favor, ingrese una edad válida entre 1 y 100.");
                        TXTBEDAD.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Por favor, ingrese solo números enteros.");
                    TXTBEDAD.Clear();
                }
            }
        }

        private void TXTBEDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dato1 = TXTBEDAD.Text;
                CMBGENEROP.Focus();
            }
        }
    }
}
