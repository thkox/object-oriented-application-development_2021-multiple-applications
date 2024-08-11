using System;

namespace Thema3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //redirect us to search form
        protected void SearchB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }
        //redirect us to insert form
        protected void RegisterB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }
        //redirect us to view all form
        protected void ViewAllB_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAll.aspx");
        }
    }
}