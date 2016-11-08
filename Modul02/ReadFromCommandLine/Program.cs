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
		}
	}
}
