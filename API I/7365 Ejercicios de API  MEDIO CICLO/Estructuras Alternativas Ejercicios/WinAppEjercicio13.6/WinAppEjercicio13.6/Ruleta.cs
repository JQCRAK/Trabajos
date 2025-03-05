using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;  

namespace WinAppEjercicio13._6
{
    public partial class Ruleta : Form
    {
        public string Usuario1 { get; set; }
        public string Usuario2 { get; set; }
        public string Usuario3 { get; set; }
        public string Usuario4 { get; set; }

        private WindowsMediaPlayer reproductor = new WindowsMediaPlayer();
        private WindowsMediaPlayer reproductorDeletreo = new WindowsMediaPlayer(); 
        private Timer temporizador = new Timer();
        private Timer temporizadorDeletrear = new Timer();
        private int tiempoReproduccion;
        private int tiempoDeletrear;
        private string palabraActual;
        private readonly string[] palabras = { "Alumno", "Ventana", "Ejemplo", "Problema", "Hermoso", "Aventura", "Correcto" };

        public Ruleta()
        {
            InitializeComponent();
            temporizador.Interval = 1000;
            temporizador.Tick += Temporizador_Tick;

            temporizadorDeletrear.Interval = 1000;
            temporizadorDeletrear.Tick += TemporizadorDeletrear_Tick;
        }

        private void Ruleta_Load(object sender, EventArgs e)
        {
            LBLUSUARIO1.Text = Usuario1;
            LBLUSUARIO2.Text = Usuario2;
            LBLUSUARIO3.Text = Usuario3;
            LBLUSUARIO4.Text = Usuario4;

            PCB1.Visible = false;
            PCB2.Visible = false;
            PCB3.Visible = false;
            PCB4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;

            LBLPALABRA.Text = "";
        }

        private void BTNGIRAR_Click(object sender, EventArgs e)
        {
            PCB1.Visible = false;
            PCB2.Visible = false;
            PCB3.Visible = false;
            PCB4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            LBLGANADOR.Text = "";
            LBLPALABRA.Text = "";

            string cancion = @"C:\Users\Jostin\Music\Musica sin Copyright Resumenes\Bad Style Time Back.mp3";

            if (System.IO.File.Exists(cancion))
            {
                reproductor.URL = cancion;
                reproductor.controls.play();

                Random random = new Random();
                tiempoReproduccion = random.Next(10, 21);

                temporizador.Start();

                PCB1.Visible = true;
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoReproduccion--;

            PCB1.Visible = false;
            PCB2.Visible = false;
            PCB3.Visible = false;
            PCB4.Visible = false;

            Random random = new Random();
            int imagenSeleccionada = random.Next(1, 5);

            switch (imagenSeleccionada)
            {
                case 1:
                    PCB1.Visible = true;
                    break;
                case 2:
                    PCB2.Visible = true;
                    break;
                case 3:
                    PCB3.Visible = true;
                    break;
                case 4:
                    PCB4.Visible = true;
                    break;
            }

            if (tiempoReproduccion <= 0)
            {
                reproductor.controls.stop();
                temporizador.Stop();
                MostrarGanador();
                SeleccionarPalabra();
            }
        }

        private void MostrarGanador()
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;

            if (PCB1.Visible)
            {
                LBLGANADOR.Text = $"{LBLUSUARIO1.Text} debe deletrear!";
            }
            else if (PCB2.Visible)
            {
                LBLGANADOR.Text = $"{LBLUSUARIO2.Text} debe deletrear!";
            }
            else if (PCB3.Visible)
            {
                LBLGANADOR.Text = $"{LBLUSUARIO3.Text} debe deletrear!";
            }
            else if (PCB4.Visible)
            {
                LBLGANADOR.Text = $"{LBLUSUARIO4.Text} debe deletrear!";
            }
        }

        private void SeleccionarPalabra()
        {
            Random random = new Random();
            palabraActual = palabras[random.Next(palabras.Length)];
            LBLPALABRA.Text = $"Deletrear: {palabraActual}";

            tiempoDeletrear = random.Next(5, 11);

            string cancionDeletreo = @"C:\Users\Jostin\Music\Musica sin Copyright Resumenes\Else - Paris.mp3";
            if (System.IO.File.Exists(cancionDeletreo))
            {
                reproductorDeletreo.URL = cancionDeletreo;
                reproductorDeletreo.controls.play();
            }

            temporizadorDeletrear.Start();
        }

        private void TemporizadorDeletrear_Tick(object sender, EventArgs e)
        {
            tiempoDeletrear--;

            if (tiempoDeletrear <= 0)
            {
                temporizadorDeletrear.Stop();
                reproductorDeletreo.controls.stop(); 
                MessageBox.Show("¡Tiempo límite para deletrear!", "Fin del tiempo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBLPALABRA.Text = "";
                LBLGANADOR.Text = "";
            }
        }

        private void BTNREINICIAR_Click(object sender, EventArgs e)
        {
            PCB1.Visible = false;
            PCB2.Visible = false;
            PCB3.Visible = false;
            PCB4.Visible = false;

            tiempoReproduccion = 0;
            tiempoDeletrear = 0;
            temporizadorDeletrear.Stop();
            reproductorDeletreo.controls.stop();
            LBLPALABRA.Text = "";
            LBLGANADOR.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
