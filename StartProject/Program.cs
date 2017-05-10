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

			var numberFromConsole = Console.ReadLine();
			Int32 n = Int32.Parse(numberFromConsole);
			var currentNumber = 1;
			var sum = 0;
			while (currentNumber <= n)
			{	// se repeta pana cand conditia este satisfacuta (true)
				sum = sum + currentNumber;
				currentNumber = currentNumber + 1;
			}

			Console.WriteLine(sum);
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
