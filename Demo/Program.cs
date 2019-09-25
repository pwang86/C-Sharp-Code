using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	[Flags]
	public enum CarOptions
	{
		SunRoof = 0x01,
		Spoiler = 0x02,
		FogLights = 0x04,
		TintedWindows = 0x08,
	}

	class Program
	{
		// 1. first exercise
		// static void Main(string[] args)
		//{
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

		//// 2. BoolKeyTest
		//Console.Write("Enter a character: ");
		//char c = (char)Console.Read();
		//if (Char.IsLetter(c))
		//{
		//	if (char.IsLower(c))
		//	{
		//		Console.WriteLine("The character is lowercase");
		//	}
		//	else
		//	{
		//		Console.WriteLine("The character is uppercase");		
		//	}
		//}
		//else
		//{
		//	Console.WriteLine("Not a character");
		//}
		// }

		//// EnumTest
		//enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

		//static void Main()
		//{
		//	int x = (int)Day.Sun;
		//	int y = (int)Day.Fri;
		//	Console.WriteLine("Sun = {0}", x);
		//	Console.WriteLine("Fri = {0}", y);
		//}

		//// EnumTest 2 
		//enum Range : long { Max = 2147483648L, Min = 255L};
		//static void Main()
		//{
		//	long x = (long)Range.Max;
		//	long y = (long)Range.Min;
		//	Console.WriteLine("Max = {0}", x);
		//	Console.WriteLine("Min = {0}", y);
		//}
		static void Main()
		{
			CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;
			Console.WriteLine(options);
			Console.WriteLine((int)options);
		}
	}
}
