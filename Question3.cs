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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        //Main home = new Main();
        Question4 question4 = new Question4();

        private void button1_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Correct answer
            //home.questionPoints += 1;
            next();
        }

        private void next()
        {
            this.Hide();
            question4.ShowDialog();
        }

    }
}
