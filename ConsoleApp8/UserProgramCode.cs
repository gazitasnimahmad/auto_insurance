using System;

class UserProgramCode
{
  public static int findLargestDigit(int num)
  {
        
            if (num > 0)
            {
                int temp, res = 0;
                while (num > 0)
                {
                    temp = num % 10;
                    if (temp > res)
                        res = temp;
                    num = num / 10;
                }
                return res;
            }
            else
                return -1;
        
    }
}

