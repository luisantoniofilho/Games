namespace Games
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 18F);
            button1.Location = new Point(54, 133);
            button1.Name = "button1";
            button1.Size = new Size(311, 50);
            button1.TabIndex = 0;
            button1.Text = "Messi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 18F);
            button2.Location = new Point(54, 210);
            button2.Name = "button2";
            button2.Size = new Size(311, 50);
            button2.TabIndex = 1;
            button2.Text = "Ronaldo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tempus Sans ITC", 18F);
            button3.Location = new Point(54, 283);
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
            button4.Location = new Point(54, 367);
            button4.Name = "button4";
            button4.Size = new Size(311, 50);
            button4.TabIndex = 3;
            button4.Text = "Gerd muller";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Tempus Sans ITC", 18F);
            button5.Location = new Point(54, 444);
            button5.Name = "button5";
            button5.Size = new Size(311, 50);
            button5.TabIndex = 4;
            button5.Text = "Pelé";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 65);
            label1.Name = "label1";
            label1.Size = new Size(856, 35);
            label1.TabIndex = 5;
            label1.Text = "Qual o maior artilheiro da história da copa do mundo?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.TacaCopa;
            pictureBox1.Location = new Point(516, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Question1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Campo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(979, 576);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Question1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question 1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}