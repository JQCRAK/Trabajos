using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppEjercicio20._6
{
    public partial class Form1 : Form
    {
        int[] vec;
        int ValorNE;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBVALORN_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(TXTBVALORN.Text)) 
                    {
                        MessageBox.Show("El campo debe ser llenado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true; 
                    }
                    else
                    {
                        e.Handled = true; 
                        BTNRESTABLECER.Focus();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BTNRESTABLECER_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TXTBVALORN.Text, out ValorNE) && ValorNE > 0)
                {
                    vec = new int[ValorNE];
                    i = 0; 
                    MessageBox.Show("Dimensión del vector establecida: " + ValorNE.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TXTBVALORES.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para la dimensión del vector.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXTBVALORES_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (int.TryParse(TXTBVALORES.Text, out int num))
                    {
                        vec[i] = num;
                        i++;

                        if (i == ValorNE)
                        {
                            MessageBox.Show("Vector Lleno");
                            MNORDENAR.Enabled = true;
                            MNBUSCAR.Enabled = true;
                            TXTBVALORN.Enabled = false;
                            TXTBVALORES.Enabled = false;
                            BTNRESTABLECER.Enabled = false;
                            LBLVECTOR.Visible = true;
                            flowLayoutPanel1.Controls.Clear();

                            for (int j = 0; j < ValorNE; j++)
                            {
                                Label label = new Label();
                                label.Text = $"[{vec[j]}] ";
                                label.AutoSize = true; 
                                flowLayoutPanel1.Controls.Add(label);
                            }
                        }

                        e.Handled = true;
                        TXTBVALORES.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PNORDENAR.Visible = false;
            PNPEDIRN.Visible = true;
            PNBUSCAR.Visible = false;
            MNORDENAR.Enabled = false;
            MNBUSCAR.Enabled = false;
            LBLVECTOR.Visible = false;
            GRPBORDENARAS.Visible = false;
            GRPBORDENARDES.Visible = false;
            GRPBVALORBUSCAR.Visible = false;
            GRPMAXIMO.Visible = false;
            GRPMINIMO.Visible = false;
            LBLRESUL.Text = " ";
            i = 0;
            ValorNE = 0;
            TXTBVALORN.Clear();
            TXTBVALORN.Enabled = true;
            BTNRESTABLECER.Enabled = true;
            TXTBVALORES.Enabled = true;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
        }


        private void MNANADIR_Click(object sender, EventArgs e)
        {
            PNPEDIRN.Visible = true;
            PNORDENAR.Visible = false;
            PNBUSCAR.Visible = false;
            
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            PNORDENAR.Visible = false;
            PNPEDIRN.Visible=true;
            PNBUSCAR.Visible = false;
            MNORDENAR.Enabled = false;
            MNBUSCAR.Enabled = false;
            LBLVECTOR.Visible = false;
            GRPBORDENARAS.Visible = false;
            GRPBORDENARDES.Visible = false;
            GRPBVALORBUSCAR.Visible = false;
            GRPMAXIMO.Visible = false;
            GRPMINIMO.Visible = false;
        }

        private void MNODESCENDENTE_Click(object sender, EventArgs e)
        {
            GRPBORDENARDES.Visible=true ;
            try
            {
                Vector vector = new Vector(vec, i); 
                vector.OrdenarDescendente(); 

                flowLayoutPanel3.Controls.Clear(); 
                int[] valoresOrdenados = vector.ObtenerVector();

                foreach (int valor in valoresOrdenados)
                {
                    Label lbl = new Label
                    {
                        Text = $"[{valor}] ",
                        AutoSize = true 
                    };
                    flowLayoutPanel3.Controls.Add(lbl);
                }

                MessageBox.Show("Vector ordenado descendentemente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MNOASCENDENTE_Click(object sender, EventArgs e)
        {
            GRPBORDENARAS.Visible=true ;
            
            try
            {
                Vector vector = new Vector(vec, i); 
                vector.OrdenarAscendente(); 

                flowLayoutPanel2.Controls.Clear(); 
                int[] valoresOrdenados = vector.ObtenerVector();

                foreach (int valor in valoresOrdenados)
                {
                    Label lbl = new Label
                    {
                        Text = $"[{valor}] ",
                        AutoSize = true 
                    };
                    flowLayoutPanel2.Controls.Add(lbl);
                }

                MessageBox.Show("Vector ordenado ascendentemente.", "Información", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (int.TryParse(textBox1.Text, out int numeroABuscar))
                    {
                        BuscarElemento objBuscador = new BuscarElemento(vec, i);
                        string mensaje = objBuscador.Existe(numeroABuscar);

                        int posicion = objBuscador.ObtenerPosicion(numeroABuscar);
                        LBLRESUL.Text = mensaje;

                        e.Handled = true;
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un número válido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void MNBUSCAR_Click(object sender, EventArgs e)
        {
            PNORDENAR.Visible = false;
            PNPEDIRN.Visible = false;
            PNBUSCAR.Visible = true;
        }

        private void MNBMINIMO_Click(object sender, EventArgs e)
        {
            GRPMINIMO.Visible = true;
            try
            {
                Vector vector = new Vector(vec, i);

                int menor = vector.EncontrarMenor();
                int posicion  = vector.EncontrarPosicionMenor();

                LBLMINIMO.Text = $"El menor es: {menor}";
                LBLPOSMIN.Text = posicion.ToString();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBLMINIMO.Text = "No hay valores";
                LBLPOSMIN.Text = "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MNBMAXIMO_Click(object sender, EventArgs e)
        {
            GRPMAXIMO.Visible = true;
            try
            {
                Vector vector = new Vector(vec, i); 

                int maximo = vector.EncontrarMaximo();
                int posicion = vector.EncontrarPosicionMaximo();

                LBLMAXIMO.Text = $"El máximo es: {maximo}";
                LBLPOSM.Text = posicion.ToString();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBLMAXIMO.Text = "No hay valores";
                LBLPOSM.Text = "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MNORDENAR_Click(object sender, EventArgs e)
        {
            PNBUSCAR.Visible = false;
            PNPEDIRN.Visible = false;
            PNORDENAR.Visible = true;
        }

        private void MNBVALOR_Click(object sender, EventArgs e)
        {
            GRPBVALORBUSCAR.Visible = true;
        }
    }

}
