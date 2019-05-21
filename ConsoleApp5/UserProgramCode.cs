using System;

class UserProgramCode
{
  public static int arithmeticOperation (int a, int b, int c)
  {
       
            if (a > 0 && a < 5)
            {
                if (b < 0 || c < 0)
                    return -2;
                else
                if (a == 1)
                    return b + c;
                else if (a == 2)
                    return b - c;
                else if (a == 3)
                    return b * c;
                else
                    return b / c;
            }
            else
                return -1;
        
    }
}