using System;
using System.Linq;
using System.Web;

using Model;

using System.Data;
using System.Data.SqlClient;



public class data_access_layer
{
    
    private object Response;



    public void InsertUser(User u)
    {
        SqlConnection con = new SqlConnection(@"initial catalog=Auto_insurance;data source=CGI-JAVA-049\CGI;integrated security=true");
        con.Open();

        SqlCommand cmd = new SqlCommand("insert into user_details values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", con);

        cmd.Parameters.AddWithValue("@p1", u.User_id);
        cmd.Parameters.AddWithValue("@p2", u.Username);
        cmd.Parameters.AddWithValue("@p3", u.Password);
        cmd.Parameters.AddWithValue("@p4", u.Email_id);
        cmd.Parameters.AddWithValue("@p5", u.Mobile_no);
        cmd.Parameters.AddWithValue("@p6", u.Gender);
        cmd.Parameters.AddWithValue("@p7", u.Dob);
        cmd.Parameters.AddWithValue("@p8", u.Security_question);
        cmd.Parameters.AddWithValue("@p9", u.Security_answer);
        cmd.Parameters.AddWithValue("@p10", u.Profile_pic);
        cmd.Parameters.AddWithValue("@p11", u.State);
        cmd.Parameters.AddWithValue("@p12", u.City);
        cmd.Parameters.AddWithValue("@p13", u.Pincode);
        cmd.Parameters.AddWithValue("@p14", u.Country);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void InsertClaim(Claim c)
    {

    }
    public void InsertInsuranceInputs(Insurance_officer i)
    {

    }

    public bool updatePass(string str, string email)
    {
        SqlConnection con = new SqlConnection(@"initial catalog=Auto_Insurance;data source=CGI-JAVA-049\CGI;integrated security=true");
        con.Open();
        string str1 = "UPDATE user_details SET password_id='" + str +"'  where email_id = 'tasnim@gmail.com'  ";

        SqlCommand cmd3 = new SqlCommand(str1, con);
        cmd3.Parameters.AddWithValue("@p1", str);
        cmd3.ExecuteNonQuery();
        return true;
    }


    public bool checkForgot(string email1, string dropdown1, string answer)
    {
        SqlConnection con = new SqlConnection(@"initial catalog=Auto_Insurance;data source=CGI-JAVA-049\CGI;integrated security=true");
        con.Open();
        //string str = "select count(*) from user_details where email_id = 'tasnim@gmail.com' and security_question_id = 'Which is your Birth City' and security_answer_id = 'gaya'";
        string str = "select count(*) from user_details where email_id ='"+ email1 + "' and security_question_id ='" + dropdown1 + "' and security_answer_id ='" + answer + "' ";
        SqlCommand cmd2 = new SqlCommand(str,con);

        int i = (int)cmd2.ExecuteScalar();
        con.Close();
        if (i > 0)
            return true;
        else
            return false;
        
    }

    public bool InsertLogin(login l)
    {
        SqlConnection con = new SqlConnection(@"initial catalog=Auto_Insurance;data source=CGI-JAVA-049\CGI;integrated security=true");
        con.Open();
        SqlCommand cmd1 = new SqlCommand("select count(*) from user_details where email_id ='" + l.Username + "' and  password_id ='" + l.Password + "'" ,con);

        int i = (int)cmd1.ExecuteScalar();
        if (i == 1)
        {
            SqlCommand cmd = new SqlCommand("insert into login_table values(@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p1", l.Login_id);
            cmd.Parameters.AddWithValue("@p2", l.Username);
            cmd.Parameters.AddWithValue("@p3", l.Password);
            cmd.Parameters.AddWithValue("@p4", l.Role_name);
            cmd.ExecuteNonQuery();
            return true;
        }

        else
        {
            return false;
        }
    }

public void InsertByClaimOfficer(Claim_officer c)
{

}
public void InsertByAssessor(Assessor a)
{

}
public void InsertPayments(Payment p)
{

}
    
}
