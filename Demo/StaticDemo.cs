using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class StaticDemo
	{
		public class Employee
		{
			public static int counter;
			public static int AddEmployee()
			{
				return ++counter;
			}
		}

		class MainClass : Employee
		{
			static void Main()
			{
				string n = Console.ReadLine();
				Employee.counter = Int32.Parse(n);
				Employee.AddEmployee();

				Console.WriteLine($"new number of employees: {Employee.counter}");
			}
		}
	}
}
