using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			//bool b = true;

			//// output
			//Console.WriteLine(b);

			//int days = DateTime.Now.DayOfYear;

			//b = (days % 2 == 0);

			////output
			//Console.WriteLine(days);

			//if (b)
			//{
			//	Console.WriteLine("days is an even number");
			//}
			//else
			//{
			//	Console.WriteLine("days is an odd number");
			//}

			// BoolKeyTest
			Console.Write("Enter a character: ");
			char c = (char)Console.Read();
			if (Char.IsLetter(c))
			{
				if (char.IsLower(c))
				{
					Console.WriteLine("The character is lowercase");
				}
				else
				{
					Console.WriteLine("The character is uppercase");		
				}
			}
			else
			{
				Console.WriteLine("Not a character");
			}
		}
	}
}
