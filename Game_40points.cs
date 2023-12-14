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
            pictureBox8.Hide();
            pictureBox9.Hide();
        }

        Random rnd = new Random();
        int playerPoints = 0;
        int computerPoints = 0;
        int newGame = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //New game
            if (newGame == 0)
            {
                int num = numBaralho();
                pictureBox4.Load("baralho" + typeBaralho() + "-" + num + ".png");
                playerPoints += num;

                num = numBaralho();
                pictureBox5.Load("baralho" + typeBaralho() + "-" + num + ".png");
                playerPoints += num;

                num = numBaralho();
                pictureBox6.Load("baralho" + typeBaralho() + "-" + num + ".png");
                playerPoints += num;

                playerPoints += num;

                newGame = 1;
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int num = numBaralho();
            pictureBox7.Load("baralho" + typeBaralho() + "-" + num + ".png");
            playerPoints += num;
            if (playerPoints > 40)

            pictureBox8.Show();
        }

        private int typeBaralho()
        {
            int typeBaralho = rnd.Next(1, 5);
            return typeBaralho;
        }

        private int numBaralho()
        {
            int numBaralho = rnd.Next(4, 14);
            return numBaralho;
        }






        private void button2_Click(object sender, EventArgs e)
        {
            //Finalizar
            if (newGame == 1)
            {
                if (playerPoints > computerPoints)
                {
                    MessageBox.Show("Você venceu!", "Parabéns!");
                }
                else
                {
                    MessageBox.Show("Você perdeu!", "Derrota");
                }
                playerPoints = 0;
            }
        }

        

        
    }
}
