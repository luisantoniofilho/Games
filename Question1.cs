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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }
        Main formMain = new Main();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 0;
            formMain.addAccepts(num);
        }
    }
}
