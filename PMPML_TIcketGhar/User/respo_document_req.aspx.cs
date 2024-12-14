using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMPML_TIcketGhar.User
{
    public partial class respo_document_req : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //student
        protected void btnProceed_Click(object sender, EventArgs e)
        {
            string pass = "student";
            Session["pass"] = pass;
            Response.Redirect("verification_document.aspx");
        }
        //monthly
        protected void btnProceed_Click1(object sender, EventArgs e)
        {
            string pass = "monthly";
            Session["pass"] = pass;
            Response.Redirect("verification_document.aspx");
        }
        //yearly
        protected void btnProceed_Click2(object sender, EventArgs e)
        {
            string pass = "Yearly";
            Session["pass"] = pass;
            Response.Redirect("verification_document.aspx");
        }
    }
}