namespace Games
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 18F);
            label1.Location = new Point(144, 32);
            label1.Name = "label1";
            label1.Size = new Size(636, 39);
            label1.TabIndex = 11;
            label1.Text = "Qual desses jogadores ganhou a copa do mundo?";
            // 
            // button5
            // 
            button5.Font = new Font("Tempus Sans ITC", 18F);
            button5.Location = new Point(50, 417);
            button5.Name = "button5";
            button5.Size = new Size(311, 50);
            button5.TabIndex = 10;
            button5.Text = "Johan Cruyff";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Tempus Sans ITC", 18F);
            button4.Location = new Point(50, 340);
            button4.Name = "button4";
            button4.Size = new Size(311, 50);
            button4.TabIndex = 9;
            button4.Text = "Puskás";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Tempus Sans ITC", 18F);
            button3.Location = new Point(50, 256);
            button3.Name = "button3";
            button3.Size = new Size(311, 50);
            button3.TabIndex = 8;
            button3.Text = "Zico";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 18F);
            button2.Location = new Point(50, 183);
            button2.Name = "button2";
            button2.Size = new Size(311, 50);
            button2.TabIndex = 7;
            button2.Text = "Cristiano Ronaldo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 18F);
            button1.Location = new Point(50, 106);
            button1.Name = "button1";
            button1.Size = new Size(311, 50);
            button1.TabIndex = 6;
            button1.Text = "Nesta";
            button1.UseVisualStyleBackColor = true;
            // 
            // Question2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Campo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 583);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Question2";
            Text = "Question2";
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
    }
}