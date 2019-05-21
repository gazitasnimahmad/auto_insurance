using System;
 
namespace myprograms
{
  class Program
   {
        public static void Main(){
		int result = UserProgramCode.validatePAN(Console.ReadLine()) ;
		if( result == 1 ){
			Console.WriteLine("Valid PAN code");
		}
		else if( result == 2 ){
			Console.WriteLine("Invalid PAN code");
		}
        }
   }
}
