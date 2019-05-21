  using System;

class UserProgramCode
{
  public static int countNoOfWords(string str1,string str2)
  {
       
            string[] sub1 = str1.Split(' ');
            string[] sub2 = str2.Split(' ');
            int ctr = 0;
            string str = sub2[1];
            for (int i = 0; i < sub1.Length; i++)
            {
                if (sub1[i] == str)
                {
                    ctr++;
                }
            }
            return ctr;
        
    }
}



