using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class ExceptionOutsideQueryDemo
	{
		//static void Main()
		//{
		//	IEnumerable<int> dataSource;

		//	try
		//	{
		//		dataSource = GetData();
		//	}
		//	catch (InvalidOperationException)
		//	{
		//		Console.WriteLine("Invalid");
		//		goto Exit;
		//	}

		//	var query = from i in dataSource
		//				select i * i;

		//	foreach (var item in query)
		//	{
		//		Console.WriteLine(item.ToString());
		//	}

		//Exit:
		//	Console.WriteLine("Press");
		//	Console.ReadKey();
		//}

		//static IEnumerable<int> GetData()
		//{
		//	throw new InvalidOperationException();
		//}
		static void Main()
		{
			string[] files = { "fileA.txt", "fileB.txt", "fileC.txt" };

			var exceptionDemoQuery = from file in files
									 let n = SomeMethodThatMightThrow(file)
									 select n;
			try
			{
				foreach (var item in exceptionDemoQuery)
				{
					Console.WriteLine($"Processing {item}");
				}
			}
			catch (InvalidOperationException e)
			{
				Console.WriteLine(e.Message);
			}
			Console.WriteLine("Press");
			Console.ReadKey();
		}

		static string SomeMethodThatMightThrow(string s)
		{
			if (s[4] == 'C')
				throw new InvalidOperationException();
			return @"C:\newFloder\" + s;
		}
	}
}
