using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentCollectionWebApp
{
    public partial class StudentInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_Studentinfo(StudentId, StudentName, FatherName, MotherName, Email, phone, Gender, BloodGroup, SchoolName, CollegeName, UniversityName, Nationality, Religion) values(@StudentId, @StudentName, @FatherName, @MotherName, @Email, @phone, @Gender, @BloodGroup, @SchoolName, @CollegeName, @UniversityName, @Nationality, @Religion)", con);
                //SqlCommand cmd = new SqlCommand("insert into tbl_Studentinfo(StudentId, StudentName, FatherName, MotherName, Email, phone, Gender, BloodGroup, SchoolName, CollegeName, UniversityName, Nationality, Religion) values('" + IdTextBox.Text + "','" + YourNameTextBox.Text + "','" + FatherNameTextBox.Text + "','" + MotherNameTextBox.Text + "','" + EmailTextBox.Text + "','" + PhoneTextBox.Text + "','" + BloodGroupTextBox.Text + "','" + SchoolNameTextBox.Text + "','" + CollegeNameTextBox.Text + "','" + UniNameTextBox.Text + "','" + NationalityTextBox.Text + "','" + ReligionTextBox.Text + "')", con);
                cmd.Parameters.AddWithValue("@StudentId", IdTextBox.Text);
                cmd.Parameters.AddWithValue("@StudentName", YourNameTextBox.Text);
                cmd.Parameters.AddWithValue("@FatherName", FatherNameTextBox.Text);
                cmd.Parameters.AddWithValue("@MotherName", MotherNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderCheckBoxList.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@BloodGroup", BloodGroupTextBox.Text);
                cmd.Parameters.AddWithValue("@SchoolName", SchoolNameTextBox.Text);
                cmd.Parameters.AddWithValue("@CollegeName", CollegeNameTextBox.Text);
                cmd.Parameters.AddWithValue("@UniversityName", UniNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Nationality", NationalityTextBox.Text);
                cmd.Parameters.AddWithValue("@Religion", ReligionTextBox.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                //cmd.CommandText = "Insert into tbl_Studentinfo values(5, 'Calculator', 150, 230)";
                //int totalRowAffected = cmd.ExecuteNonQuery();
                //Response.Write("Total Rows Inserted = " + totalRowAffected.ToString());

                IdTextBox.Text = "";
                YourNameTextBox.Text = "";
                FatherNameTextBox.Text = "";
                MotherNameTextBox.Text = "";
                EmailTextBox.Text = "";
                PhoneTextBox.Text = "";
                GenderCheckBoxList.Text = "";
                BloodGroupTextBox.Text = "";
                SchoolNameTextBox.Text = "";
                CollegeNameTextBox.Text = "";
                UniNameTextBox.Text = "";
                NationalityTextBox.Text = "";
                ReligionTextBox.Text = "";
            }
        }
    }
}