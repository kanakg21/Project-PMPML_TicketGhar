using Razorpay.Api;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio.Types;
using Twilio;

namespace PMPML_TIcketGhar.User
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            

            // Retrieve form values
            string name = txtName.Text;
            string mobile = txtMobile.Text;
            string aadhar = txtAadhar.Text;
            string gender = ddlGender.SelectedValue;
            string verificationCode = txtVerificationCode.Text;
            string prn = (string)Session["prn"];
            PrnGeneration(prn);

            // Connection string from Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;

            // Insert data into database
            string query = "UPDATE monthlyPassRegistration SET FullName = @FullName,Mobile = @Mobile,AadharNumber = @AadharNumber,Gender = @Gender,PRN = @PRN WHERE VerificationCode = @VerificationCode";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", name);
                        command.Parameters.AddWithValue("@Mobile", mobile);
                        command.Parameters.AddWithValue("@AadharNumber", aadhar);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@VerificationCode", verificationCode);
                        command.Parameters.AddWithValue("@PRN", prn);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                Response.Write("<script>alert('Registration successful.'); window.location.href='index.aspx';</script>");
            }
            catch (Exception ex)
            {
                // Log the exception and show an error message
                Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
            }
        }
        private string PrnGeneration(string prn)
        {
            //string phnumber= (string)Session["phoneNumber"];
            // Ensure TLS 1.2 is used
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string accountSid = System.Configuration.ConfigurationManager.AppSettings["TwilioAccountSid"];
            string authToken = System.Configuration.ConfigurationManager.AppSettings["TwilioAuthToken"];
            string twilioPhoneNumber = System.Configuration.ConfigurationManager.AppSettings["TwilioPhoneNumber"];
            string toPhoneNumber = "+918446415121"; // Replace with the recipient's phone number

            // Generate a 5-digit PNR number

            string messageBody = $"Welcome to PMPML TicketGhar Your PNR number is: {prn}";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toPhoneNumber),
                from: new PhoneNumber(twilioPhoneNumber),
                body: messageBody
            );
            return prn;
        }
    }
}