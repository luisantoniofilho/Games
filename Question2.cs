﻿using System;
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
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        //Main home = new Main();
        Question3 question3 = new Question3();

        private void button1_Click(object sender, EventArgs e)
        {
            //Corret answer
            //home.questionPoints += 1;
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
            next();
        }

        private void next()
        {
            this.Hide();
            question3.ShowDialog();
        }
    }
}
