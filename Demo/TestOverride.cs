using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class TestOverride
	{
		public class Employee
		{
			public string name;

			// it may be accessed only by this class and derived classes.
			protected decimal basepay;

			public Employee(string name, decimal basepay)
			{
				this.name = name;
				this.basepay = basepay;
			}

			public virtual decimal CalculatePay()
			{
				return basepay;
			}
		}

		public class SalesEmployee : Employee
		{
			private decimal salesbonus;

			public SalesEmployee(string name, decimal basepay, decimal salesbonus) : base(name, basepay)
			{
				this.salesbonus = salesbonus;
			}

			public override decimal CalculatePay()
			{
				return basepay + salesbonus;
			}
		}

		static void Main()
		{
			var employee1 = new SalesEmployee("Rob", 1000, 500);
			var employee2 = new Employee("Bob", 1200);

			Console.WriteLine("Employee " + employee1.name + " earned: " + employee1.CalculatePay());

			Console.WriteLine("Employee " + employee2.name + " earned: " + employee2.CalculatePay());
		}
	}
}
