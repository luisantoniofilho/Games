namespace Games
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public int questionPoints = 0;
        Question1 question1 = new Question1();
        Question2 question2 = new Question2();

        Game_40points game_40Points = new Game_40points();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            question1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            game_40Points.Show();
        }
    }
}
