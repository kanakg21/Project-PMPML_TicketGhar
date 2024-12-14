    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections;

namespace PMPML_TIcketGhar.User
{
    public partial class respo_busData : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindSearchDetails();
            }
        }

        private void bindSearchDetails()
        {
            //fetchimg data from session object
            string fromLocation = (string)Session["FromLocation"];
            string toLocation = (string)Session["ToLocation"];
            int travelers = (int)Session["Travelers"];
            string aadharNumber = (string)Session["AadharNumber"];
            string page = "normalTicket";
            Session["Sendmessage"] = page;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    b.BusNumber,
                    b.FromLocation,
                    b.ToLocation,
                    b.TravelTime,
                    b.TicketPrice
                FROM 
                    Busses b
                WHERE 
                    b.FromLocation = @FromLocation
                    AND b.ToLocation = @ToLocation";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FromLocation", fromLocation);
                cmd.Parameters.AddWithValue("@ToLocation", toLocation);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Initially hide all bus info divs
                bus1Panel.Visible = false;
                bus2Panel.Visible = false;
                bus3Panel.Visible = false;
                bus4Panel.Visible = false;
                bus5Panel.Visible = false;


                while (reader.Read())
                {
                    string busNumber = reader["BusNumber"].ToString();
                    Session["busNumber"] = busNumber;
                    switch (busNumber)
                    {
                        case "276":
                            //bus1.Visible = true;
                            bus1Panel.Visible = true;
                            int dailyTicketPrice = 15 * 100 * travelers;
                            Session["PaymentPrice"] = dailyTicketPrice;
                            break;
                        case "2A UP":
                            //bus2.Visible = true;
                            bus2Panel.Visible = true;
                            dailyTicketPrice = 25 * 100 * travelers;
                            Session["PaymentPrice"] = dailyTicketPrice;

                            break;
                        case "58 UP":
                            //bus3.Visible = true;
                            bus3Panel.Visible = true;
                            dailyTicketPrice = 10 * 100 * travelers;
                            Session["PaymentPrice"] = dailyTicketPrice;

                            break;
                        case "119 DOWN":
                            //bus4.Visible = true;
                            bus4Panel.Visible = true;
                            dailyTicketPrice = 25 * 100;
                            Session["PaymentPrice"] = dailyTicketPrice;

                            break;
                        case "2A DOWN":
                            //bus5.Visible = true;
                            bus5Panel.Visible = true;
                            dailyTicketPrice = 17 * 100 * travelers;
                            Session["PaymentPrice"] = dailyTicketPrice;

                            break;
                    }
                }



            }




        }


        protected void btnPayNow_Click1(object sender, EventArgs e)
        {
            busNumberdb();
            string aadharNumber = Session["AadharNumber"] as string;
            //string mobile = Request.Form["mobile-number"];
            string mobile = txtMobileNumber.Text;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "UPDATE regularTicket SET Mobile = @Mobile WHERE AadharNumber = " + @aadharNumber;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Mobile", mobile);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
                Response.Redirect("Payment.aspx");
            }

        }
        private void busNumberdb()
        {
            string busNumber = Session["busNumber"].ToString();
            string aadharNumber = Session["AadharNumber"] as string;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "UPDATE regularTicket SET BusNumber = @BusNumber WHERE AadharNumber = " + @aadharNumber;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@BusNumber", busNumber);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }
    }
}