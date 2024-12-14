using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class verification_document1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string pass = (string)Session["pass"];
            Session["Sendmessage"] = pass;
            if (pass == "monthly")
            {
                int dailyTicketPrice = 900 * 100;
                Session["PaymentPrice"] = dailyTicketPrice;
            }
            else if (pass == "Yearly")
            {
                int dailyTicketPrice = 5000 * 100;
                Session["PaymentPrice"] = dailyTicketPrice;
            }
            else if(pass == "student")
            {
                int dailyTicketPrice = 600 * 100;
                Session["PaymentPrice"] = dailyTicketPrice;
            }
            //insertdbpdf();
            Response.Write("<script>alert('PDF uploaded successfully!'); window.location.href='Payment.aspx';</script>");

        }
    }
}