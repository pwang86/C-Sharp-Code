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

		public class StudentClass
		{
			protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear};
			protected class Student
			{
				public string FirstName { get; set; }
				public string LastName { get; set; }
				public int ID { get; set; }
				public GradeLevel Year;
				public List<int> ExamScores;
			}
			protected static List<Student> students = new List<Student>
			{
				new Student {FirstName = "Terry", LastName = "Adams", ID = 120,
					Year = GradeLevel.SecondYear,
					ExamScores = new List<int>{ 99, 82, 81, 79}},
				new Student {FirstName = "Fadi", LastName = "Fakhouri", ID = 116,
					Year = GradeLevel.ThirdYear,
					ExamScores = new List<int>{ 99, 86, 90, 94}},
				new Student {FirstName = "Hanying", LastName = "Feng", ID = 117,
					Year = GradeLevel.FirstYear,
					ExamScores = new List<int>{ 93, 92, 80, 87}},
				new Student {FirstName = "Cesar", LastName = "Garcia", ID = 114,
					Year = GradeLevel.FourthYear,
					ExamScores = new List<int>{ 97, 89, 85, 82}},
				new Student {FirstName = "Debra", LastName = "Garcia", ID = 115,
					Year = GradeLevel.ThirdYear,
					ExamScores = new List<int>{ 35, 72, 91, 70}},
				new Student {FirstName = "Hugo", LastName = "Garcia", ID = 118,
					Year = GradeLevel.SecondYear,
					ExamScores = new List<int>{ 92, 90, 83, 78}},
				new Student {FirstName = "Sven", LastName = "Mortensen", ID = 113,
					Year = GradeLevel.FirstYear,
					ExamScores = new List<int>{ 88, 94, 65, 91}},
				new Student {FirstName = "Claire", LastName = "O'Donnell", ID = 112,
					Year = GradeLevel.FourthYear,
					ExamScores = new List<int>{ 75, 84, 91, 39}},
				new Student {FirstName = "Svetlana", LastName = "Omelchenko", ID = 111,
					Year = GradeLevel.SecondYear,
					ExamScores = new List<int>{ 97, 92, 81, 60}},
				new Student {FirstName = "Lance", LastName = "Tucker", ID = 119,
					Year = GradeLevel.ThirdYear,
					ExamScores = new List<int>{ 68, 79, 88, 92}},
				new Student {FirstName = "Michael", LastName = "Tucker", ID = 122,
					Year = GradeLevel.FirstYear,
					ExamScores = new List<int>{ 94, 92, 91, 91}},
				new Student {FirstName = "Eugene", LastName = "Zabokritski", ID = 121,
					Year = GradeLevel.FourthYear,
					ExamScores = new List<int>{ 96, 85, 91, 60}}
			};

			public void QueryHighScores(int exam, int score)
			{
				var highScores = from student in students
								 where student.ExamScores[exam] > score
								 select new { Name = student.FirstName, score = student.ExamScores[exam] };
				foreach (var item in highScores)
				{
					Console.WriteLine($"{item.Name,-15}{item.score}");
				}
			}

			public void QueryNestedGroup()
			{
				var queryStudent = from student in students
								   group student by student.Year into newGroup1
								   from ng in 
								      (from istudent in newGroup1
									   group istudent by istudent.LastName)
								   group ng by newGroup1.Key;
				foreach (var outer in queryStudent)
				{
					Console.WriteLine($"Year is: {outer.Key}");
					foreach (var inner in outer)
					{
						Console.WriteLine($"\tName begins with: {inner.Key}");
						foreach (var inneritem in inner)
						{
							Console.WriteLine($"\t\tName is: {inneritem.LastName}");
						}
					}
				}
			}


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

			// Demo7 nested group
			public void QueryMax()
			{

				//var queryStudent = from student in students
				//				   group student by student.Year into newGroup
				//				   select new
				//				   {
				//					   Greade = newGroup.Key,
				//					   Score =
				//					 (from istudent in newGroup
				//					  select istudent.ExamScores.Average()).Max()
				//				   };
				//using lambda
				var queryStudent = students.GroupBy(s => s.Year).Select(studentGroup => new
				{
					Grade = studentGroup.Key,
					Score = studentGroup.Select(s2 => s2.ExamScores.Average()).Max()
				});
				int count = queryStudent.Count();
				Console.WriteLine($"{count}");

				foreach (var item in queryStudent)
				{
					Console.WriteLine($"highest score is: {item.Score}");
				}
			}

		}
		//public class Program {
		//	public static void Main()
		//	{
		//		StudentClass sc = new StudentClass();
		//		//sc.QueryHighScores(1, 90);
		//		//sc.QueryNestedGroup();
		//		sc.QueryMax();
		//	}
		//}
		



	}
}
