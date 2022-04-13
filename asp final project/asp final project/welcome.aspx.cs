using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_final_project
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Default.aspx");

            }

            
            
        }

        protected void programsbtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void stdntbtn_Click(object sender, EventArgs e)
        {
           
        }

        protected void progrmbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("programms.aspx");
        }

        protected void studentsbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("student.aspx");
        }
    }
}