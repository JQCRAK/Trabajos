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
    public partial class Form2 : Form
    {

        string v1, tlfn;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataSet11.WriteXml("C:\\Users\\Jostin\\Documents\\QUINTO\\API I\\WinApp_Archivos\\WinApp_Archivos\\WinApp_Archivos\\ArchivoA.xml");
            object[] vector = new object[4];
            vector[1] = txtNombre.Text;
            vector[2] = cmbxEdad.Text;
            vector[3] = txtTelefono.Text;

            dataSet11.tblDatos.Rows.Add(vector);
            dataSet11.ReadXml("C:\\Users\\Jostin\\Documents\\QUINTO\\API I\\WinApp_Archivos\\WinApp_Archivos\\WinApp_Archivos\\ArchivoA.xml");

        }

        private void cmbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    // Validar si el valor ingresado está en la lista de elementos del ComboBox
                    if (cmbxEdad.Items.Contains(cmbxEdad.Text))
                    {
                        txtTelefono.Focus(); // Si es válido, pasamos al siguiente campo
                    }
                    else
                    {
                        // Si el valor no es válido, mostrar un mensaje de error
                        MessageBox.Show("No se admiten otros valores!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbxEdad.Text = string.Empty; // Limpiar el texto del ComboBox
                        cmbxEdad.Focus(); // Mantener el foco en el ComboBox
                    }
                }

            }
            catch
            {
                MessageBox.Show("SOLO SE ADMITEN LOS VALORES INDICADOS ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbxEdad.Text = string.Empty; // Limpiar el texto del ComboBox en caso de error
                cmbxEdad.Focus(); // Volver a enfocar el ComboBox
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tlfn = txtTelefono.Text;  // Guardamos el teléfono ingresado

                    
                }
            }
            catch
            {
                // Mostramos el mensaje de error si el teléfono no es válido
                MessageBox.Show("¡Solo se admiten números!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Clear();  // Limpiamos el campo
                txtTelefono.Focus();  // Volvemos a enfocar el campo de teléfono
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Permitir solo letras, espacio y retroceso
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Cancelar la entrada del carácter
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten letras.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Si el usuario presiona Enter y la entrada es válida
                if (e.KeyChar == (char)Keys.Enter)
                {
                    v1 = txtNombre.Text;
                    cmbxEdad.Focus();
                }

            }
            catch
            {
                MessageBox.Show("NO SE ADMINTE VALORES NUMÉRICOS!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();
                txtNombre.Focus();
            }
        }
    }
}
