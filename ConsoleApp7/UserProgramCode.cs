using System;
using System.Text.RegularExpressions;

 
namespace myprograms
{
	class UserProgramCode{
		public static int validatePAN(string input1)
        {

            
                int output1 = 0;
                Regex ex = new Regex("^([A-Z]{3}[0-9]{4}[A-Z]{1})$");
                if (ex.IsMatch(input1))
                {
                    output1 = 1;
                }
                else
                {
                    output1 = 2;
                }
                return output1;
            
        }
    }
}		
	