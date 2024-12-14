using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Get the form data
            string fullName = Request.Form["inputField"];
            string mobileNumber = Request.Form["mobileNumber"];
            string email = Request.Form["email"];
            string aadhaarNumber = Request.Form["numericInput"];
            string gender = Request.Form["gender"];

            // Validate the form data
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(mobileNumber) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(aadhaarNumber) ||
                string.IsNullOrEmpty(gender))
            {
                // Display an error message if any field is empty
                Response.Write("Please fill in all the fields.");
                return;
            }

            // Insert the form data into the database
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [aadharRegister] (FullName, Mobile, Email, AadharNumber, Gender) VALUES (@FullName, @Mobile, @Email, @AadharNumber, @Gender)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Mobile", mobileNumber);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@AadharNumber", aadhaarNumber);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.ExecuteNonQuery();
                    }
                }

                // Display a success message if the data is inserted successfully
                //Response.Write("<script>alert('Registration successful.');</script>");
                // Show success message
                Response.Write("<script>alert('Registration successful.'); window.location.href='index.aspx';</script>");

                //Response.Redirect("Payment.aspx");
            }
            catch (Exception ex)
            {
                // Display an error message if there is an error inserting the data
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}