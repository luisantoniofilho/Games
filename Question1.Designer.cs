﻿namespace Games
{
    partial class Question1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 18F);
            button1.Location = new Point(59, 109);
            button1.Name = "button1";
            button1.Size = new Size(311, 50);
            button1.TabIndex = 0;
            button1.Text = "Messi";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 18F);
            button2.Location = new Point(59, 186);
            button2.Name = "button2";
            button2.Size = new Size(311, 50);
            button2.TabIndex = 1;
            button2.Text = "Ronaldo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Tempus Sans ITC", 18F);
            button3.Location = new Point(59, 259);
            button3.Name = "button3";
            button3.Size = new Size(311, 50);
            button3.TabIndex = 2;
            button3.Text = "Klose";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tempus Sans ITC", 18F);
            button4.Location = new Point(59, 343);
            button4.Name = "button4";
            button4.Size = new Size(311, 50);
            button4.TabIndex = 3;
            button4.Text = "Gerd muller";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Tempus Sans ITC", 18F);
            button5.Location = new Point(59, 420);
            button5.Name = "button5";
            button5.Size = new Size(311, 50);
            button5.TabIndex = 4;
            button5.Text = "Pelé";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 18F);
            label1.Location = new Point(153, 35);
            label1.Name = "label1";
            label1.Size = new Size(708, 39);
            label1.TabIndex = 5;
            label1.Text = "Qual o maior artilheiro da história da copa do mundo?";
            // 
            // Question1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Campo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(979, 576);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Question1";
            Text = "Question 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}