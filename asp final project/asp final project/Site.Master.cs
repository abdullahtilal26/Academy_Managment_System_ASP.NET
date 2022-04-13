using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;

namespace asp_final_project
{
    
    public partial class SiteMaster : System.Web.UI.MasterPage
    {

        SqlConnection xcon;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ico.Text = "";
            ico.Text += "<img src='images_upload/KCS-logo-.png' width='55' height='65'/>";
        }

        protected void backupbtn0_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void backupbtn_Click(object sender, EventArgs e)
        {
            StreamReader rdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = rdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            //imgupload.SaveAs(MapPath("images_upload/" + imgupload.FileName));



            xcon.Open();
            //SqlCommand xcmd = new SqlCommand("backup database korean_db_asp to disk = '" + (MapPath("backup/backup.bak")) + "' ", xcon);
            //SqlCommand xcmd = new SqlCommand("backup database korean_db_asp to disk = '" + (MapPath("backup/+'"+DateTime.Now.ToString()+"'+.bak")) + "' ", xcon);
            //SqlCommand xcmd = new SqlCommand("backup database korean_db_asp to disk = '" + (MapPath("backup/" +DateTime.Now.ToString("yyyyMMdd_hhss")+".bak")) + "' ", xcon);
            //SqlCommand xcmd = new SqlCommand("backup database korean_db_asp to disk = '" + (MapPath("backup/" + DateTime.Now.ToString("{0:yyyy-MM-dd}__{1}") + ".bak")) + "' ", xcon);
            //SqlCommand xcmd = new SqlCommand("backup database korean_db_asp to disk = '" + (MapPath("backup/" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".bak")) + "' ", xcon);
            SqlCommand xcmd = new SqlCommand("backup database korean_db_asp to disk = '" + (MapPath("backup/" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak")) + "' ", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

        }
    }
}
