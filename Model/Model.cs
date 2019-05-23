using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class User
    {
        string user_id;
        string username;
        string password;
        string email_id;
        string mobile_no;
        string gender;
        string dob;
        string security_question;
        string security_answer;
        string profile_pic;
        string city;
        string country;
        string pincode;
        string state;
        string role_name;

        public User() { }
        public User(string state,string user_id, string username, string password, string email_id, string mobile_no, string gender, string dob, string security_question, string security_answer, string profile_pic, string city, string country, string pincode, string role_name)
        {
            this.user_id = user_id;
            this.username = username;
            this.password = password;
            this.email_id = email_id;
            this.mobile_no = mobile_no;
            this.gender = gender;
            this.dob = dob;
            this.security_question = security_question;
            this.security_answer = security_answer;
            this.profile_pic = profile_pic;
            this.city = city;
            this.country = country;
            this.pincode = pincode;
            this.state = state;
            this.role_name = role_name;

        }

        public string User_id { get => user_id; set => user_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email_id { get => email_id; set => email_id = value; }
        public string Mobile_no { get => mobile_no; set => mobile_no = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Security_question { get => security_question; set => security_question = value; }
        public string Security_answer { get => security_answer; set => security_answer = value; }
        public string Profile_pic { get => profile_pic; set => profile_pic = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Pincode { get => pincode; set => pincode = value; }
        public string State { get => state; set => state = value; }
        public string Role_name { get => role_name; set => role_name = value; }
    }

    public class Claim
    {
        string claim_id;
        string user_id;
        string insurance_no;
        string policy_start_date;
        string policy_end_date;
        string fir_copy;
        string aadhar_copy;
        string pan_card_copy;
        string account_no;
        string ifsc_code;
        string bank_name;
        string vehicle_id;
        string status;
        string vehicle_reg_no;
        string vehicle_engine_no;
        string amount;


        public Claim() { }
        public Claim(string claim_id, string user_id, string insurance_no, string policy_start_date, string policy_end_date, string fir_copy, string aadhar_copy, string pan_card_copy, string account_no, string ifsc_code, string bank_name, string vehicle_id, string status, string vehicle_reg_no, string vehicle_engine_no, string amount)
        {
            this.Claim_id = claim_id;
            this.User_id = user_id;
            this.Insurance_no = insurance_no;
            this.Policy_start_date = policy_start_date;
            this.Policy_end_date = policy_end_date;
            this.Fir_copy = fir_copy;
            this.Aadhar_copy = aadhar_copy;
            this.Pan_card_copy = pan_card_copy;
            this.Account_no = account_no;
            this.Ifsc_code = ifsc_code;
            this.Bank_name = bank_name;
            this.Vehicle_id = vehicle_id;
            this.Status = status;
            this.Vehicle_reg_no = vehicle_reg_no;
            this.Vehicle_engine_no = vehicle_engine_no;
            this.Amount = amount;
        }

        public string Claim_id { get => claim_id; set => claim_id = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public string Insurance_no { get => insurance_no; set => insurance_no = value; }
        public string Policy_start_date { get => policy_start_date; set => policy_start_date = value; }
        public string Policy_end_date { get => policy_end_date; set => policy_end_date = value; }
        public string Fir_copy { get => fir_copy; set => fir_copy = value; }
        public string Aadhar_copy { get => aadhar_copy; set => aadhar_copy = value; }
        public string Pan_card_copy { get => pan_card_copy; set => pan_card_copy = value; }
        public string Account_no { get => account_no; set => account_no = value; }
        public string Ifsc_code { get => ifsc_code; set => ifsc_code = value; }
        public string Bank_name { get => bank_name; set => bank_name = value; }
        public string Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public string Status { get => status; set => status = value; }
        public string Vehicle_reg_no { get => vehicle_reg_no; set => vehicle_reg_no = value; }
        public string Vehicle_engine_no { get => vehicle_engine_no; set => vehicle_engine_no = value; }
        public string Amount { get => amount; set => amount = value; }
    }

    public class Vehicle
    {
        string vehicle_id;
        string vehicle_type;
        string policy_amount;

        public Vehicle() { }
        public Vehicle(string vehicle_id, string vehicle_type, string policy_amount)
        {
            this.vehicle_id = vehicle_id;
            this.vehicle_type = vehicle_type;
            this.policy_amount = policy_amount;
        }

        public string Vehicle_id { get => vehicle_id; set => vehicle_id = value; }
        public string Vehicle_type { get => vehicle_type; set => vehicle_type = value; }
        public string Policy_amount { get => policy_amount; set => policy_amount = value; }
        
    }

    public class Insurance_officer
    {
        string s_no;
        string claim_id;
        string login_id;
        string remarks;
        string date;
        string status;

        public Insurance_officer() { }
        public Insurance_officer(string s_no, string claim_id, string login_id, string remarks, string date, string status)
        {
            this.S_no = s_no;
            this.Claim_id = claim_id;
            this.Login_id = login_id;
            this.Remarks = remarks;
            this.Date = date;
            this.Status = status;
        }

        public string S_no { get => s_no; set => s_no = value; }
        public string Claim_id { get => claim_id; set => claim_id = value; }
        public string Login_id { get => login_id; set => login_id = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public string Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
    }

    public class Payment
    {
        string claim_id;
        string payment_id;
        string date;

        public Payment() { }
        public Payment(string claim_id, string payment_id, string date)
        {
            this.Claim_id = claim_id;
            this.Payment_id = payment_id;
            this.Date = date;
        }

        public string Claim_id { get => claim_id; set => claim_id = value; }
        public string Payment_id { get => payment_id; set => payment_id = value; }
        public string Date { get => date; set => date = value; }
    }

    public class login
    {
        string login_id;
        string username;
        string password;
        string role_name;

        public login() { }
        public login(string login_id, string username, string password, string role_name)
        {
            this.Login_id = login_id;
            this.Username = username;
            this.Password = password;
            this.Role_name = role_name;
        }

        public string Login_id { get => login_id; set => login_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role_name { get => role_name; set => role_name = value; }
    }

    public class Claim_officer
    {
        string s_no;
        string claim_id;
        string login_id;
        string remarks;
        string date;
        string status;

        public Claim_officer() { }
        public Claim_officer(string s_no, string claim_id, string login_id, string remarks, string date, string status)
        {
            this.S_no = s_no;
            this.Claim_id = claim_id;
            this.Login_id = login_id;
            this.Remarks = remarks;
            this.Date = date;
            this.Status = status;
        }

        public string S_no { get => s_no; set => s_no = value; }
        public string Claim_id { get => claim_id; set => claim_id = value; }
        public string Login_id { get => login_id; set => login_id = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public string Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
    }

    public class Assessor
    {
        string s_no;
        string claim_id;
        string login_id;
        string remarks;
        string payment_to_be_released;
        string date;
        string status;

        public Assessor() { }
        public Assessor(string s_no, string claim_id, string login_id, string remarks, string payment_to_be_released, string date, string status)
        {
            this.S_no = s_no;
            this.Claim_id = claim_id;
            this.Login_id = login_id;
            this.Remarks = remarks;
            this.Payment_to_be_released = payment_to_be_released;
            this.Date = date;
            this.Status = status;
        }

        public string S_no { get => s_no; set => s_no = value; }
        public string Claim_id { get => claim_id; set => claim_id = value; }
        public string Login_id { get => login_id; set => login_id = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public string Payment_to_be_released { get => payment_to_be_released; set => payment_to_be_released = value; }
        public string Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
    }
}