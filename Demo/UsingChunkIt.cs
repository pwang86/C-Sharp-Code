using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class UsingChunkIt
	{
		public class KeyValPair
		{
			public string Key { get; set; }
			public string Value { get; set; }
		}
		//class Program
		//{
		//	public static IEnumerable<KeyValPair> list;
		//	static IEnumerable<IGrouping<string, KeyValPair>> query;

		//	static void Main(string[] args)
		//	{
		//		list = new[]
		//		{
		//	  new KeyValPair{ Key = "A", Value = "We" },
		//		new KeyValPair{ Key = "A", Value = "think" },
		//		new KeyValPair{ Key = "A", Value = "that" },
		//		new KeyValPair{ Key = "B", Value = "Linq" },
		//		new KeyValPair{ Key = "C", Value = "is" },
		//		new KeyValPair{ Key = "A", Value = "really" },
		//		new KeyValPair{ Key = "B", Value = "cool" },
		//		new KeyValPair{ Key = "B", Value = "!" }
		//};
		//		query = list.ChunkBy(p => p.Key);

		//		foreach (var item in query)
		//		{
		//			Console.WriteLine($"{item.Key}");
		//			foreach (var inner in item)
		//			{
		//				Console.WriteLine($"\t{inner.Value}");
		//			}
		//		}
		//	}
		//}

	}
}
