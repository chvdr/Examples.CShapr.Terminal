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
