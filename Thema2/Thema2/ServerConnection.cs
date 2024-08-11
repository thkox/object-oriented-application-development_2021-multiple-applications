using System;
using System.Data.SQLite;
namespace Thema2
{
    class ServerConnection
    {
        SQLiteConnection conn;
        //this method help us to insert data to our data base(betting from each player AND possible earnings)
        public void Insertion(string connectionString, int betting, int earnings)
        {
            //create a new object which help us to coonect to our database
            conn = new SQLiteConnection(connectionString);
            //open the database
            conn.Open();
            //create an insert query which help us to insert our 2 variables in a sfecific sequence
            string insertQuery = "Insert into BettingsEarnings values(@betting, @earnings);";
            //create a new object which help us to insert our variables with security and help us to execute the SQL command
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@betting", betting);
            cmd.Parameters.AddWithValue("@earnings", earnings);
            //execute the SQL command
            cmd.ExecuteNonQuery();
            //close the database
            conn.Close();
        }
        //this method help us to select 
        public string Selection(string connectionString, int totalBetting, int totalEarnings)
        {
            //create a new object which help us to coonect to our database
            conn = new SQLiteConnection(connectionString);
            //open the database
            conn.Open();
            //create a select string query that help us to sum all rows from the column Betting
            string selectSQLbet = "Select SUM(Bettings) from BettingsEarnings";
            //create a command object to execute the SQL commands
            SQLiteCommand cmd = new SQLiteCommand(selectSQLbet, conn);
            //use the variable totalBetting to save the sum from the SQL command and use it to return statement
            totalBetting = Convert.ToInt32(cmd.ExecuteScalar());
            //create a select string query that help us to sum all rows from the column Earnings
            string selectSQLearn = "Select SUM(Earnings) from BettingsEarnings";
            //create a command object to execute the SQL commands
            SQLiteCommand command = new SQLiteCommand(selectSQLearn, conn);
            //use the variable totalEarnings to save the sum from the SQL command and use it to return statement
            totalEarnings = Convert.ToInt32(command.ExecuteScalar());
            //close the database
            conn.Close();
            Console.WriteLine($"TotalBetting: {totalBetting}, TotalEarnings: {totalEarnings}");
            //return the message for the messageBox
            return $"The players have bet in total: {totalBetting}\nThe players have won overall: {totalEarnings}";
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173