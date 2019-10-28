using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public sealed class SingletonDemo
	{
		//// Version 1, not thread safe
		//private static SingletonDemo instance = null;

		//private SingletonDemo() { }

		//public static SingletonDemo Instance
		//{
		//	get
		//	{
		//		if (instance == null)
		//		{
		//			instance = new SingletonDemo();
		//		}
		//		return instance;
		//	}
		//}

		//// Version 2, simple thread safe
		//private static SingletonDemo instance = null;
		//private static readonly object padlock = new object();

		//SingletonDemo() { }

		//public static SingletonDemo Instance
		//{
		//	get
		//	{
		//		lock (padlock)
		//		{
		//			if (instance == null)
		//			{
		//				instance = new SingletonDemo();
		//			}
		//			return instance;
		//		}
		//	}
		//}

		// Version 3, thread safe without using locks
		private static readonly SingletonDemo instance = new SingletonDemo();
		static SingletonDemo() { }
		private SingletonDemo() { }
		public static SingletonDemo Instance
		{
			get
			{
				return instance;
			}
		}
	}
}
