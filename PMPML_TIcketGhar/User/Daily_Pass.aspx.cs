using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class Daily_Pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //    // Retrieve form values
            //    string name = txtName.Text.Trim();
            //    string mobile = txtMobile.Text.Trim();
            //    string aadhar = txtAadhar.Text.Trim();
            //    string gender = ddlGender.SelectedValue;

            //    //// Basic validation
            //    //if (string.IsNullOrWhiteSpace(name) ||
            //    //    string.IsNullOrWhiteSpace(mobile) ||
            //    //    string.IsNullOrWhiteSpace(aadhar) ||
            //    //    string.IsNullOrWhiteSpace(gender))
            //    //{
            //    //    // Display alert for missing fields
            //    //    Response.Write("<script>alert('All fields are required.');</script>");
            //    //    return;
            //    //}

            //    //// Validate mobile number format (10 digits)
            //    //if (!System.Text.RegularExpressions.Regex.IsMatch(mobile, @"^\d{10}$"))
            //    //{
            //    //    // Display alert for invalid mobile number
            //    //    Response.Write("<script>alert('Invalid mobile number. It must be 10 digits.');</script>");
            //    //    return;
            //    //}

            //    //// Validate Aadhar number format (12 digits)
            //    //if (!System.Text.RegularExpressions.Regex.IsMatch(aadhar, @"^\d{12}$"))
            //    //{
            //    //    // Display alert for invalid Aadhar number
            //    //    Response.Write("<script>alert('Invalid Aadhar number. It must be 12 digits.');</script>");
            //    //    return;
            //    //}

            //    // Connection string from Web.config
            //    string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;

            //    // SQL query to insert data
            //    string query = "INSERT INTO regularPass (FullName, Mobile, AadharNumber, Gender) VALUES (@FullName, @Mobile, @AadharNumber, @Gender)";

            //    try
            //    {
            //        using (SqlConnection connection = new SqlConnection(connectionString))
            //        {
            //            using (SqlCommand command = new SqlCommand(query, connection))
            //            {
            //                // Add parameters to the SQL query
            //                command.Parameters.AddWithValue("@FullName", name);
            //                command.Parameters.AddWithValue("@Mobile", mobile);
            //                command.Parameters.AddWithValue("@AadharNumber", aadhar);
            //                command.Parameters.AddWithValue("@Gender", gender);

            //                // Open connection, execute query, and close connection
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //                connection.Close();
            //            }
            //        }

            //        // Display success message
            //        //Response.Write("<script>alert('Registration successful.');</script>");
            //        Response.Redirect("Payment.aspx");
            //    }
            //    catch (Exception ex)
            //    {
            //        // Log and display error message
            //        Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
            //        //Response.Redirect("Payment.aspx");
            //    }


            // Get the form data
            string name = Request.Form["name"];
            string mobile = Request.Form["mobile"];
            string aadhar = Request.Form["aadhar"];
            string gender = Request.Form["gender"];
            Session["AadharNumber"] = aadhar;
            int dailyTicketPrice = 40*100;
            Session["PaymentPrice"] = dailyTicketPrice;
            string page = "dailyPage";
            Session["Sendmessage"] = page;

            // Insert the form data into the database
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO regularPass (FullName, Mobile, AadharNumber, Gender) VALUES (@FullName, @Mobile, @AadharNumber, @Gender)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", name);
                        command.Parameters.AddWithValue("@Mobile", mobile);
                        command.Parameters.AddWithValue("@AadharNumber", aadhar);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.ExecuteNonQuery();
                    }
                }

                // Display a success message if the data is inserted successfully
                // Show success message
                Response.Write("<script>alert('Registration successful.'); window.location.href='Payment.aspx';</script>");

            }
            catch (Exception ex)
            {
                // Display an error message if there is an error inserting the data
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
              
            }

        }
        }
    }
