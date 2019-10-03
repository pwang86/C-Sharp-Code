using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class OverFlowTest
	{
		// all member declare static, which belongs to the type itself,not specific object
		// const int ConstantMax = int.MaxValue;
		static int maxIntValue = 2147483647;

		static int CheckedMethod()
		{
			int z = 0;
			try
			{
				z = checked(maxIntValue + 10);
			}
			catch (System.OverflowException e)
			{
				Console.WriteLine("CHECKED AND CAUGHT: " + e.ToString());
			}
			return z;
		}

		static int UncheckedMethod()
		{
			int z = 0;
			try
			{
				z = maxIntValue + 10;
			}
			catch (System.OverflowException e)
			{
				Console.WriteLine("CHECKED AND CAUGHT: " + e.ToString());
			}
			return z;
		}

		static void Main()
		{
			Console.WriteLine("\nCHECKED OUTPUT VALUE IS: {0}", CheckedMethod());
			Console.WriteLine("UNCHECKED OUTPUT VALUE IS: {0}", UncheckedMethod());
		}
	}
}
