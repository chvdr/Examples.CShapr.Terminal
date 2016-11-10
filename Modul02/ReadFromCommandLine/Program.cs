using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Welcome message:
			Console.WriteLine("Hello! This program aggregates 5 with a number, inserted from Input");
			Console.WriteLine("Now, enter value of variable b: ");
			// var declarations
			int a = 5, b = 0;

			// insert value of b:
			Console.Write("b = ");
			b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Example of how to use cl input: ");
			Console.Write(a + " + " + b + " = " );
			Console.WriteLine((a + b).ToString());

			// Main operations with strings:
			Console.WriteLine("\n\n\n");
			Console.WriteLine("And now, let's try with concatenation: ");

			string test = "1";
			test += ", 2";
			test += ", 3";
			test += ", 4";
			test += ", 5";
			test += ", 6";

			Console.WriteLine(test);
			Console.WriteLine(test.Replace(", ", ";"));

			Console.WriteLine( "The first digit of the numbered sequence: " + test.Split(',')[0] );
			Console.WriteLine("The 3rd digit of the numbered sequence: " + test.Split(',')[2] + "\n");
		}
	}
}
