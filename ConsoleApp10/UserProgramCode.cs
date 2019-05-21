 using System;
using System.Collections.Generic;

    class UserProgramCode
    {
        public static List<int> GetAllElements(List<int> li, int size)
        {
            List<int> list = new List<int>();
            foreach (var x in li)
            {
            if (x > 500)
            { 
                list[0] = -1;
                return list;
            }
            else if (x > 5 && x <= 500)
            {
                list.Add(x);
            }
                 
            }
            return list;
        }
    }

