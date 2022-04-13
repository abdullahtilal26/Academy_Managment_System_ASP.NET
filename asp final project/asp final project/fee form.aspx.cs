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
    public partial class fee_form : System.Web.UI.Page
    {
        SqlConnection xcon;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void serachbtn_Click(object sender, EventArgs e)
        {
            StreamReader conrdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;



            SqlDataAdapter xadapt = new SqlDataAdapter("select * from  std_asp where Id="+searchtxt.Text+" ", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            std_nametxt.Text = xdata.Rows[0].ItemArray[2].ToString();
            father_name.Text = xdata.Rows[0].ItemArray[3].ToString();
            coursetxt.Text = xdata.Rows[0].ItemArray[7].ToString();
            advancetxt.Text=xdata.Rows[0].ItemArray[8].ToString();
        }

        protected void datetxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void dat_calender_SelectionChanged(object sender, EventArgs e)
        {
            datetxt.Text = dat_calender.SelectedDate.ToShortDateString();
        }

        protected void paybtn_Click(object sender, EventArgs e)
        {
            StreamReader conrdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("insert into fee values("+searchtxt.Text+",'"+datetxt.Text+"','"+std_nametxt.Text+"','"+father_name.Text+"','"+coursetxt.Text+"','"+advancetxt.Text+"',"+amounttxt.Text+")", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

        }
    }
}