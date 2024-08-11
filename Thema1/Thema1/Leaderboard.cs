using System;
using System.Windows.Forms;

namespace Thema1
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        //load all players data
        private void Leaderboard_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            ServerConnection leaderBoardData = new ServerConnection();
            leaderBoardData.LeaderBoardTable(leaderTable);
            leaderTable.ClearSelection();
            leaderTable.RowHeadersVisible = false;
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173
