using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace asp_final_project
{
    public partial class _Default : System.Web.UI.Page
    {
        SqlConnection xcon;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminbtn_Click(object sender, EventArgs e)
        {



            if (userrtxt.Text=="admin" && pwdtxt.Text=="kca")
            {
                Session["admin"] = "admin";
                Response.Redirect("admin.aspx");
            }
            else
	        {
                Response.Redirect("Default.aspx");
	        }


        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {

            StreamReader login_rdr = new StreamReader(MapPath("connection/conn.txt"));
            string con=login_rdr.ReadLine();
            xcon=new SqlConnection();
            xcon.ConnectionString=con;

            xcon.Open();
            SqlDataAdapter xadapt=new SqlDataAdapter("select * from userr_asp where Name='"+userrtxt.Text+"' and Pwd='"+pwdtxt.Text+"' ",xcon);
            DataTable xdata=new DataTable();
            xadapt.Fill(xdata);

            if (xdata.Rows.Count > 0)
            {
                Session["login"] = userrtxt.Text;
                Response.Redirect("welcome.aspx");
            }

       else
	       {
                Response.Redirect("Default.aspx");

	       }
      
            
	   }
    }
}
