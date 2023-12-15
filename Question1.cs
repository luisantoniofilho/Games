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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        //Main home = new Main();
        Question2 question2 = new Question2();

        private void button1_Click_1(object sender, EventArgs e)
        {
            next();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Correct answer
            //home.questionPoints +=1;
            next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            next();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            next();
        }

        private void next()
        {
            this.Hide();
            question2.ShowDialog();
        }
    }
}
