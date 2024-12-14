using Razorpay.Api;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Reflection;
using System.Drawing;

namespace PMPML_TIcketGhar.User
{
    public partial class Charge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Visible = false;
            string paymentId = Request.Form["razorpay_payment_id"];
            string orderId = Request.Form["razorpay_order_id"];
            string signature = Request.Form["razorpay_signature"];

            // Ensure these values are not null or empty
            if (string.IsNullOrEmpty(paymentId) || string.IsNullOrEmpty(orderId) || string.IsNullOrEmpty(signature))
            {
                SetMessage("Invalid payment details. Payment failed.", "error");
                return;
            }

            string key = "rzp_test_DOTcz75F10VBzs"; // Your Razorpay Key
            string secret = "GJ0AO2FrRkMBxpCOhzs4njSh"; // Your Razorpay Secret

            RazorpayClient client = new RazorpayClient(key, secret);

            Dictionary<string, string> attributes = new Dictionary<string, string>
            {
                { "razorpay_payment_id", paymentId },
                { "razorpay_order_id", orderId },
                { "razorpay_signature", signature }
            };
            try
            {
                Utils.verifyPaymentSignature(attributes, secret);
                // Signature is valid. Process the payment further.
                SetMessage("Signature is valid. Payment successful.", "success");
            }
            catch (Razorpay.Api.Errors.SignatureVerificationError ex)
            {
                // Invalid signature. Log the error for further investigation.
                SetMessage($"Invalid signature. Payment failed. Error: {ex.Message}", "error");
                // Consider logging the exception to a file or monitoring system
            }

            // Uncomment to refund the payment if needed
            // Refund refund = new Razorpay.Api.Payment(paymentId).Refund();

