using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;


namespace auto_insurance.Presentation_Layer
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            User u1 = new User();

            u1.User_id = "1";
            u1.Username = TextBox1.Text.ToString();
            u1.Password = TextBox2.Text.ToString();
            u1.Email_id = TextBox3.Text.ToString();
            u1.Mobile_no = TextBox5.Text.ToString();
            u1.Gender = TextBox6.Text.ToString();
            u1.Dob = DropDownList1.Text.ToString();
            u1.Security_question = DropDownList4.Text.ToString();
            u1.Security_answer = TextBox7.Text.ToString();
            u1.Profile_pic = "www.placeholder.com/100x100";
            u1.State = TextBox10.Text.ToString();
            u1.City = TextBox4.Text.ToString();
            u1.Pincode = TextBox8.Text.ToString();
            u1.Country = TextBox9.Text.ToString();
            

            business_logic b1 = new business_logic();
            if (b1.validateUser(u1))
                Response.Write("<script>alert('Thank You for your registration')</script>");
            else
                Response.Write("<script>alert('Invalid data')</script>");
        }
    }
}