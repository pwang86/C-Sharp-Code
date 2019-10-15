using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class LINQDemo
	{
		//// Demo 1
		//IEnumerable<string> QueryMethod1(ref int[] ints)
		//{
		//	var intsToString = from i in ints
		//					   where i > 4
		//					   select i.ToString();
		//	return intsToString;
		//}

		//void QueryMethod2(ref int[] ints, out IEnumerable<string> returnQ)
		//{
		//	var initsToString = from i in ints
		//						where i < 4
		//						select i.ToString();
		//	returnQ = initsToString;
		//}

		//static void Main()
		//{
		//	LINQDemo app = new LINQDemo();

		//	int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		//	var myQuery1 = app.QueryMethod1(ref nums);
		//	Console.WriteLine("Results of myQuery1: ");
		//	foreach (string s in myQuery1)
		//	{
		//		Console.WriteLine(s);
		//	}

		//	IEnumerable<string> myQuery2;
		//	app.QueryMethod2(ref nums, out myQuery2);
		//	Console.WriteLine("\nResults of executing myQuery2: ");

		//	foreach (string s in myQuery2)
		//	{
		//		Console.WriteLine(s);
		//	}

		//	myQuery1 = from item in myQuery1
		//			   orderby item descending
		//			   select item;
		//	Console.WriteLine("\nResults of executing modified myQuery1: ");
		//	foreach (string s in myQuery1)
		//	{
		//		Console.WriteLine(s);
		//	}
		//}

		//// Demo2
		//static List<int> numbers = new List<int>() { 1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
		//static void Main()
		//{
		//	IEnumerable<int> queryFactorOfFour = from num in numbers
		//										 where num % 4 == 0
		//										 select num;
		//	Console.WriteLine(string.Join(", ",queryFactorOfFour));

		//	List<int> factorofFourList = queryFactorOfFour.ToList();
		//	Console.WriteLine(factorofFourList[2]);
		//	factorofFourList[2] = 0;
		//	Console.WriteLine(factorofFourList[2]);
		// }
		//// Demo3
		//var queryStudent = from student in students
		//				   group student by student.LastName[0];

		//// Demo4
		//static int GetPercentile(int[] scores)
		//{
		//	double a = scores.Average();
		//	return a > 0 ? (int)a / 10 : 0;
		//}
		//var queryStudent = from student in students
		//				   let percentile = GetPercentile(student.student.ExamScores)
		//				   Group new {student.FirstName,student.LastName } by percentile into percentGroup
		//				   orderby percentGroup.Key
		//				   select percentGroup;

		//// Demo5
		//var queryStudent = from student in students
		//				   group new { student.FirstName,student.LastName}  by student.ExamScores.Average() > 75 into studentGroup
		//				   select studentGroup;

		//// Demo6
		//var queryStudent = from student in students
		//				   group student by new { FirstLetter = student.LastName[0], Score = student.ExamScore[0] > 85 } into studentGroup
		//				   orderby studentGroup.key.FirstLetter
		//				   select studentGroup;


		
	}
}
