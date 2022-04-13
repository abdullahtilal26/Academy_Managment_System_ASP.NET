using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace asp_final_project
{
    public partial class admin : System.Web.UI.Page
    {
       
        SqlConnection xcon ;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("default.aspx");
            }

            //else
            //{
            //    Response.Redirect("admin.aspx");
            //}

            viewlbl.Text = "";

               
                                    
            
        }

        protected void connbtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(MapPath("connection/conn.txt")))
            {
                File.Delete(MapPath("connection/conn.txt"));
            } 
            
          
            StreamWriter conwrt = new StreamWriter(MapPath("connection/conn.txt"), true);
            conwrt.WriteLine(conntxt.Text.ToString());
            conwrt.Flush();
            conwrt.Dispose();

            Response.Write("Connected");
        }

        protected void createuserrbtn_Click(object sender, EventArgs e)
        {
            
            StreamReader rdr = new StreamReader(MapPath("connection/conn.txt"));
            string con =rdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con ;


            xcon.Open();
            SqlCommand xcmd = new SqlCommand("insert into userr_asp values('" + userrnametxt.Text + "','" + pwdtxt.Text + "')", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            Response.Write("User Created");

            Response.Redirect("admin.aspx");
         
	
           
            

            
        }

        protected void selectbtn_Click(object sender, EventArgs e)
        {

        }

        protected void restorebtn_Click(object sender, EventArgs e)
        {


            //StreamReader rdr = new StreamReader(MapPath("connection/connection.txt"));
            //string con = rdr.ReadLine();
            //xcon = new SqlConnection();
            //xcon.ConnectionString = con;

            //xcon.Open();
            //SqlCommand xcmd = new SqlCommand("restore database korean_db_asp from disk = '" + (MapPath("backup/backup1.bak")) + "' ", xcon);
            //xcmd.ExecuteNonQuery();
            //xcmd.Dispose();
            //xcon.Close();

            //Response.Write("Restored");

            //Response.Redirect("admin.aspx");
        }


        void show()
        {
            StreamReader rdr2 = new StreamReader(MapPath("connection/conn.txt"));
            string con2 = rdr2.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con2;

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from userr_asp", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            viewlbl.Text += "<th>Id</th><th>User Name</th><th>Passwod</th>";
            for (int i = 0; i < xdata.Rows.Count; i++)
            {

                viewlbl.Text += "<tr>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[0].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[1].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[2].ToString() + "</td>";
                viewlbl.Text += "</tr>";


            }
        }

        protected void showbtn_Click(object sender, EventArgs e)
        {

            show();
            //hidebtn.Visible = true;
        }


        protected void hidebtn_Click(object sender, EventArgs e)
        {
            
            
            //hidebtn.Visible = false;
        }

        protected void userrnametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void pwdtxt_TextChanged(object sender, EventArgs e)
        {
            
            
	
        }

        protected void searchbtn_Click(object sender, EventArgs e)
        {

            StreamReader rdr3 = new StreamReader(MapPath("connection/conn.txt"));
            string con2 = rdr3.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con2;

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from userr_asp where Id="+searchtxt.Text+"", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);


            idtxt2.Text=xdata.Rows[0].ItemArray[0].ToString();
            usertxt2.Text=xdata.Rows[0].ItemArray[1].ToString();
            pwdtxt2.Text=xdata.Rows[0].ItemArray[2].ToString();




        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            StreamReader rdr4 = new StreamReader(MapPath("connection/conn.txt"));
            string con3 = rdr4.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con3;

            xcon.Open();
            SqlCommand xcmd2 = new SqlCommand("update userr_asp set Name='"+usertxt2.Text+"',Pwd='"+pwdtxt2.Text+"' where Id="+idtxt2.Text+" ", xcon);
            xcmd2.ExecuteNonQuery();
            xcmd2.Dispose();
            xcon.Close();

            Response.Redirect("admin.aspx");
        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            StreamReader rdr5 = new StreamReader(MapPath("connection/conn.txt"));
            string con3 = rdr5.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con3;


            xcon.Open();
            SqlCommand xcmd3 = new SqlCommand("delete from userr_asp where Id="+idtxt2.Text+"", xcon);
            xcmd3.ExecuteNonQuery();
            xcmd3.Dispose();
            xcon.Close();

            Response.Redirect("admin.aspx");
                 
        }

        protected void refreshbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }

        protected void restorebtn_Click1(object sender, EventArgs e)
        {
            
            xcon = new SqlConnection();
            xcon.ConnectionString = restore_con_txt.Text;

            //imgupload.SaveAs(MapPath("images_upload/" + imgupload.FileName));

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("restore database korean_db_asp from disk = '"+(MapPath("backup/"+selectupld.FileName)) +"' ", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            Response.Write("Restored");

            Response.Redirect("admin.aspx");
        }

    }
}