using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class StaticConstructorDemo
	{
		protected static readonly DateTime globalStartTime;

		protected int RouteNumber { get; set; }

		static StaticConstructorDemo()
		{
			globalStartTime = DateTime.Now;

			Console.WriteLine("Static constructor sets global start time to {0}", globalStartTime.ToLongTimeString());
		}

		public StaticConstructorDemo(int routeNum)
		{
			RouteNumber = routeNum;
			Console.WriteLine("Bus #{0} is created.", RouteNumber);
		}

		public void Drive()
		{
			TimeSpan elapsedTime = DateTime.Now - globalStartTime;

			Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.", this.RouteNumber, elapsedTime.Milliseconds, globalStartTime.ToShortTimeString());
		}
	}

	class TestDemo
	{
		static void Main()
		{
			StaticConstructorDemo sd1 = new StaticConstructorDemo(71);

			StaticConstructorDemo sd2 = new StaticConstructorDemo(72);

			sd1.Drive();

			System.Threading.Thread.Sleep(25);

			sd2.Drive();

			System.Console.WriteLine("Press any key");
			System.Console.ReadKey();
		}
	}
}
