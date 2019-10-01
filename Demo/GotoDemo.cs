using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class GotoDemo
	{
		static void Main()
		{
			int x = 200, y = 4;
			int count = 0;
			string[,] array = new string[x, y];

			// Initialize the array.
			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					array[i, j] = (++count).ToString();
				}
			}
			Console.Write("Enter the number: ");
			string myNumber = Console.ReadLine();

			// search
			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					if (array[i,j].Equals(myNumber))
					{
						goto Found;
					}
				}
			}

			Console.WriteLine($"The number {myNumber} was not found.");
			goto Finish;

		Found:
			Console.WriteLine($"The number {myNumber} is found.");
		Finish:
			Console.WriteLine($"End search.");

		// Keep the console open in debug mode
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
