using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class DynamicPredicates:StudentClass
	{
		static void Main(string[] args)
		{
			string[] ids = { "111", "114", "112" };
			// QueryByID(ids);

			// Read input (1-4)
			Console.WriteLine("Please input number from 1 to 4: ");
			string input =Console.ReadLine();
			QueryByYear(input);

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		static void QueryByID(string[] ids)
		{
			var queryNames = from student in students
							 let i = student.ID.ToString()
							 where ids.Contains(i)
							 select new { student.LastName, student.ID };
			foreach (var item in queryNames)
			{
				Console.WriteLine($"Name is {item.LastName}, ID is {item.ID}");
			}
		}

		static void QueryByYear(string level)
		{
			GradeLevel year = (GradeLevel)Convert.ToInt32(level);
			IEnumerable<Student> studentQuery = null;
			switch (year)
			{
				case GradeLevel.FirstYear:
					studentQuery = from student in students
								   where student.Year == GradeLevel.FirstYear
								   select student;
					break;
				case GradeLevel.SecondYear:
					studentQuery = from student in students
								   where student.Year == GradeLevel.SecondYear
								   select student;
					break;
				case GradeLevel.ThirdYear:
					studentQuery = from student in students
								   where student.Year == GradeLevel.ThirdYear
								   select student;
					break;
				case GradeLevel.FourthYear:
					studentQuery = from student in students
								   where student.Year == GradeLevel.FourthYear
								   select student;
					break;
				default:
					break;
			}

			Console.WriteLine($"The following students are at level {year}");
			foreach (var item in studentQuery)
			{
				Console.WriteLine($"{item.LastName}: {item.ID}");
			}
		}
	}
}
