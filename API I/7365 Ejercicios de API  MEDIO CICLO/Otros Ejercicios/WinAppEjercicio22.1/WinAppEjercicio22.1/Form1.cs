using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEjercicio22._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNTNEGRITA_Click(object sender, EventArgs e)
        {
            if (RTBINFORMACION.SelectionFont != null)
            {
                FontStyle style = RTBINFORMACION.SelectionFont.Style;
                if (RTBINFORMACION.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold; 
                }
                else
                {
                    style |= FontStyle.Bold; 
                }
                RTBINFORMACION.SelectionFont = new Font(RTBINFORMACION.SelectionFont, style);
            }
        }

        private void BTNTCURSIVA_Click(object sender, EventArgs e)
        {
            if (RTBINFORMACION.SelectionFont != null)
            {
                FontStyle style = RTBINFORMACION.SelectionFont.Style;
                if (RTBINFORMACION.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic; 
                }
                else
                {
                    style |= FontStyle.Italic;
                }
                RTBINFORMACION.SelectionFont = new Font(RTBINFORMACION.SelectionFont, style);
            }
        }

        private void BTNTSUBRAYADO_Click(object sender, EventArgs e)
        {
            if (RTBINFORMACION.SelectionFont != null)
            {
                FontStyle style = RTBINFORMACION.SelectionFont.Style;
                if (RTBINFORMACION.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline; 
                }
                else
                {
                    style |= FontStyle.Underline; 
                }
                RTBINFORMACION.SelectionFont = new Font(RTBINFORMACION.SelectionFont, style);
            }
        }

        private void PCBALINEADOIZ_Click(object sender, EventArgs e)
        {
            RTBINFORMACION.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void PCBTALINEADOCE_Click(object sender, EventArgs e)
        {
            RTBINFORMACION.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void PCBALINEADODE_Click(object sender, EventArgs e)
        {
            RTBINFORMACION.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CMBTAMANIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RTBINFORMACION.SelectionFont != null)
            {
                float tamaño = Convert.ToSingle(CMBTAMANIO.SelectedItem);

                RTBINFORMACION.SelectionFont = new Font(RTBINFORMACION.SelectionFont.FontFamily, tamaño);
            }
            else
            {
                RTBINFORMACION.SelectionFont = new Font(RTBINFORMACION.Font.FontFamily, Convert.ToSingle(CMBTAMANIO.SelectedItem));
            }
        }

        private void CMBTIPOLETRA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RTBINFORMACION.SelectionFont != null)
            {
                string fuente = CMBTIPOLETRA.SelectedItem.ToString();

                RTBINFORMACION.SelectionFont = new Font(fuente, RTBINFORMACION.SelectionFont.Size);
            }
            else
            {
                RTBINFORMACION.SelectionFont = new Font(CMBTIPOLETRA.SelectedItem.ToString(), RTBINFORMACION.Font.Size);
            }
        }

        private void PCBCOLORDIA_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    RTBINFORMACION.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Rich Text Files|*.rtf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RTBINFORMACION.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void BTNCARGAR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Rich Text Files|*.rtf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RTBINFORMACION.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMBTAMANIO.Items.AddRange(new object[] { 10, 12, 14, 16, 18, 20, 22, 24, 28, 34, 40, 60 });

            CMBTAMANIO.SelectedItem = 12; 

            CMBTIPOLETRA.Items.AddRange(new object[] { "Arial", "Calibri", "Times New Roman", "Verdana", "Tahoma", "Comic Sans MS", "Georgia" });
            CMBTIPOLETRA.SelectedItem = "Arial"; 

            RTBINFORMACION.ReadOnly = false;
        }
    }
}
