using System;
using System.Windows.Forms;

namespace Thema1
{
    public partial class MainMenu : Form
    {
        Game game = new Game();
        Leaderboard leaderboard = new Leaderboard();
        PastGames pastscores = new PastGames();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //what happens when the player select Start
            EnterName playerNameForm = new EnterName();
            Hide();
            playerNameForm.ShowDialog();
            if (playerNameForm.selectedClose == true)
            {
                Show();
            }
            else
            {
                game.playerName = playerNameForm.playerName;
                game.loadGame();
                game.ShowDialog();
                Show();
            }
        }

        private void leaderBoardB_Click(object sender, EventArgs e)
        {
            Hide();
            leaderboard.ShowDialog();
            Show();
        }

        private void pastScores_Click(object sender, EventArgs e)
        {
            //what happens when the player select Start
            EnterName playerNameForm = new EnterName();
            Hide();
            playerNameForm.ShowDialog();
            if (playerNameForm.selectedClose == true)
            {
                Show();
            }
            else
            {
                pastscores.playerName = playerNameForm.playerName;
                pastscores.loadData();
                Console.WriteLine(pastscores.playerName);
                pastscores.ShowDialog();
                Show();
            }
        }

        private void rulesB_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            Hide();
            rules.ShowDialog();
            Show();
        }
        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173