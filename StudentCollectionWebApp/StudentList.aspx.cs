using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentCollectionWebApp
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("Select * from tbl_Studentinfo", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                    
                }
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
            {
            
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                
                using (SqlConnection con = new SqlConnection(CS))
                {
                    string Command = "Select * from tbl_Studentinfo where StudentId =" + SearchTextBox.Text + " ";
                    SqlCommand cmd = new SqlCommand(Command, con);
                    con.Open();
                    
                    
                    try
                    {
                        GridView1.DataSource = cmd.ExecuteReader();
                        GridView1.DataBind();
                    }
                    catch
                    {
                        Response.Write("<strong>" + "Please Enter Student ID Number !" + "</strong>");
                    }
                    
                    if (GridView1.Enabled==true)
                    {
                        Response.Write("a");
                    }
                    else
                    {
                        Response.Write("hi");
                    }
                    con.Close();
                }
            
            }
    }
}