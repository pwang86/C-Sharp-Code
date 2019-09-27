using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	//abstract class Shape
	//{
	//	public abstract int GetArea();
	//}
	//class Square: Shape
	//{
	//	int side;

	//	public Square(int n) => side = n;

	//	public override int GetArea() => side * side;

	//	static void Main()
	//	{
	//		var sq = new Square(12);
	//		Console.WriteLine($"Area of the square = {sq.GetArea()}");
	//	}
	//}

	abstract class BaseClass
	{
		// when int _x = 100; it is internal by default, cannot be accessed in Square class
		protected int _x = 100;
		protected int _y = 150;
		public abstract void AbstractMethod();
		public abstract int X { get; }
		public abstract int Y { get; }
	}

	class Square : BaseClass {
		// must have override, otherwise error
		public override void AbstractMethod()
		{
			_x++;
			_y++;
		}

		public override int X
		{
			get
			{
				return _x + 10;
			}
		}

		public override int Y
		{
			get
			{
				return _y + 10;
			}
		}

	//	static void Main()
	//	{
	//		var o = new Square();
	//		o.AbstractMethod();
	//		Console.WriteLine($"x = {o.X}, y = {o.Y}");

	//		// lambda expression
	//		int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
	//		var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
	//		Console.WriteLine(string.Join(" ", firstSmallNumbers));
	//	}
	}
}
