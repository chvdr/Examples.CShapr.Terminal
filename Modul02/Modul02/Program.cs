using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Variable declarations
			int a = 0; int b = 0;		// numbers to be added
			int sum = 0;                // variable w. the sum of the above vars
			string program_name = "Module 02: Examples ";
			string program_version = "0.1-rc2";

			// About the program: Type name and version
			Console.Write( program_name);
			Console.WriteLine( "(Version: " + program_version + ')' + "\n\n" );

			// Add numbers
			a = 49;
			b = 12;

			sum = a + b;

			// Writing into a console
			Console.Write("a=");
			Console.WriteLine(a);
			Console.Write("b=");
			Console.WriteLine(b);
			Console.Write("sum=");
			Console.WriteLine(sum);
			// Basic (arythmetic) operators and operations in type int:
			Console.Write(a);
			Console.Write(" / ");
			Console.Write(b);
			Console.Write(" = ");
			Console.WriteLine((a/b).ToString());
			Console.Write(a);
			Console.Write(" % ");
			Console.Write(b);
			Console.Write(" = ");
			Console.WriteLine((a % b).ToString());

		}
	}
}
