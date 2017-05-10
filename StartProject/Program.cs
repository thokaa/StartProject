using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartProject
{
    class Program
    {
        static void Main(string[] args)
        {
			Problem7();
		}

        public static void Problem6()
        {

        }

		public static void Problem7(int number = 12)
		{
			var firstLine = ConvertNumberToStringWithSpaces(0,2) + " ";

			for (int currentNumber = 1; currentNumber <= number; currentNumber++)
			{
				firstLine += ConvertNumberToStringWithSpaces(currentNumber) + " ";
			}
			Console.WriteLine(firstLine);
			for (int currentLineNumber = 1; currentLineNumber <= number; currentLineNumber++)
			{
				var currentLineString = ConvertNumberToStringWithSpaces(currentLineNumber,2) + " ";

				for (int currentNumber = 1; currentNumber <= number; currentNumber++)
				{
					currentLineString += ConvertNumberToStringWithSpaces(currentNumber * currentLineNumber) + " ";
				}
				Console.WriteLine(currentLineString);
			}

			Console.ReadLine();
		}

		public static string ConvertNumberToStringWithSpaces(int number, int numberOfSpaces = 3)
		{
			var currentNumberString = number.ToString();
			while (currentNumberString.Length < numberOfSpaces)
			{
				currentNumberString = " " + currentNumberString;
			}
			return currentNumberString;
		}


		public static void Problem4()
		{
			Console.WriteLine("Please enter a number...");
			int n;
			var numberFromConsole = Console.ReadLine();

			if (int.TryParse(numberFromConsole, out n))
			{
				var currentNumber = 1;
				var sum = 0;
				while (currentNumber <= n)
				{   // se repeta pana cand conditia este satisfacuta (true)
					if (currentNumber % 3 == 0 || currentNumber % 5 ==0)
						sum = sum + currentNumber;
					currentNumber = currentNumber + 1;
				}

				Console.WriteLine("1+2+...+n=" + sum);
			}
			else
			{
				Console.WriteLine("Number is not an integer");
			}
			Console.ReadLine();
		}

		public static void Problem3()
		{
			Console.WriteLine("Please enter your name!");

			var nameFromConsole = Console.ReadLine();

			var greeting = "Hello " + nameFromConsole + "!";

			if (nameFromConsole == "Adi" || nameFromConsole == "Vlad")
			{
				Console.WriteLine(greeting);
			}
			else
			{
				Console.WriteLine("Goodbye!");
			}

			Console.ReadLine();
		}
	}
}
