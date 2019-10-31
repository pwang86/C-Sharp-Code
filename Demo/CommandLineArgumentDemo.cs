using System;


namespace Demo
{
	class CommandLineArgumentDemo
	{

		//public class Functions
		//{
		//	public static long Factoria(int n)
		//	{
		//		if ((n < 0) || (n > 20))
		//		{
		//			return -1;
		//		}

		//		long tempResult = 1;
		//		for (int i = 1; i <= n; i++)
		//		{
		//			tempResult *= i;
		//		}
		//		return tempResult;
		//	}
		//}
		//class MainClass
		//{
		//	public static int Main(string[] args)
		//	{
		//		if (args.Length == 0)
		//		{
		//			Console.WriteLine("Please enter a numeric argument.");
		//			Console.WriteLine("Useage: Factorial <num>");
		//			return 1;
		//		}

		//		int num;
		//		bool test = int.TryParse(args[0], out num);
		//		if (!test)
		//		{
		//			Console.WriteLine("Please enter a numeric argument.");
		//			Console.WriteLine("Usage: Factorial <num>");
		//			return 1;
		//		}

		//		long result = Functions.Factoria(num);

		//		if (result == -1)
		//			Console.WriteLine("Input must be >= 0 and <= 20");
		//		else
		//			Console.WriteLine($"The factorial of {num} is {result}");
		//		return 0;
		//	}
		//}
	}
}
