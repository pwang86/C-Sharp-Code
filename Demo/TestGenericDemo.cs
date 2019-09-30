using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class TestGenericDemo
	{
		static void Main()
		{
			GenericDemo<int> list = new GenericDemo<int>();

			for (int x = 0; x < 10; x++)
			{
				list.AddHead(x);
			}

			foreach (int i in list)
			{
				System.Console.Write(i + " ");
			}
			System.Console.WriteLine("\nDone");
		}
	}
}
