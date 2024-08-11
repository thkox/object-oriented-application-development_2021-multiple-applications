using System;
using System.Windows.Forms;

namespace Thema1
{
    public partial class EndScreen : Form
    {
        public string winnerText = "The winner";
        public string playerName = "Player";
        public bool playAgain = false;
        PastGames pastScores = new PastGames();
        public EndScreen()
        {
            InitializeComponent();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            winnerL.Text = winnerText;
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pastGamesL_Click(object sender, EventArgs e)
        {
            pastScores.playerName = playerName;
            pastScores.loadData();
            Hide();
            pastScores.ShowDialog();
            Show();
        }

        private void playAgainB_Click(object sender, EventArgs e)
        {
            playAgain = true;
            Hide();
        }
    }
}