            //will send message according to pages(ex - daily,monthly,regular tickets)
            string sendmessage = (string)Session["Sendmessage"];
            if(sendmessage == "dailyPage")
            {
                paymentdb();
                //will redirect registration page in 3 sec
                btnHome.Visible = false;
                Label1.Text = "The page will be redirected in 3 seconds.";
                Label1.Visible = true;
                string prn=PrnGeneration();
                prnDailyPage(prn);
                Session["sendprn"]=prn;
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", "setTimeout(function(){ window.location.href='index.aspx'; }, 3000);", true);
            }
            else if(sendmessage == "normalTicket")
            {
                paymentdb();
                //will redirect registration page in 3 sec
                btnHome.Visible = false;
                Label1.Text = "The page will be redirected in 3 seconds.";
                Label1.Visible = true;
                string prn=sendNormalTicket();
                prnNormalTicket(prn);
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", "setTimeout(function(){ window.location.href='index.aspx'; }, 3000);", true);
            }
            else if(sendmessage == "monthly")
            {
                //paymentdb();
                //will redirect registration page in 3 sec
                btnHome.Visible = false;
                Label1.Text = "The page will be redirected in 3 seconds.";
                Label1.Visible = true;
                string prn= GeneratePnrNumber();
                Session["prn"] = prn;
                // Generate a 6-digit PNR number
                string verificationCode = GenerateVerificationCode();
                MonthlyPage(verificationCode);
                verifyMsg(verificationCode);
                //Session["VerificationCode"] = verificationCode;
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", "setTimeout(function(){ window.location.href='RegistrationForm.aspx'; }, 3000);", true);
            }
            else if(sendmessage == "Yearly")
            {
                //paymentdb();
                //will redirect registration page in 3 sec
                btnHome.Visible = false;
                Label1.Text = "The page will be redirected in 3 seconds.";
                Label1.Visible = true;
                string prn = GeneratePnrNumber();
                Session["prn"] = prn;

                // Generate a 6-digit PNR number
                string verificationCode = GenerateVerificationCode();
                YearlyPage(verificationCode);
                verifyMsg(verificationCode);
                //Session["VerificationCode"] = verificationCode;
                
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", "setTimeout(function(){ window.location.href='YearlyRegistration.aspx'; }, 3000);", true);
            }
            else
            {
                btnHome.Visible = false;
                Label1.Text = "The page will be redirected in 3 seconds.";
                Label1.Visible = true;
                string prn = GeneratePnrNumber();
                Session["prn"] = prn;

                // Generate a 6-digit PNR number
                string verificationCode = GenerateVerificationCode();
                studentPage(verificationCode);
                verifyMsg(verificationCode);
                //Session["VerificationCode"] = verificationCode;

                ClientScript.RegisterStartupScript(this.GetType(), "redirect", "setTimeout(function(){ window.location.href='YearlyRegistration.aspx'; }, 3000);", true);
            }
            

        }

        private void studentPage(string verificationCode)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "Insert into StudentPass (VerificationCode) values (@VerificationCode)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }

        private void YearlyPage(string verificationCode)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "Insert into YearlyPass (VerificationCode) values (@VerificationCode)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }

        private string verifyMsg(string verifcationCode)
        {
            //string phnumber= (string)Session["phoneNumber"];
            // Ensure TLS 1.2 is used
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string accountSid = System.Configuration.ConfigurationManager.AppSettings["TwilioAccountSid"];
            string authToken = System.Configuration.ConfigurationManager.AppSettings["TwilioAuthToken"];
            string twilioPhoneNumber = System.Configuration.ConfigurationManager.AppSettings["TwilioPhoneNumber"];
            string toPhoneNumber = "+918446415121"; // Replace with the recipient's phone number

           

            string messageBody = $"Welcome to PMPML TicketGhar Your PNR number is : {verifcationCode}";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toPhoneNumber),
                from: new PhoneNumber(twilioPhoneNumber),
                body: messageBody
            );
            return verifcationCode;
        }

        private void MonthlyPage(string verifcationCode)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "Insert into monthlyPassRegistration (VerificationCode) values (@VerificationCode)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@VerificationCode", verifcationCode);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }

        private void paymentdb()
        {
            string aadhar = (string)Session["AadharNumber"];
            int amount= (int)Session["PaymentPrice"];
            amount = amount / 100;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "INSERT INTO [dbo].[payment] ([AadharNumber], [Amount]) VALUES (@AadharNumber, @Amount)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AadharNumber", aadhar);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }

        private void prnDailyPage(string prn)
        {
            string aadharNumber = Session["AadharNumber"] as string;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "UPDATE regularPass SET PRN = @PRN WHERE AadharNumber = " + @aadharNumber;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PRN", prn);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }

        private void prnNormalTicket(string prn)
        {
            string aadharNumber = Session["AadharNumber"] as string;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineBusBookingConnectionString"].ConnectionString;
            string insertQuery = "UPDATE regularTicket SET PRN = @PRN WHERE AadharNumber = " + @aadharNumber;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a command and add parameters
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PRN", prn);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close the connection
                conn.Close();
            }
        }
        private string PrnGeneration()
        {
            //string phnumber= (string)Session["phoneNumber"];
            // Ensure TLS 1.2 is used
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string accountSid = System.Configuration.ConfigurationManager.AppSettings["TwilioAccountSid"];
            string authToken = System.Configuration.ConfigurationManager.AppSettings["TwilioAuthToken"];
            string twilioPhoneNumber = System.Configuration.ConfigurationManager.AppSettings["TwilioPhoneNumber"];
            string toPhoneNumber = "+918446415121"; // Replace with the recipient's phone number

            // Generate a 5-digit PNR number
            string pnrNumber = GeneratePnrNumber();

            string messageBody = $"Welcome to PMPML TicketGhar Your PNR number is: {pnrNumber}";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toPhoneNumber),
                from: new PhoneNumber(twilioPhoneNumber),
                body: messageBody
            );
            return pnrNumber;
        }

        private string GeneratePnrNumber()
        {
            //generate 5 digit
            Random random = new Random();
            int pnr = random.Next(10000, 100000); // Generates a number between 10000 and 99999
            return pnr.ToString();
        }

        private string GenerateVerificationCode()
        {
            //generate 6 digit
            Random random = new Random();
            int pnr = random.Next(100000, 1000000); // Generates a number between 10000 and 99999
            return pnr.ToString();
        }

        private string sendNormalTicket()
        {
            //string phnumber= (string)Session["phoneNumber"];
            // Ensure TLS 1.2 is used
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string accountSid = System.Configuration.ConfigurationManager.AppSettings["TwilioAccountSid"];
            string authToken = System.Configuration.ConfigurationManager.AppSettings["TwilioAuthToken"];
            string twilioPhoneNumber = System.Configuration.ConfigurationManager.AppSettings["TwilioPhoneNumber"];
            string toPhoneNumber = "+918446415121"; // Replace with the recipient's phone number

            // Generate a 5-digit PNR number
            string pnrNumber = GeneratePnrNumber();

            string messageBody = $"Welcome to PMPML TicketGhar we are from normal Your PNR number is : {pnrNumber}";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toPhoneNumber),
                from: new PhoneNumber(twilioPhoneNumber),
                body: messageBody
            );
             return pnrNumber ;
        }

        private void SetMessage(string message, string type)
        {
            // Set the message text and CSS class
            MessageLiteral.Text = $"<div class='message {type}'>{message}</div>";
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            // Redirect to the home page
            Response.Redirect("index.aspx");
        }
    }
    public static class Utils
    {
        public static void verifyPaymentSignature(Dictionary<string, string> attributes, string secret)
        {
            string orderId = attributes["razorpay_order_id"];
            string paymentId = attributes["razorpay_payment_id"];
            string signature = attributes["razorpay_signature"];

            string payload = $"{orderId}|{paymentId}";
            string generatedSignature = GenerateSHA256Hash(payload, secret);

            if (generatedSignature != signature)
            {
                throw new Razorpay.Api.Errors.SignatureVerificationError("Invalid signature passed");
            }
        }

        private static string GenerateSHA256Hash(string payload, string secret)
        {
            var encoding = new System.Text.UTF8Encoding();
            byte[] keyBytes = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(payload);

            using (var hmacsha256 = new System.Security.Cryptography.HMACSHA256(keyBytes))
            {
                byte[] hashMessage = hmacsha256.ComputeHash(messageBytes);
                return BitConverter.ToString(hashMessage).Replace("-", "").ToLower();
            }
        }
    }
}