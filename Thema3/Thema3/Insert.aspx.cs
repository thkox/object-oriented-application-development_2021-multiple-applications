using System;
using System.Drawing;
using System.Web.UI;

namespace Thema3
{
    public partial class Insert1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //when the page load for the first time
            if (!IsPostBack)
            {
                TextBox12.Visible = false;
            }
        }
        //registration button
        protected void RegisterB_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Register();
                ClearForm();
                StatusL.Text = "Register Complete!";
                StatusL.ForeColor = Color.Green;
            }
            else
            {
                StatusL.Text = "Error";
                StatusL.ForeColor = Color.Red;
            }
        }

        //clear button
        protected void CancelB_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        //method to visible the textbox if someone has an underlying disease
        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedIndex == 0)
            {
                TextBox12.Visible = true;
            }
            else
            {
                TextBox12.Visible = false;
            }
        }
        //matching textboxes with variables
        protected void Register()
        {
            VaccinatedCitizen citizen = new VaccinatedCitizen
            {
                FirstName = TextBox1.Text,
                LastName = TextBox2.Text,
                Email = TextBox3.Text,
                PhoneNumber = TextBox4.Text,
                BirthDate = TextBox9.Text,
                Gender = RadioButtonList1.SelectedValue,
                HomeAddress = TextBox6.Text,
                AMKA = TextBox8.Text
            };
            if (RadioButtonList2.SelectedValue == "No")
            {
                citizen.UnderLyingDiseases = RadioButtonList2.SelectedValue;
            }
            else
            {
                citizen.UnderLyingDiseases = TextBox12.Text;
            }
            citizen.VaccinationDate = TextBox10.Text;
            citizen.VaccinationTime = TextBox11.Text;
            //ServerConnection serverConnection = new ServerConnection();
            ServerConnection addcitizen = new ServerConnection();
            addcitizen.InsertCitizenToDB(citizen);
        }
        //clear every textbox and radio button list
        protected void ClearForm()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox8.Text = string.Empty;
            TextBox12.Text = string.Empty;
            TextBox11.Text = string.Empty;
            TextBox10.Text = string.Empty;
            RadioButtonList1.SelectedIndex = 0;
            RadioButtonList2.SelectedIndex = 0;
        }

    }
}