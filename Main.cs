namespace Games
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public int questionPoints = 0;

        public void addAccepts(int num)
        {
            questionPoints += num;
        }

        

        Game_40points game_40Points = new Game_40points();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            game_40Points.ShowDialog();
        }
    }
}
