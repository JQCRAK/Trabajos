using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio10._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GRPBVIDEOSVISTO.Visible = false;
            GRPBTIPODERED.Visible = false;
            GRPBDISPOSITIVOAUTORIZADO.Visible = false;
        }

        private void CMBTIPOUSUARIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            GRPBDISPOSITIVOAUTORIZADO.Visible = false;
            GRPBVIDEOSVISTO.Visible = false;
            GRPBTIPODERED.Visible = false;

            if (CMBTIPOUSUARIO.SelectedItem.ToString() == "Basico")
            {
                GRPBVIDEOSVISTO.Visible = true;
            }
            else if (CMBTIPOUSUARIO.SelectedItem.ToString() == "Visitante")
            {
                GRPBTIPODERED.Visible = true;
            }
            else if (CMBTIPOUSUARIO.SelectedItem.ToString() == "Premium")
            {
                GRPBDISPOSITIVOAUTORIZADO.Visible = true;
            }
        }

        private void BTNINGRESAR_Click(object sender, EventArgs e)
        {
            string tipoUsuario = CMBTIPOUSUARIO.SelectedItem.ToString();

            if (tipoUsuario == "Premium" && GRPBDISPOSITIVOAUTORIZADO.Visible)
            {

                if (CKBSI.Checked)  
                {
                    MessageBox.Show("Acceso completo al contenido.");
                    Premium formularioPremium = new Premium();
                    formularioPremium.Show();
                    
                }
                else
                {
                    MessageBox.Show("Necesita una cuenta para acceder aver videos");
                    CrearCuenta crearCuenta = new CrearCuenta();
                    crearCuenta.ShowDialog();
                }
            }

            else if (tipoUsuario == "Basico" && GRPBVIDEOSVISTO.Visible)
            {
                int videosVistos;
                if (int.TryParse(TXTBVALOR.Text, out videosVistos))
                {
                    if (videosVistos < 5)
                    {
                        MessageBox.Show("Acceso solo a contenido gratuito.");
                        Basica formularioBasico = new Basica();
                        formularioBasico.Show();
                    }
                    else
                    {
                        MessageBox.Show("Necesita una cuenta para acceder aver videos.");
                        CrearCuenta crearCuenta = new CrearCuenta();
                        crearCuenta.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido de videos.");
                }
            }

            else if (tipoUsuario == "Visitante" && GRPBTIPODERED.Visible)
            {
                if (CKBPUBLICA.Checked)
                {
                    MessageBox.Show("Acceso solo a contenido público.");
                    Visitante formularioVisitante = new Visitante();
                    formularioVisitante.Show();

                }
                else
                {
                    MessageBox.Show("Necesita una cuenta para acceder aver videos.");
                    CrearCuenta crearCuenta = new CrearCuenta();
                    crearCuenta.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo de cuenta.");
            }
        }

        private void TXTBVALOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; 
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(TXTBVALOR.Text))
                    {
                        e.Handled = true; 
                        MessageBox.Show("Por favor, rellene el campo obligatorio.");
                    }
                    else
                    {
                        e.Handled = true; 
                        BTNINGRESAR.Focus(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CKBPUBLICA_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBPUBLICA.Checked)
            {
                CKBPRIVADA.Checked = false; 
            }
        }

        private void CKBPRIVADA_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBPRIVADA.Checked)
            {
                CKBPUBLICA.Checked = false; 
            }
        }

        private void CKBSI_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBSI.Checked)
            {
                CKBNO.Checked = false; 
            }
        }

        private void CKBNO_CheckedChanged(object sender, EventArgs e)
        {
            if (CKBNO.Checked)
            {
                CKBSI.Checked = false; 
            }
        }
    }
}
