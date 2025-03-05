using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio11._4
{
    public partial class Form1 : Form
    {
        int di;

        

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            LBLDISTANCIA.Visible = true;
            
                string ValorX = TXTBVALORX.Text;
                string ValorY = TXTBVALORY.Text;
                double ValorXE = double.Parse(ValorX);
                double ValorYE = double.Parse(ValorY);

                LBLPUNTO.Text = $"({ValorXE}, {ValorYE})";

                PosicionyDistancia ObjCuadrante = new PosicionyDistancia(ValorXE, ValorYE);

                LBLRESULCUADRANTE.Text = ObjCuadrante.Posicion();
                LBLRESULDISTANCIA.Text = ObjCuadrante.CalcularD().ToString("F2");
                di = ObjCuadrante.ImagenC();
                try 
                {
                if(di == 1)
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\Cuadrante1.jpg");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }
                else if (di == 2)
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\Cuadrante2.jpg");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }
                else if (di == 3)
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\Cuadrante3.jpg");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }
                else if (di == 4)
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\Cuadrante4.jpg");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }
                else if (di == 5)
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\EJEY.jpg");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }
                else if(di == 6)
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\EJEX.jpg");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }
                else
                {
                    PCBCUADRANTE.Image = Image.FromFile("C:\\Users\\Jostin\\Pictures\\IMAGENES PARA APP\\cuadrante0.png");
                    pictureBox1.Focus();
                    TXTBVALORX.Clear();
                    TXTBVALORX.Focus();
                    TXTBVALORY.Clear();
                }

            }
            catch(Exception ex) { }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLDISTANCIA.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TXTBVALORY_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '-' && TXTBVALORY.Text.Length > 0)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && TXTBVALORY.Text.Contains("."))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (TXTBVALORY.Text == "")
                    {
                        MessageBox.Show("Por favor, ingrese un valor en Y antes de continuar.");
                    }
                    else
                    {
                        BTNCALCULAR.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        


        private void TXTBVALORX_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '-' && TXTBVALORX.Text.Length > 0) 
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && TXTBVALORX.Text.Contains(".")) 
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    if (TXTBVALORX.Text == "")
                    {
                        MessageBox.Show("Por favor, ingrese un valor en X antes de continuar.");
                    }
                    else
                    {
                        TXTBVALORY.Focus();
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
            TXTBVALORX.Clear();
            TXTBVALORY.Clear();

            PCBCUADRANTE.Visible = true;  
            LBLPUNTO.Visible = true;      
            LBLRESULCUADRANTE.Visible = true;
            LBLRESULDISTANCIA.Visible = true;

            LBLPUNTO.Text = "";
            LBLRESULCUADRANTE.Text = "";
            LBLRESULDISTANCIA.Text = "";
            TXTBVALORX.Focus();
        }
    }
}
