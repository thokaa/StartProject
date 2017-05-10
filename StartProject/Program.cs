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

		public static void Problem7()
		{
			var currentNumber = 1;
			var currentLine = "";
			while (currentNumber <= 12)
			{
				currentLine += currentNumber + " ";
				currentNumber++;
			}
			Console.WriteLine(currentLine);
			Console.ReadLine();
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
