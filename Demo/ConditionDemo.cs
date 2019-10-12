﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class ConditionDemo
	{
		static void Main()
		{
			var smallArray = new int[] { 1, 2, 3, 4, 5 };
			var largeArray = new int[] { 10, 20, 30, 40, 50 };

			int index = 7;
			ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
			refValue = 0;

			index = 2;
			((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

			Console.WriteLine(string.Join(" ", smallArray));
			Console.WriteLine(string.Join(" ", largeArray));
		}
	}
}
