using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace asp_final_project
{
    public partial class programms : System.Web.UI.Page
    {
        SqlConnection xcon;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Default.aspx");
              
            }
            
            viewlbl.Text = "";
            showdata();
            
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            StreamReader conrdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("insert into Programs_asp values ('"+datetxt.Text+"','"+coursetxt.Text+"','"+durationtxt.Text+"','"+monfeetxt.Text+"','"+addmisiontxt.Text+"','"+teachertxt.Text+"','"+timingstxt.Text+"')", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            Response.Write("Registered");

            Response.Redirect("programms.aspx");
            
        }

        protected void datecal_SelectionChanged(object sender, EventArgs e)
        {
            datetxt.Text = datecal.SelectedDate.ToShortDateString();
            viewlbl.Text = string.Empty;
            showdata();
            
        }


        void showdata()
        {


            StreamReader conrdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from Programs_asp", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            viewlbl.Text += "<th>ID</th><th>Date</th><th>Course</th><th>Duration</th><th>Monthly Fee</th><th>Admission Fee</th><th>Teacher</th><th>Timings</th>";

            for (int i = 0; i < xdata.Rows.Count; i++)
            {


                viewlbl.Text += "<tr>";

                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[0].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[1].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[2].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[3].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[4].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[5].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[6].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[7].ToString() + "</td>";




                viewlbl.Text += "</tr>";
            }

        }


        protected void searchbtn_Click(object sender, EventArgs e)
        {
           
          
            StreamReader conrdr2 = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr2.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            SqlDataAdapter xadapt2 = new SqlDataAdapter("select * from Programs_asp where Course='" + searchtxt.Text + "'", xcon);
            DataTable xdata2 = new DataTable();
            xadapt2.Fill(xdata2);

           id2.Text=xdata2.Rows[0].ItemArray[0].ToString();
           datetxt2.Text=xdata2.Rows[0].ItemArray[1].ToString();
           coursetxt2.Text=xdata2.Rows[0].ItemArray[2].ToString();
           durationtxt2.Text=xdata2.Rows[0].ItemArray[3].ToString();
           monfeetxt2.Text=xdata2.Rows[0].ItemArray[4].ToString();
           addfetxt2.Text =xdata2.Rows[0].ItemArray[5].ToString();
           teachertxt2.Text=xdata2.Rows[0].ItemArray[6].ToString();
           timingtxt2.Text=xdata2.Rows[0].ItemArray[7].ToString();

           viewlbl.Text = "";
            //viewlbl.Text = string.Empty;
           showdata();
            
        }

        protected void Updatebtn_Click(object sender, EventArgs e)
        {
            string idd, dat, cours, dration, mon_fe, add_fe, teachr, timming;

                idd = id2.Text;
                dat = datetxt2.Text;
                cours = coursetxt2.Text;
                dration = durationtxt2.Text;
                mon_fe = monfeetxt2.Text;
                add_fe = addfetxt2.Text ;
                teachr = teachertxt2.Text;
                timming = timingtxt2.Text;



                StreamReader conrdr3 = new StreamReader(MapPath("connection/conn.txt"));
                string con = conrdr3.ReadLine();
                xcon = new SqlConnection();
                xcon.ConnectionString = con;

                xcon.Open();
                SqlCommand xcmd3 = new SqlCommand("update Programs_asp  set Dat='"+dat+"',Course ='"+cours+"',Duration='"+dration+"',Mon_fee='"+mon_fe+"', Add_fee ='"+add_fe+"',Teacher ='"+teachr+"',Timing ='"+timming+"' where id=" + idd + " ", xcon);
                xcmd3.ExecuteNonQuery();
                xcmd3.Dispose();
                xcon.Close();

                Response.Write("Updated");

                Response.Redirect("programms.aspx");
                //viewlbl.Text = string.Empty;
                //showdata();

        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            StreamReader conrdr4 = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr4.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            xcon.Open();
            SqlCommand xcmd4 = new SqlCommand("delete from Programs_asp where id="+id2.Text+" ", xcon);
            xcmd4.ExecuteNonQuery();
            xcmd4.Dispose();
            xcon.Close();

            Response.Write("Deleted");

            Response.Redirect("programms.aspx");
            //viewlbl.Text = string.Empty;
            //showdata();
        }

        protected void Refresbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("programms.aspx");
        }

        protected void printbtn_Click(object sender, EventArgs e)
        {
            
        }



       
        

            
             


    }

}