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
            pictureBox7.Enabled = true;
            pictureBox7.Show();

            int num = rnd.Next(4, 14);
            pictureBox4.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;

            num = rnd.Next(4, 14);
            pictureBox5.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;

            num = rnd.Next(4, 14);
            pictureBox6.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;

            txtPlayerPoints.Text = playerPoints.ToString();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Enabled = false;
            int num = rnd.Next(4, 14);
            pictureBox7.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;
            txtPlayerPoints.Text = playerPoints.ToString();
            pictureBox8.Show();
            loseTest();

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int num = rnd.Next(4, 14);
            pictureBox8.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            playerPoints += num;
            txtPlayerPoints.Text = playerPoints.ToString();
            pictureBox9.Show();
            loseTest();
        }

        private void computerBaralho()
        {
            int num = rnd.Next(1, 14);
            pictureBox1.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            num = rnd.Next(1, 14);
            pictureBox2.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            num = rnd.Next(1, 14);
            pictureBox3.Load("baralho" + rnd.Next(1, 5) + "-" + num + ".png");
            computerPoints += num;

            txtComputerPoints.Text = computerPoints.ToString();
        }

        private void loseTest()
        {
            if (playerPoints > 40)
            {
                MessageBox.Show("Você perdeu!", "Derrota");
                restart();
            }
        }

        private void restart()
        {
            //Restart parameters
            playerPoints = 0;
            txtPlayerPoints.Text = playerPoints.ToString();
            computerPoints = 0;
            txtComputerPoints.Text = computerPoints.ToString();

            //Hide and disable objects
            button1.Enabled = true;
            button2.Enabled = false;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Finalizar
            button1.Enabled = true;
            pictureBox7.Enabled = true;

            //Baralho computer
            computerBaralho();

            if (playerPoints < computerPoints)
                {
                    MessageBox.Show("Você perdeu!", "Derrota");
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
