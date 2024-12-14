using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnExample_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.indiacustomercare.com/pune-mahanaga-parivahan-mahamandal-pmpml-no-020-24-54-54-54");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the input values
            string fromLocation = Request.Form["inputField1"]; // From location
            string toLocation = Request.Form["inputField2"]; // To location
            int travelers = int.Parse(Request.Form["travelers"]); // Number of travelers
            string aadharNumber = Request.Form["numericInput"]; // Aadhar number

            // Store the input values in session
            Session["FromLocation"] = fromLocation;
            Session["ToLocation"] = toLocation;
            Session["Travelers"] = travelers;
            Session["AadharNumber"] = aadharNumber;

            // Add data to the RegularTicket table in the SQL database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO RegularTicket (FromLocation, ToLocation, NoOfTraveler, AadharNumber) VALUES (@FromLocation, @ToLocation, @NoOfTraveler, @AadharNumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FromLocation", fromLocation);
                    command.Parameters.AddWithValue("@ToLocation", toLocation);
                    command.Parameters.AddWithValue("@NoOfTraveler", travelers);
                    command.Parameters.AddWithValue("@AadharNumber", aadharNumber);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Data added to RegularTicket table successfully.');</ script >");
                    }
                    else
                    {
                        Response.Write("<script>alert('Error adding data to RegularTicket table.'); </ script >");
                    }
                }
            }

            // Redirect to the next page
            Response.Redirect("respo_busData.aspx");
        }
    }
}