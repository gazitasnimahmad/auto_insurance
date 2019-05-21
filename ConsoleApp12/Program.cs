using System;
using System.Collections.Generic;

    class Program
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> li = new List<int>();
            List<int> outli = new List<int>();
            for (int i = 0; i < size; i++)
                li.Add(Convert.ToInt32(Console.ReadLine()));
            outli = UserProgramCode.GetAllElements(li, size);
            if (outli[0] == -1) 
                Console.WriteLine("Array element greater than 500");
            else
            {
                for (int i = 0; i < outli.Count; i++)
                    Console.WriteLine(outli[i]);
            }
        }
    }
