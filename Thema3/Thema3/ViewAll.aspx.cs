using System;

namespace Thema3
{
    public partial class ViewAll : System.Web.UI.Page
    {
        //connect to db with a new object and call the method view all to show all the registrations where located in the db
        protected void Page_Load(object sender, EventArgs e)
        {
            ServerConnection addcitizen = new ServerConnection();
            addcitizen.ViewAllDB(GridView1);
        }
    }
}