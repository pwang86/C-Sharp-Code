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

			//// 2. overflow
			//double a = 1.0 / 0.0;
			//Console.WriteLine(a);
			//Console.WriteLine(double.IsInfinity(a));

			//Console.WriteLine(double.MaxValue + double.MaxValue);

			//double b = 0.0 / 0.0;
			//Console.WriteLine(b);
			//Console.WriteLine(double.IsNaN(b));

			//3. Round-off error
			Console.WriteLine(.41f % .2f);

			float x = 0.1f;
			float y = 3 * x;
			Console.WriteLine(x == y);

			double a = 0.1;
			double b = 3 * a;
			double c = 0.3;
			double f = 3 * a;
			Console.WriteLine(b == c);
			Console.WriteLine(b.Equals(c));
			Console.WriteLine(b == f);
			Console.WriteLine(b);

			decimal d = 1 / 3.0m;
			decimal e = 3 * d;
			Console.WriteLine(e == 1.0m);
			Console.WriteLine(e);
		}
	}
}
