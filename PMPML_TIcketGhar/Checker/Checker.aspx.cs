using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.Checker
{
    public partial class Checker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            string prn = txtPRN.Text;
            string last4Aadhar = txtAadhar.Text;
            string connectionString = "Data Source=.;Initial Catalog=PMPML_TicketGhar_DB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check for regular tickets
                string query = "SELECT FromLocation, ToLocation, AadharNumber FROM regularTicket WHERE PRN = @PRN OR AadharNumber LIKE '%' + @Last4Aadhar + '%'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PRN", prn);
                command.Parameters.AddWithValue("@Last4Aadhar", last4Aadhar);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string fromLocation = reader["FromLocation"].ToString();
                    string toLocation = reader["ToLocation"].ToString();
                    string aadharNumber = reader["AadharNumber"].ToString();
                    reader.Close();

                    string paymentStatus = GetPaymentStatus(connection, aadharNumber);
                    lblResult.Text = $"From: {fromLocation}<br />To: {toLocation}<br />Payment Status: {paymentStatus}";
                    return;
                }
                reader.Close();

                // Check for monthly passes
                query = "SELECT FromLocation, ToLocation, AadharNumber FROM MonthlyPass WHERE PRN = @PRN OR AadharNumber LIKE '%' + @Last4Aadhar + '%'";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PRN", prn);
                command.Parameters.AddWithValue("@Last4Aadhar", last4Aadhar);

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string fromLocation = reader["FromLocation"].ToString();
                    string toLocation = reader["ToLocation"].ToString();
                    string aadharNumber = reader["AadharNumber"].ToString();
                    reader.Close();

                    string paymentStatus = GetPaymentStatus(connection, aadharNumber);
                    lblResult.Text = $"Monthly Pass Holder<br />From: {fromLocation}<br />To: {toLocation}<br />Payment Status: {paymentStatus}";
                    return;
                }
                reader.Close();

                // Check for regular passes
                query = "SELECT AadharNumber FROM regularPass WHERE PRN = @PRN OR AadharNumber LIKE '%' + @Last4Aadhar + '%'";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PRN", prn);
                command.Parameters.AddWithValue("@Last4Aadhar", last4Aadhar);

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string aadharNumber = reader["AadharNumber"].ToString();
                    reader.Close();

                    string paymentStatus = GetPaymentStatus(connection, aadharNumber);
                    lblResult.Text = $"Regular Pass Holder<br />Payment Status: {paymentStatus}";
                    return;
                }
                reader.Close();

                // Check for yearly passes
                query = "SELECT FromLocation, ToLocation, AadharNumber FROM YearlyPass WHERE PRN = @PRN OR AadharNumber LIKE '%' + @Last4Aadhar + '%'";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PRN", prn);
                command.Parameters.AddWithValue("@Last4Aadhar", last4Aadhar);

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string fromLocation = reader["FromLocation"].ToString();
                    string toLocation = reader["ToLocation"].ToString();
                    string aadharNumber = reader["AadharNumber"].ToString();
                    reader.Close();

                    string paymentStatus = GetPaymentStatus(connection, aadharNumber);
                    lblResult.Text = $"Yearly Pass Holder<br />From: {fromLocation}<br />To: {toLocation}<br />Payment Status: {paymentStatus}";
                    return;
                }
                reader.Close();

                // Check for student passes
                query = "SELECT FromLocation, ToLocation, AadharNumber FROM StudentPass WHERE AadharNumber LIKE '%' + @Last4Aadhar + '%'";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Last4Aadhar", last4Aadhar);

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string fromLocation = reader["FromLocation"].ToString();
                    string toLocation = reader["ToLocation"].ToString();
                    string aadharNumber = reader["AadharNumber"].ToString();
                    reader.Close();

                    string paymentStatus = GetPaymentStatus(connection, aadharNumber);
                    lblResult.Text = $"Student Pass Holder<br />From: {fromLocation}<br />To: {toLocation}<br />Payment Status: {paymentStatus}";
                    return;
                }
                reader.Close();

                lblResult.Text = "Ticket or Pass not found or invalid.";
            }

            
        }
        private string GetPaymentStatus(SqlConnection connection, string aadharNumber)
        {
            string query = "SELECT TOP 1 Amount FROM payment WHERE AadharNumber = @AadharNumber ORDER BY PaymentDate DESC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AadharNumber", aadharNumber);

            object result = command.ExecuteScalar();
            if (result != null && Convert.ToDecimal(result) > 0)
            {
                return "Valid";
            }
            return "Not Valid";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int dailyTicketPrice = 500 * 100;
            Session["PaymentPrice"] = dailyTicketPrice;
            Response.Redirect("../user/Payment.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checker.aspx");
        }
    }
}