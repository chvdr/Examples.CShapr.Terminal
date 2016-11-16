using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// [2,3] - dimentional table
			// declaration of the 2 dimentional array
			string[,] table = new string[2, 3];

			// Name Surname Age
			// Name Surname Age

			// First line
			table[0, 0] = "Chavdar"; table[0, 1] = "Georgiev"; table[0, 2] = "45";

			// second line
			table[1, 0] = "Marin"; table[1, 1] = "Chilich"; table[1, 2] = "32";

			Console.WriteLine( table[0, 0][0] + ". " + table[0, 1] + ", " + table[0, 2] + " years old" );
			Console.WriteLine(table[1, 0][0] + ". " + table[1, 1] + ", " + table[1, 2] + " years old");

		}
	}
}




//string[] row = new string[3];

//row[0] = "Line 1"; row[1] = "Line 2"; row[2] = "Line 3";

//Console.WriteLine( "Here is the array: " + row[0] + ", " + row[1] + ", " + row[2]);

//string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');

//Console.WriteLine("The power of the string " + "1,2,3,4,5,6,7,8,9" + " is:" + parse.Length );

//string list1 = string.Join(";", parse);

//Console.WriteLine( "New preformatted string: " + list1);