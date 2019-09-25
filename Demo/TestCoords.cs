using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public struct Coords
	{
		public int x, y;
		public Coords(int p1, int p2)
		{
			x = p1;
			y = p2;
		}
	}

	public class TestCoords
	{
		static void Main()
		{
			var coords1 = new Coords();
			var coords2 = new Coords(10, 10);

			Console.Write("Coords 1: ");
			Console.WriteLine($"x = {coords1.x}, y = {coords1.y}");

			Console.Write("Coords 2: ");
			Console.WriteLine($"x = {coords2.x}, y = {coords2.y}");

	
		}
	}

}
