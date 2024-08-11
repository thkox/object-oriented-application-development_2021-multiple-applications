using System.Data;
using System.Data.SQLite;
using System.Web.UI.WebControls;

namespace Thema3
{
    public class ServerConnection
    {
        SQLiteConnection conn;
        private readonly string connectionString = "Data source=---TobeCompleted-------CovidDB.db;Version=3";
        public void InsertCitizenToDB(VaccinatedCitizen citizen)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string insertQuery = "Insert into Vaccinated values(@FirstName, @LastName, @Email, @Phone, @BirthDate, @Gender, @HomeAddress, @AMKA, @UnderlyingDiseases, @Date, @Time);";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@FirstName", citizen.FirstName);
            cmd.Parameters.AddWithValue("@LastName", citizen.LastName);
            cmd.Parameters.AddWithValue("@Email", citizen.Email);
            cmd.Parameters.AddWithValue("@Phone", citizen.PhoneNumber);
            cmd.Parameters.AddWithValue("@BirthDate", citizen.BirthDate);
            cmd.Parameters.AddWithValue("@Gender", citizen.Gender);
            cmd.Parameters.AddWithValue("@HomeAddress", citizen.HomeAddress);
            cmd.Parameters.AddWithValue("@AMKA", citizen.AMKA);
            cmd.Parameters.AddWithValue("@UnderlyingDiseases", citizen.UnderLyingDiseases);
            cmd.Parameters.AddWithValue("@Date", citizen.VaccinationDate);
            cmd.Parameters.AddWithValue("@Time", citizen.VaccinationTime);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ViewAllDB(GridView dataTable)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string viewAll = "SELECT * FROM Vaccinated";
            //execute the command
            SQLiteCommand cmd = new SQLiteCommand(viewAll, conn);
            //take the data from the results
            SQLiteDataAdapter execute = new SQLiteDataAdapter(cmd);
            //create a new dataTable
            DataTable table = new DataTable();
            //fill the table with the data from the cmd
            execute.Fill(table);
            //pass the data to the datagridview
            dataTable.DataSource = table;
            dataTable.DataBind();
            //dataTable.DataBind();
            conn.Close();
        }
        public void SearchDB(VaccinatedCitizen citizen, GridView dataTable)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string vaccinated = "SELECT * FROM Vaccinated WHERE (AMKA) = @AMKA; ";
            //execute the command
            SQLiteCommand cmd = new SQLiteCommand(vaccinated, conn);
            cmd.Parameters.AddWithValue("@AMKA", citizen.AMKA);
            //take the data from the results
            SQLiteDataAdapter execute = new SQLiteDataAdapter(cmd);
            //create a new dataTable
            DataTable table = new DataTable();
            //fill the table with the data from the cmd
            execute.Fill(table);
            //pass the data to the datagridview
            dataTable.DataSource = table;
            dataTable.DataBind();
            conn.Close();
        }
        public void UpdateDB(VaccinatedCitizen citizen, VaccinatedCitizen citizenTemp, GridView dataTable)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string updateQuery = "UPDATE Vaccinated SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, BirthDate = @BirthDate, Gender = @Gender, HomeAddress = @HomeAddress, AMKA = @AMKA, UnderlyingDiseases = @UnderlyingDiseases, Date = @Date, Time = @Time WHERE (AMKA) = @AMKA2; ";
            SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@FirstName", citizen.FirstName);
            cmd.Parameters.AddWithValue("@LastName", citizen.LastName);
            cmd.Parameters.AddWithValue("@Email", citizen.Email);
            cmd.Parameters.AddWithValue("@Phone", citizen.PhoneNumber);
            cmd.Parameters.AddWithValue("@BirthDate", citizen.BirthDate);
            cmd.Parameters.AddWithValue("@Gender", citizen.Gender);
            cmd.Parameters.AddWithValue("@HomeAddress", citizen.HomeAddress);
            cmd.Parameters.AddWithValue("@AMKA", citizen.AMKA);
            cmd.Parameters.AddWithValue("@UnderlyingDiseases", citizen.UnderLyingDiseases);
            cmd.Parameters.AddWithValue("@Date", citizen.VaccinationDate);
            cmd.Parameters.AddWithValue("@Time", citizen.VaccinationTime);
            cmd.Parameters.AddWithValue("@AMKA2", citizenTemp.AMKA);

            cmd.ExecuteNonQuery();
            conn.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            dataTable.EditIndex = -1;
        }
        public void DeleteDB(VaccinatedCitizen citizen)
        {
            //delete the personal data of the citizen
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string deleteQuery = "DELETE FROM Vaccinated WHERE AMKA = @AMKA; ";
            SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
            cmd.Parameters.AddWithValue("@AMKA", citizen.AMKA);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}