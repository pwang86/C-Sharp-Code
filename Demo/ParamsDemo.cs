using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class ParamsDemo
	{
		public static void UseParams(params int[] list)
		{
			for (int i = 0; i < list.Length; i++)
			{
				Console.Write(list[i] + " ");
			}
			Console.WriteLine();
		}

		public static void UseParams2(params object[] list)
		{
			for (int i = 0; i < list.Length; i++)
			{
				Console.Write(list[i] + " ");
			}
			Console.WriteLine();
		}
		static void Main()
		{
			UseParams(1, 2, 3, 4);
			UseParams2(1, "a", "test");

			UseParams2();

			int[] myIntArray = { 5, 6, 7, 8, 9 };
			UseParams(myIntArray);

			object[] myObjArray = { 2, 'b', "test", "again" };
			UseParams2(myObjArray);

			UseParams2(myIntArray);
		}
	}
}
