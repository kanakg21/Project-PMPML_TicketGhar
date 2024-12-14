using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class Monthly_Bus_Pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve form values
            string name = txtName.Text;
            string mobile = txtMobile.Text;
            string aadhar = txtAadhar.Text;
            string gender = ddlGender.SelectedValue;
            string verificationCode = txtVerificationCode.Text;  // Updated field name

            // Connection string from web.config
            string connectionString = ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;

            // SQL query to insert data into the table
            string query = "INSERT INTO monthlyPassRegistration (Name, Mobile, AadharNumber, Gender, VerificationCode) VALUES (@Name, @Mobile, @AadharNumber, @Gender, @VerificationCode)";

            // Create a new SqlConnection and SqlCommand
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);
                    cmd.Parameters.AddWithValue("@AadharNumber", aadhar);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);  // Updated parameter name

                    // Open the connection
                    conn.Open();

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        // Optionally, display a success message
                        Response.Write("Registration successful!");
                    }
                    else
                    {
                        // Optionally, display an error message
                        Response.Write("Registration failed. Please try again.");
                    }
                    conn.Close();
                }
            }
        }
    }
}