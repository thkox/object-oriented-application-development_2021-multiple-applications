using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Thema1
{
    class ServerConnection
    {
        SQLiteConnection conn;
        private string stringdb = "Data source=seafight.db;Version=3";
        public void InsertPlayerData(string playerName, string result, int tries, string timer, int playerCounter, int enemyCounter)
        {
            conn = new SQLiteConnection(stringdb);
            conn.Open();
            string insertQuery = "Insert into leaderboard values(@Name, @Result, @Tries, @Time, @PlayerShips, @EnemyShips);";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@Name", playerName);
            cmd.Parameters.AddWithValue("@Result", result);
            cmd.Parameters.AddWithValue("@Tries", tries);
            cmd.Parameters.AddWithValue("@Time", timer);
            cmd.Parameters.AddWithValue("@PlayerShips", playerCounter);
            cmd.Parameters.AddWithValue("@EnemyShips", enemyCounter);
            //exception handler
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void LeaderBoardTable(DataGridView leaderboardTable)
        {
            conn = new SQLiteConnection(stringdb);
            conn.Open();
            string leaderBoard = "SELECT Name, COUNT(*) FROM leaderboard WHERE (Result)= 'You are the Winner' GROUP BY (Name) ORDER BY 2 DESC";
            //execute the command
            SQLiteCommand cmd = new SQLiteCommand(leaderBoard, conn);
            //take the data from the results
            SQLiteDataAdapter execute = new SQLiteDataAdapter(cmd);
            //create a new dataTable
            DataTable table = new DataTable();
            //fill the table with the data from the cmd
            execute.Fill(table);
            //change column name
            table.Columns["Name"].ColumnName = "Player";
            table.Columns["Count(*)"].ColumnName = "Wins";
            //pass the data to the datagridview
            leaderboardTable.DataSource = table;
            conn.Close();
        }

        public void PastScores(DataGridView pastScoreTable, string playerName = "Player")
        {
            conn = new SQLiteConnection(stringdb);
            conn.Open();
            string leaderBoard = "SELECT * FROM leaderboard WHERE (Name) = @Player; ";
            //execute the command
            SQLiteCommand cmd = new SQLiteCommand(leaderBoard, conn);
            cmd.Parameters.AddWithValue("@Player", playerName);
            //take the data from the results
            SQLiteDataAdapter execute = new SQLiteDataAdapter(cmd);
            //create a new dataTable
            DataTable table = new DataTable();
            //fill the table with the data from the cmd
            execute.Fill(table);
            //pass the data to the datagridview
            pastScoreTable.DataSource = table;
            conn.Close();
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173