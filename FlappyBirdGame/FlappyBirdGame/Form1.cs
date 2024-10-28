using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; //oyun içinde boruların hareket etme hızı
        int gravity = 15;
        int score = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimer(object sender, EventArgs e)
        {
            //hareket halindeki hızlarını ayarladık
            pictureBox_bird.Top += gravity;
            pictureBox_down.Left -= pipeSpeed;
            pictureBox_top.Left -= pipeSpeed;
            //scoru hesaplattık
            label1.Text = "SCORE:" + score;

            //boruların konumuna göre skorumuzu arttırdık
            if (pictureBox_down.Left < -150)
            {
                pictureBox_down.Left = 800;
                score++;
            }
            if (pictureBox_top.Left < -180)
            {
                pictureBox_top.Left = 950;
                score++;
            }

            //kuş herhangi bir engele çarptı mı onu kontrol ederiz ona göre oyunu bitiririz
            if (pictureBox_bird.Bounds.IntersectsWith(pictureBox_down.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_top.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_grown.Bounds) ||
                pictureBox_bird.Top < -25)
            {
                EndGame();
            }
        }
            //oyun bitirme metodu
            public void EndGame()
            {
                timer_control.Stop();
                label1.Text = "GAME OVER!";
            }

        

        //yukarı ve aşağıya space tuşuyla hareket ettirmeyi ayarlar yükselme derecelerini belirler
        private void game_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +15;
            }
        }
    }
}
