using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{

    long _id;
    string _name;
    string _emailId;
    DateTime _dateOfBirth;

    public User(long id, string name, string emailId, DateTime dateOfBirth)
    {
        Id = id;
        Name = name;
        EmailId = emailId;
        DateOfBirth = dateOfBirth;
    }

    public long Id { get { return _id; } set { _id = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public string EmailId { get { return _emailId; } set { _emailId = value; } }
    public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

    public static User CreateUser(string detail)
    {
        string[] s = detail.Split(',');
        User u = new User(long.Parse(s[0]), s[1], s[2], DateTime.ParseExact(s[3], "dd-MM-yyyy", null));
        return u;
    }
} 