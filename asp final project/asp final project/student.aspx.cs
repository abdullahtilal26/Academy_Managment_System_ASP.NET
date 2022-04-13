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
    public partial class student : System.Web.UI.Page
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

        protected void datecal_SelectionChanged(object sender, EventArgs e)
        {
            dattxt.Text = datecal.SelectedDate.ToShortDateString();
            viewlbl.Text = string.Empty;
            showdata();
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            StreamReader conrdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;


            if (imgupload.FileName=="")
            {
                xcon.Open();
                SqlCommand xcmd = new SqlCommand("insert into std_asp values('" + dattxt.Text + "','" + nametxt.Text + "','" + f_nametxt.Text + "','" + adrestxt.Text + "','NO Photo','" + qualitxt.Text + "','" + coursetxt.Text + "','" + advancetxt.Text + "','" + celltxt.Text + "','" + leavedattxt.Text + "','" + remarkstxt.Text + "')", xcon);
                xcmd.ExecuteNonQuery();
                xcmd.Dispose();
                xcon.Close();
            }

            else
            {
                xcon.Open();
                SqlCommand xcmd = new SqlCommand("insert into std_asp values('" + dattxt.Text + "','" + nametxt.Text + "','" + f_nametxt.Text + "','" + adrestxt.Text + "','" + imgupload.FileName.ToString() + "','" + qualitxt.Text + "','" + coursetxt.Text + "','" + advancetxt.Text + "','" + celltxt.Text + "','" + leavedattxt.Text + "','" + remarkstxt.Text + "')", xcon);
                xcmd.ExecuteNonQuery();
                xcmd.Dispose();
                xcon.Close();
                imgupload.SaveAs(MapPath("images_upload/" + imgupload.FileName));
            }
           
           

           
            
            Response.Redirect("student.aspx");
        }



        void showdata()
        {

            StreamReader conrdr = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from std_asp", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);


            viewlbl.Text += "<th>ID</th><th>Date</th><th>Name</th><th>F.Name</th><th>Address</th><th>Image</th><th>Qualification</th><th>Course</th><th>Advance</th><th>Cell</th><th>Leaving Date</th><th>Remarks</th>";

            for (int i = 0; i < xdata.Rows.Count; i++)
           {
                
                     string imageee;
                    imageee =  xdata.Rows[i].ItemArray[5].ToString();
                    

                viewlbl.Text += "<tr>";

             
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[0].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[1].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[2].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[3].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[4].ToString() + "</td>";

                 if (xdata.Rows[i].ItemArray[5].ToString()=="NO Photo")
                    {

                        viewlbl.Text += "<td>" +"no photo"+ "</td>" ;
                    }
                else
	{
         viewlbl.Text += "<td> <img src='images_upload/" + imageee + "' width= '70' height='65' /> </td>";                 
	}

                
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[6].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[7].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[8].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[9].ToString() + "</td>";
                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[10].ToString() + "</td>";

                viewlbl.Text += "<td>" + xdata.Rows[i].ItemArray[11].ToString() + "</td>";
                
               




                viewlbl.Text += "</tr>";
            }

        }

        //protected void searchbtn_Click(object sender, EventArgs e)
        //{
           
        //}

        protected void searchbtn_Click1(object sender, EventArgs e)
        {
            StreamReader conrdr2 = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr2.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;



            SqlDataAdapter xadapt2 = new SqlDataAdapter("select * from  std_asp where(Name='" + searchnametxt.Text + "' and F_name='"+searchf_nametxt.Text+"')", xcon);
            DataTable xdata2 = new DataTable();
            xadapt2.Fill(xdata2);


            imgshowlbl.Text = "";




            idtxt2.Text = xdata2.Rows[0].ItemArray[0].ToString();
            dattxt2.Text = xdata2.Rows[0].ItemArray[1].ToString();
            nametxt2.Text = xdata2.Rows[0].ItemArray[2].ToString();
            f_nametxt2.Text = xdata2.Rows[0].ItemArray[3].ToString();
            adresstxt2.Text = xdata2.Rows[0].ItemArray[4].ToString();



            if (xdata2.Rows[0].ItemArray[5].ToString() == "NO Photo")
            {

                imgshowlbl.Text = "No Photo";
            }
            else
            {
                imgshowlbl.Text += " <img src='images_upload/" + xdata2.Rows[0].ItemArray[5] + "' width= '70' height='22' /> ";
            }


            qualitxt2.Text = xdata2.Rows[0].ItemArray[6].ToString();
            coursetxt2.Text = xdata2.Rows[0].ItemArray[7].ToString();
            advancetxt2.Text = xdata2.Rows[0].ItemArray[8].ToString();
            celtxt2.Text = xdata2.Rows[0].ItemArray[9].ToString();
            leavingdattxt2.Text = xdata2.Rows[0].ItemArray[10].ToString();
            remarkstxt2.Text = xdata2.Rows[0].ItemArray[11].ToString();



            viewlbl.Text = string.Empty;
            showdata();
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            string idd, datt, namee, f_namee, adresss, imagee, qualii, coursee, advancee, celll, leaving_datt, remarkss;

                idd=idtxt2.Text;
                datt= dattxt2.Text;
                namee=nametxt2.Text;
                f_namee=f_nametxt2.Text;
                adresss= adresstxt2.Text;
                imagee = imgupld2.FileName;
               //imagee=imgshowlbl.Text
                qualii=qualitxt2.Text;
                coursee= coursetxt2.Text;
                advancee=advancetxt2.Text;
                celll=celtxt2.Text;
                leaving_datt=leavingdattxt2.Text ;
                remarkss = remarkstxt2.Text;



                StreamReader conrdr3 = new StreamReader(MapPath("connection/conn.txt"));
                string con = conrdr3.ReadLine();
                xcon = new SqlConnection();
                xcon.ConnectionString = con;




            if (imgupld2.FileName=="")
	{
        xcon.Open();
        SqlCommand xcmd2 = new SqlCommand("update std_asp set Dat='" + datt + "',Name='" + namee + "',F_name='" + f_namee + "', Addres='" + adresss + "', Quali='" + qualii + "', Course='" + coursee + "', Advnce ='" + advancee + "',Cell ='" + celll + "',leav_dat='" + leaving_datt + "', Remarks='" + remarkss + "' where Id=" + idd + "", xcon);
        xcmd2.ExecuteNonQuery();
        xcmd2.Dispose();
        xcon.Close();
	}


            else
	{

        xcon.Open();
        SqlCommand xcmd2 = new SqlCommand("update std_asp set Dat='" + datt + "',Name='" + namee + "',F_name='" + f_namee + "', Addres='" + adresss + "', Img='"+imagee+"', Quali='" + qualii + "', Course='" + coursee + "', Advnce ='" + advancee + "',Cell ='" + celll + "',leav_dat='" + leaving_datt + "', Remarks='" + remarkss + "' where Id=" + idd + "", xcon);
        xcmd2.ExecuteNonQuery();
        xcmd2.Dispose();
        xcon.Close();      
        imgupld2.SaveAs(MapPath("images_upload/" + imgupld2.FileName));
	}


         
        Response.Redirect("student.aspx");                 

 


    }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {

            StreamReader conrdr3 = new StreamReader(MapPath("connection/conn.txt"));
            string con = conrdr3.ReadLine();
            xcon = new SqlConnection();
            xcon.ConnectionString = con;

            xcon.Open();
            SqlCommand xcmd3 = new SqlCommand("delete from std_asp where Id="+idtxt2.Text+"", xcon);
            xcmd3.ExecuteNonQuery();
            xcmd3.Dispose();
            xcon.Close();

            Response.Redirect("student.aspx");   
      
        }

        protected void refreshbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("student.aspx");   
        }

        protected void searchnametxt_TextChanged(object sender, EventArgs e)
        {

                               

           
        }

        protected void dattxt_TextChanged(object sender, EventArgs e)
        {

        }
    
    
    
    
    }
}