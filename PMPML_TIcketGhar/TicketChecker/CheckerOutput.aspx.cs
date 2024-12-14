using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.TicketCollector
{
    public partial class CollectorInpur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Valid_Click(object sender, EventArgs e)
        {

        }

        protected void NotValid_Click(object sender, EventArgs e)
        {

        }

        protected void Done_Click(object sender, EventArgs e)
        {
            int penaltyAmount = int.Parse("500")*100;
            //Store the penalty amount in session
            Session["PaymentPrice"] = penaltyAmount;
            Response.Redirect("../User/Payment.aspx");
            

        }
    }
}