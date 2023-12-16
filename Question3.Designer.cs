namespace Games
{
    partial class Question3
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
            label1.Location = new Point(150, 57);
            label1.Name = "label1";
            label1.Size = new Size(695, 37);
            label1.TabIndex = 17;
            label1.Text = "Qual desses jogadores não joga na arábia?";
            // 
            // button5
            // 
            button5.Font = new Font("Tempus Sans ITC", 18F);
            button5.Location = new Point(77, 420);
            button5.Name = "button5";
            button5.Size = new Size(311, 50);
            button5.TabIndex = 16;
            button5.Text = "Mohamed Salah";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tempus Sans ITC", 18F);
            button4.Location = new Point(77, 343);
            button4.Name = "button4";
            button4.Size = new Size(311, 50);
            button4.TabIndex = 15;
            button4.Text = "Sadio Mané";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tempus Sans ITC", 18F);
            button3.Location = new Point(77, 259);
            button3.Name = "button3";
            button3.Size = new Size(311, 50);
            button3.TabIndex = 14;
            button3.Text = "Cristiano Ronaldo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 18F);
            button2.Location = new Point(77, 186);
            button2.Name = "button2";
            button2.Size = new Size(311, 50);
            button2.TabIndex = 13;
            button2.Text = "Kanté";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 18F);
            button1.Location = new Point(77, 109);
            button1.Name = "button1";
            button1.Size = new Size(311, 50);
            button1.TabIndex = 12;
            button1.Text = "Benzema";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Richarlison;
            pictureBox1.Location = new Point(533, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 342);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Question3
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
            Name = "Question3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question3";
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