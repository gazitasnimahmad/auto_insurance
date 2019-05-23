using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace auto_insurance.Presentation_Layer
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            login n = new login();
            n.Login_id = "1";
            n.Username =TextBox1.Text;
            n.Password =TextBox2.Text;
            n.Role_name =DropDownList1.Text;
            
            business_logic b = new business_logic();
            bool u = b.validatingLogin(n);
            if (u == true)
            {
                Response.Redirect("UserProfile.aspx");
            }
            else
            {
                Response.Write("<script>alert('Check Your Credentails');</script>");
            }
           
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}