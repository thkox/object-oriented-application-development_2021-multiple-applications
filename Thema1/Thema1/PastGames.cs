using System;
using System.Windows.Forms;

namespace Thema1
{
    public partial class PastGames : Form
    {
        public string playerName = "Player";
        public PastGames()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            //create a new connection
            Console.WriteLine($"{playerName} wants to know his/her past games.");
            ServerConnection accessData = new ServerConnection();
            accessData.PastScores(pastScoreTable, playerName);
            pastScoreTable.ClearSelection();
            pastScoreTable.RowHeadersVisible = false;
        }

        private void PastGames_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173