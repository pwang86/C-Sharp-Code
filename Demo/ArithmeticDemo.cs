using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class ArithmeticDemo
	{
		static void Main()
		{
			//// 1. byte example
			//byte a = 200;
			//byte b = 100;

			//var c = a + b;
			//Console.WriteLine(c.GetType());
			//Console.WriteLine(c);

			//a += b;
			//Console.WriteLine(b);

			//Console.WriteLine(a); 
			//// output: 44, because byte is 0 - 255, after +, a becomes 300 which is greater than 256,
			//// so it begins counting again: 300 - 256 = 44.  
			///

			// 2. overflow
			double a = 1.0 / 0.0;
			Console.WriteLine(a);
			Console.WriteLine(double.IsInfinity(a));

			Console.WriteLine(double.MaxValue + double.MaxValue);

			double b = 0.0 / 0.0;
			Console.WriteLine(b);
			Console.WriteLine(double.IsNaN(b));
		}
	}
}
