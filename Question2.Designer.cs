﻿namespace Games
{
    partial class Question2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 50);
            label1.Name = "label1";
            label1.Size = new Size(794, 37);
            label1.TabIndex = 11;
            label1.Text = "Qual desses jogadores ganhou a copa do mundo?";
            // 
            // button5
            // 
            button5.Font = new Font("Tempus Sans ITC", 18F);
            button5.Location = new Point(76, 420);
            button5.Name = "button5";
            button5.Size = new Size(311, 50);
            button5.TabIndex = 10;
            button5.Text = "Johan Cruyff";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tempus Sans ITC", 18F);
            button4.Location = new Point(76, 343);
            button4.Name = "button4";
            button4.Size = new Size(311, 50);
            button4.TabIndex = 9;
            button4.Text = "Puskás";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tempus Sans ITC", 18F);
            button3.Location = new Point(76, 259);
            button3.Name = "button3";
            button3.Size = new Size(311, 50);
            button3.TabIndex = 8;
            button3.Text = "Zico";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 18F);
            button2.Location = new Point(76, 186);
            button2.Name = "button2";
            button2.Size = new Size(311, 50);
            button2.TabIndex = 7;
            button2.Text = "Cristiano Ronaldo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 18F);
            button1.Location = new Point(76, 109);
            button1.Name = "button1";
            button1.Size = new Size(311, 50);
            button1.TabIndex = 6;
            button1.Text = "Nesta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Mbappe;
            pictureBox1.Location = new Point(529, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Question2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Campo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 583);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Question2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}