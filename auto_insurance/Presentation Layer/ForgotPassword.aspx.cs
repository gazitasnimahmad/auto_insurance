using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace auto_insurance.Presentation_Layer
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string email1 = TextBox1.Text;
            string dropdown1 = DropDownList4.Text;
            string answer = TextBox4.Text;

            business_logic b1 = new business_logic();
            bool y = b1.validateForgot(email1, dropdown1, answer);
            if (y)
            {
                TextBox1.ReadOnly = true;
                TextBox4.Visible = false;
                DropDownList4.Visible = false;
                Button2.Visible = false;
                Button1.Visible = true;
                TextBox3.Visible = true;
                TextBox2.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;          
            string pass = TextBox2.Text;
            string cPass = TextBox3.Text;
         //   Response.Write(email + "" + pass + "" + cPass);
            Response.Write("<script>alert("+email + "" + pass + "" + cPass+")</script>");
            if (pass == cPass)
            {
                business_logic n = new business_logic();
                bool t = n.updatePassword(cPass, email);
                if (t)
                    Response.Write("Your Password is Updated");
                else
                    Response.Write("Error");
            }
            else
                Response.Write("Password is not same");
            //}


        }
    }
}