using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.Dashboard
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private string connectionString = "Data Source=.;Initial Catalog=PMPML_TicketGhar_DB;Integrated Security=True;Encrypt=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDashboardData();
            }
        }

        private void LoadDashboardData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Fetch total tickets for today
                SqlCommand cmdTotalTickets = new SqlCommand("SELECT COUNT(*) FROM regularTicket WHERE CAST(GenerationTime AS DATE) = CAST(GETDATE() AS DATE)", conn);
                lblTotalTickets.Text = "Total Tickets: " + cmdTotalTickets.ExecuteScalar().ToString();

                // Fetch total revenue for today
                SqlCommand cmdTotalRevenue = new SqlCommand("SELECT SUM(Amount) FROM payment WHERE CAST(PaymentDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                lblTotalRevenue.Text = "Total Revenue: " + cmdTotalRevenue.ExecuteScalar().ToString() + " rs";

                // Fetch total penalty for today
                SqlCommand cmdTotalPenalty = new SqlCommand("SELECT SUM(Amount) FROM penalty WHERE CAST(PenaltyDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                lblTotalPenalty.Text = "Total Penalty: " + cmdTotalPenalty.ExecuteScalar().ToString() + " rs";

                // Fetch daily pass granted today
                SqlCommand cmdDailyPass = new SqlCommand("SELECT COUNT(*) FROM regularPass WHERE CAST(GenerationTime AS DATE) = CAST(GETDATE() AS DATE)", conn);
                lblDailyPass.Text = "Daily Passes: " + cmdDailyPass.ExecuteScalar().ToString();

                // Fetch monthly pass granted today
                SqlCommand cmdMonthlyPass = new SqlCommand("SELECT COUNT(*) FROM monthlyPassRegistration WHERE CAST(RegistrationDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                lblMonthlyPass.Text = "Monthly Passes: " + cmdMonthlyPass.ExecuteScalar().ToString();

                // Fetch yearly pass granted today
                SqlCommand cmdYearlyPass = new SqlCommand("SELECT COUNT(*) FROM YearlyPass WHERE CAST(GenerationTime AS DATE) = CAST(GETDATE() AS DATE)", conn);
                lblYearlyPass.Text = "Yearly Passes: " + cmdYearlyPass.ExecuteScalar().ToString();
            }
        }
    }
}