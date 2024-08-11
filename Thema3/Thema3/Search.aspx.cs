using System;
using System.Web.UI.WebControls;

namespace Thema3
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //connect to db with a new object and call the method search to find the specific registration based on AMKA search
        protected void Button1_Click(object sender, EventArgs e)
        {
            VaccinatedCitizen citizen = new VaccinatedCitizen
            {
                AMKA = TextBox1.Text
            };
            ServerConnection connection = new ServerConnection();
            connection.SearchDB(citizen, GridView2);
        }
        //Gridview creates the specific registration based on AMKA search
        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            GridView2.EditIndex = e.NewEditIndex;
            VaccinatedCitizen citizen = new VaccinatedCitizen
            {
                AMKA = TextBox1.Text
            };
            ServerConnection connection = new ServerConnection();
            connection.SearchDB(citizen, GridView2);
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            TextBox firstName = GridView2.Rows[e.RowIndex].FindControl("txt_FirstName") as TextBox;
            TextBox lastName = GridView2.Rows[e.RowIndex].FindControl("txt_LastName") as TextBox;
            TextBox email = GridView2.Rows[e.RowIndex].FindControl("txt_Email") as TextBox;
            TextBox phoneNumber = GridView2.Rows[e.RowIndex].FindControl("txt_PhoneNumber") as TextBox;
            TextBox birthDate = GridView2.Rows[e.RowIndex].FindControl("txt_BirthDate") as TextBox;
            TextBox gender = GridView2.Rows[e.RowIndex].FindControl("txt_Gender") as TextBox;
            TextBox homeAddress = GridView2.Rows[e.RowIndex].FindControl("txt_HomeAddress") as TextBox;
            TextBox AMKA = GridView2.Rows[e.RowIndex].FindControl("txt_AMKA") as TextBox;
            TextBox underLyingDiseases = GridView2.Rows[e.RowIndex].FindControl("txt_UnderLyingDiseases") as TextBox;
            TextBox vaccinationDate = GridView2.Rows[e.RowIndex].FindControl("txt_VaccinationDate") as TextBox;
            TextBox vaccinationTime = GridView2.Rows[e.RowIndex].FindControl("txt_VaccinationTime") as TextBox;
            //create a new dummy citizen
            VaccinatedCitizen updateCitizen = new VaccinatedCitizen
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Email = email.Text,
                PhoneNumber = phoneNumber.Text,
                BirthDate = birthDate.Text,
                Gender = gender.Text,
                HomeAddress = homeAddress.Text,
                AMKA = AMKA.Text,
                UnderLyingDiseases = underLyingDiseases.Text,
                VaccinationDate = vaccinationDate.Text,
                VaccinationTime = vaccinationTime.Text
            };

            VaccinatedCitizen oldCitizen = new VaccinatedCitizen
            {
                AMKA = TextBox1.Text
            };
            //make a new connection
            ServerConnection connection = new ServerConnection();
            connection.UpdateDB(updateCitizen, oldCitizen, GridView2);

            //update table with new data
            ServerConnection connection2 = new ServerConnection();
            connection2.SearchDB(updateCitizen, GridView2);
        }
        //method to edit the registration of Gridview based on AMKA search
        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView2.EditIndex = -1;

            VaccinatedCitizen citizen = new VaccinatedCitizen
            {
                AMKA = TextBox1.Text
            };
            ServerConnection connection = new ServerConnection();
            connection.SearchDB(citizen, GridView2);
        }
        //method to delete the registration of Gridview based on AMKA search
        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //create a dummy citizen
            VaccinatedCitizen citizen = new VaccinatedCitizen
            {
                AMKA = TextBox1.Text
            };
            ServerConnection deleteCitizen = new ServerConnection();
            deleteCitizen.DeleteDB(citizen);

            ServerConnection connection2 = new ServerConnection();
            connection2.SearchDB(citizen, GridView2);
        }
    }
}