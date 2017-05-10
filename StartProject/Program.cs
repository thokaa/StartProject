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
			Problem4();
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
					var currentNumberDividedBy3 = (decimal) currentNumber / 3;
					var currentNumberDividedBy5 = (decimal) currentNumber / 5;
					if (currentNumberDividedBy3 == (int)currentNumberDividedBy3
						|| currentNumberDividedBy5 == (int)currentNumberDividedBy5)
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
