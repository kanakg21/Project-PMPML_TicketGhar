using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class Payment : System.Web.UI.Page
    {
        public string orderId;
        protected void Page_Load(object sender, EventArgs e)
        {
            int paymentPrice = (int)Session["PaymentPrice"];
            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", paymentPrice); // this amount should be same as transaction amount
            input.Add("currency", "INR");
            input.Add("receipt", "13131");
            input.Add("payment_capture", 1);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string key = "rzp_test_DOTcz75F10VBzs";
            string secret = "GJ0AO2FrRkMBxpCOhzs4njSh";


            RazorpayClient client = new RazorpayClient(key, secret);

            Razorpay.Api.Order order = client.Order.Create(input);
            orderId = order["id"].ToString();
        }
    }
}