using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public sealed class SingletonDemo
	{
		// Version 1, not thread safe
		private static SingletonDemo instance = null;

		private SingletonDemo() { }

		public static SingletonDemo Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SingletonDemo();
				}
				return instance;
			}
		}
	}
}
