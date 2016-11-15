using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[] row = new string[3];

			row[0] = "Line 1"; row[1] = "Line 2"; row[2] = "Line 3";

			Console.WriteLine( "Here is the array: " + row[0] + ", " + row[1] + ", " + row[2]);

			string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');

			Console.WriteLine("The power of the string " + "1,2,3,4,5,6,7,8,9" + " is:" + parse.Length );

			string list1 = string.Join(";", parse);

			Console.WriteLine( "New preformatted string: " + list1);

		}
	}
}
