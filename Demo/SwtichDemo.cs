using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	// public enum Color { Red, Green, Blue}
	public class SwtichDemo
	{
		// public static void Main()
		// {
			////Color c = (Color)(new Random()).Next(0,3);
			////switch (c)
			////{
			////	case Color.Red:
			////		Console.WriteLine("The color is red");
			////		break;
			////	case Color.Green:
			////		Console.WriteLine("The color is Green");
			////		break;
			////	case Color.Blue:
			////		Console.WriteLine("The color is Blue");
			////		break;
			////	default:
			////		Console.WriteLine("The color is unknown");
			////		break;
			////}

	//		var values = new List<object>();
	//			for (int ctr = 0; ctr <= 7; ctr++)
	//			{
	//				if (ctr == 2)
	//					values.Add(DiceLibrary.Roll2());
	//				else if (ctr == 4)
	//					values.Add(DiceLibrary.Pass());
	//				else
	//					values.Add(DiceLibrary.Roll());
	//			}
	//		foreach (var v in values)
	//		{
	//			Console.WriteLine(v);
				
	//		}

	
	//			Console.WriteLine($"The sum of { values.Count } die is { DiceLibrary.DiceSum(values) }");
	//		}
	//	}

	//public static class DiceLibrary
	//{
	//	static Random rnd = new Random();

	//	public static int Roll()
	//	{

	//		return rnd.Next(1, 7);
	//	}

	//	public static List<Object> Roll2()
	//	{
	//		var rolls = new List<object>();      
	//		 rolls.Add(Roll());
	//		 rolls.Add(Roll());
	//		return rolls;
	//	}

	//	public static int DiceSum(IEnumerable<object> values)
	//	{
	//		var sum = 0;
	//		foreach (var item in values)
	//		{
	//			switch (item)
	//			{
	//				case 0: break;
	//				case int val:
	//					sum += val;
	//					break;
	//				case IEnumerable<object> subList when subList.Any():
	//					sum += DiceSum(subList);
	//					break;
	//				case IEnumerable<object> subList:
	//					break;
	//				case null:
	//					break;
	//				default:
	//					throw new InvalidOperationException("unknown");
	//			}
	//		}
	//		return sum;
	//	}

	//	public static object Pass()
	//	{
	//		if (rnd.Next(0, 2) == 0)
	//			return null;
	//		else
	//			return new List<object>();
	//	}
	}
}
