using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.Logging;
using WMPLib;

namespace WinAppEjercicio10._3
{
    public partial class Premium : Form
    {
        private string[] videos = new string[]
{
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\1.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\2.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\3.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\4.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\5.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\6.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\7.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\8.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\9.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\10.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\11.mp4",
            @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\Videos premium\12.mp4"
        };
        private int currentVideoIndex = 0;
        public Premium()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;

        }
        private void PlayVideo(int index)
        {
            if (index >= 0 && index < videos.Length)
            {
                axWindowsMediaPlayer1.URL = videos[index];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) 
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0; 
                axWindowsMediaPlayer1.Ctlcontrols.play(); 
            }
        }



        private void Premium_Load(object sender, EventArgs e)
        {
            PlayVideo(currentVideoIndex);
            
        }

        

        private void BTNREGRESARV_Click(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\icons8-me-gusta-50.png";

            pictureBox6.Image = Image.FromFile(imagePath);
            currentVideoIndex = (currentVideoIndex - 1 + videos.Length) % videos.Length;
            PlayVideo(currentVideoIndex);

        }

        private void BTNSIGUIENTEV_Click(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\icons8-me-gusta-50.png";

            pictureBox6.Image = Image.FromFile(imagePath);

            currentVideoIndex = (currentVideoIndex + 1) % videos.Length;
            PlayVideo(currentVideoIndex);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\Jostin\Pictures\IMAGENES PARA APP\like entero.png";

            pictureBox6.Image = Image.FromFile(imagePath);
        }

        private void PCTBREGRESAR_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
