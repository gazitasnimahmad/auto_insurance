using System;

using System.Data;
using System.Data.SqlClient;
using Model;


public class data_access_layer
{
    public void InsertUser(User u)
    {
        SqlConnection con = new SqlConnection(@"initial catalog=Auto_insurance;data source=CGI-JAVA-055\CGI;integrated security=true");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into user_details values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", con);
        
        cmd.Parameters.AddWithValue("@p1", u.Username);
        cmd.Parameters.AddWithValue("@p2", u.Password);
        cmd.Parameters.AddWithValue("@p3", u.Email_id);
        cmd.Parameters.AddWithValue("@p4", u.Mobile_no);
        cmd.Parameters.AddWithValue("@p5", u.Gender);
        cmd.Parameters.AddWithValue("@p6", u.Dob);
        cmd.Parameters.AddWithValue("@p7", u.Security_question);
        cmd.Parameters.AddWithValue("@p8", u.Security_answer);
        cmd.Parameters.AddWithValue("@p9", u.State);
        cmd.Parameters.AddWithValue("@p10", u.City);
        cmd.Parameters.AddWithValue("@p11", u.Pincode);
        cmd.Parameters.AddWithValue("@p12", u.Country);
        cmd.ExecuteNonQuery();
    }
    public void InsertClaim(Claim c)
    {

    }
    public void InsertInsuranceInputs(Insurance_officer i)
    {

    }
    public void InsertLogin(login l)
    {

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
