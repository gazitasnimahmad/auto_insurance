using Model;
using System;

public class business_logic
{
    // validating the user details
    public bool validateUser(User u)
    {
        if (u.Username != null && u.Password.Length >= 8 && u.Mobile_no.Length == 10)
        {
              //encoding the password to 64baseString
 
            //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(u.Password);
            //u.Password = System.Convert.ToBase64String(plainTextBytes);
            data_access_layer d1 = new data_access_layer();
            d1.InsertUser(u);
            return true;
        }
        return false;
    }

    // validating the claim registrarion page
    public bool validateClaim(Claim c)
    {
        if(c.Insurance_no != null && c.Policy_start_date != null && c.Policy_end_date != null && c.Account_no != null && c.Amount != null && c.Bank_name != null && c.Vehicle_engine_no != null && c.Vehicle_reg_no != null)
        {
            data_access_layer d2 = new data_access_layer();
            d2.InsertClaim(c);
                return true;

        }
            return false;
    }

    //validating the insurance_officer inputs 

    public bool validatingByInsurance_officer(Insurance_officer i)
    {
        if(i.Remarks != null && i.Status != null && i.Date!= null)
        {
            data_access_layer d3 = new data_access_layer();
            d3.InsertInsuranceInputs(i);
            return true;
        }
        return false;
    }

    //validating the login page

    public bool validaingLogin(login l)
    {
          // decoding the 64baseString password to normal string
        
        if (l.Username != null && l.Password != null && l.Role_name != null)
        {
            //var base64EncodedBytes = System.Convert.FromBase64String(l.Password);
            //l.Password = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            data_access_layer d4 = new data_access_layer();
            d4.InsertLogin(l);
            return true;
        }
        return false;
    }

    //validating the claim officer inputs

    public bool validatingByClaimOfficer(Claim_officer b)
    {
        if (b.Remarks != null && b.Status != null && b.Date != null)
        {
            data_access_layer d5 = new data_access_layer();
            d5.InsertByClaimOfficer(b);
            return true;
        }

        return false;
    }
    
    // validating from the assessor

    public bool validatingByAssessor(Assessor a)
    {
        if(a.Remarks != null && a.Status != null && a.Date != null)
        {
            data_access_layer d6 = new data_access_layer();
            d6.InsertByAssessor(a);
            return true;
        }
        return false;
    }

    // validating the payments

    public bool validatingPayments(Payment p)
    {
        if (true)
        {
            data_access_layer d7 = new data_access_layer();
            d7.InsertPayments(p);
            return true;
        }
        return false;
    }

    
}

