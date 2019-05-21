using System;

class Program
{
  public static void Main( string[] args )
  {
	int operation=Convert.ToInt32(Console.ReadLine());
	int operands1=Convert.ToInt32(Console.ReadLine());
	int operands2=Convert.ToInt32(Console.ReadLine());
	int result=UserProgramCode.arithmeticOperation (operation,operands1,operands2);
	if(result==-1)
		Console.WriteLine("Invalid operator");
	else if(result==-2)
		Console.WriteLine("Invalid operands");
	else{
		Console.WriteLine(result);
	}
  }
}

