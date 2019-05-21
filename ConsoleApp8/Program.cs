using System;


class Program
{
  public static void Main( string[] args )
  {	
        int num=Convert.ToInt32(Console.ReadLine());
        int result=UserProgramCode.findLargestDigit(num);
        if(result==-1)
            Console.WriteLine("Negative Number");
        else
            Console.WriteLine(result);
  }
}
