using System;

namespace TableProjectRepetition
{
	class MainClass
	{
		/*
		 * The Project name:
		 * TableProjectRepetition
		 * 
		 * This file is created only to repeat impressions of the last few lessons. Main TOPICS:
		 * 1. Arrays
		 * 2. Strings
		 * 3. Strings as an arrays
		 * 4. Two dimention arrays (also known as tables - this gave us name of the project)
		*/ 
		public static void Main(string[] args)
		{
			Console.WriteLine("Hi! This is TableProjectRepetition, the work file for some features to be re-regard.");
			Console.WriteLine("\n\n\n");
			Console.WriteLine("1. Split and Parse in strings (arrays): ");
			Console.WriteLine("\n");
			Console.WriteLine("Let us assume row[] is 1-dimentional string with value as follows: \n 1,2,3,4,5,6,7,8,9");
			Console.WriteLine("The task is to replace it with 1;2;3;4;5;6;7;8;9 i.e. to move commas to semi-colons \n");

			// init the array: Define it with string, using commas as a separator
			Console.WriteLine("\n\n First of all, lets init the variable: \n string parse = 1,2,3,4,5,6,7,8,9 \n\n");
			// use Split to divide the string above to array of symbols 1 2 3 4 5 6 7 8 9 
			Console.WriteLine("divide the string above to array of symbols 1 2 3 4 5 6 7 8 9");
			Console.WriteLine(" Use \n string[] parse = \"1,2,3,4,5,6,7,8,9\".Split(','); \n to do that: \n\n");

			string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');  

			// use Lenght - 
			Console.WriteLine("The defined string is " + parse.Length + " - characters long. \n This is also called Power of the array/string... \n\n" );

			// replace commas w. semi-colons: 
			string list1 = String.Join(";", parse);
			Console.WriteLine("And here is the string (preformatted): " + list1 + "\n\n\n\n" );



		}
	}
}
