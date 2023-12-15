using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Game_40points : Form
    {
        public Game_40points()
        {
            InitializeComponent();
        }

        private void Game_40points_Load(object sender, EventArgs e)
        {
            restart();
        }

        Random rnd = new Random();
        int playerPoints = 0;
        int computerPoints = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //New game
            restart();
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox8.Show();

            int num = rnd.Next(4, 14);
            pictureBox5.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;

            num = rnd.Next(4, 14);
            pictureBox6.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;

            num = rnd.Next(4, 14);
            pictureBox7.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;

            lblJogador.Text = playerPoints.ToString();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Enabled = false;
            int num = rnd.Next(4, 14);
            pictureBox8.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;
            lblJogador.Text = playerPoints.ToString();
            pictureBox9.Show();
            pictureBox9.Enabled = true;
            loseTest();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Enabled = false;
            int num = rnd.Next(4, 14);
            pictureBox9.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;
            lblJogador.Text = playerPoints.ToString();
            pictureBox10.Show();
            pictureBox10.Enabled = true;
            loseTest();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Enabled = false;
            int num = rnd.Next(4, 14);
            pictureBox10.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;
            lblJogador.Text = playerPoints.ToString();
            loseTest();
        }

        private void computerBaralho()
        {
            int num = rnd.Next(6, 14);
            pictureBox1.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            num = rnd.Next(6, 14);
            pictureBox2.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            num = rnd.Next(6, 14);
            pictureBox3.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            num = rnd.Next(6, 14);
            pictureBox4.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            lblComputer.Text = "0";
            lblComputer.Text = computerPoints.ToString();
        }

        private void loseTest()
        {
            if (playerPoints > 40)
            {
                MessageBox.Show("Você estorou os 40 pontos!", "Derrota");
                restart();
            }
        }

        private void restart()
        {
            //Restart parameters
            playerPoints = 0;
            lblJogador.Text = playerPoints.ToString();
            computerPoints = 0;
            lblComputer.Text = computerPoints.ToString();

            //Hide and disable objects
            button1.Enabled = true;
            button2.Enabled = false;

            //Player
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();

            //Load default computer pictureboxes
            pictureBox1.Load("baralhoV.png");
            pictureBox2.Load("baralhoV.png");
            pictureBox3.Load("baralhoV.png");
            pictureBox4.Load("baralhoV.png");

            //Load default player pictureboxes
            pictureBox5.Load("baralhoA.png");
            pictureBox6.Load("baralhoA.png");
            pictureBox7.Load("baralhoA.png");
            pictureBox8.Load("baralhoA.png");
            pictureBox9.Load("baralhoA.png");
            pictureBox10.Load("baralhoA.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Finish
            button1.Enabled = true;
            pictureBox8.Enabled = true;

            //Baralho computer
            computerBaralho();

            if (playerPoints < computerPoints)
            {
                MessageBox.Show("Você perdeu!", "Derrota");
            }
            else if (playerPoints == computerPoints)
            {
                MessageBox.Show("Empatou!", "Empate");
            }
            else
            {
                MessageBox.Show("Você venceu!", "Parabéns!");
            }

            //Restart game
            restart();
        }

        
    }
}
