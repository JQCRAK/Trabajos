using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace WinAppEjercicio24._3
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recognizer;
        public Form1()
        {
            InitializeComponent();
            InicializarReconocimiento();
        }

        private void InicializarReconocimiento()
        {
            try
            {
                recognizer = new SpeechRecognitionEngine();
                recognizer.SetInputToDefaultAudioDevice(); 

                recognizer.LoadGrammar(new DictationGrammar());

                recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
                recognizer.RecognizeCompleted += Recognizer_RecognizeCompleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el reconocimiento: {ex.Message}");
            }
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            TXTBTRANSCRITO.AppendText(e.Result.Text + " ");
        }

        private void Recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            MessageBox.Show("Reconocimiento completado.");
        }

        private void BTNCOMENZAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTBTRANSCRITO.Text == "El texto transcrito aparecerá aquí...")
                {
                    TXTBTRANSCRITO.Clear();
                }

                recognizer.RecognizeAsync(RecognizeMode.Multiple); 
                BTNCOMENZAR.Enabled = false; 
                BTNDETENER.Enabled = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al comenzar: {ex.Message}");
            }
        }

        private void BTNDETENER_Click(object sender, EventArgs e)
        { 
            try
            {
                recognizer.RecognizeAsyncStop(); 
                BTNCOMENZAR.Enabled = true;
                BTNDETENER.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al detener: {ex.Message}");
            }
        }

       
        private void BTNREINICAR_Click(object sender, EventArgs e)
        {
            TXTBTRANSCRITO.Clear();
            TXTBTRANSCRITO.Text = "El texto transcrito aparecerá aquí...";
            TXTBTRANSCRITO.ReadOnly = true; 
        }
    }
}
