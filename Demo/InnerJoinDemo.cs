using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class InnerJoinDemo
	{
		
		//static void Main()
		//{
		//	// Demo 1.
		//	//var queryTwoSources = from p1 in eeople
		//	//					  join p2 in eets on p1 equals p2.owner
		//	//					  select new { OwnerName = p1.FirstName, PetName = p2.Name };

		//	// Demo2.
		//	//var queryTwoSources = from e in employees
		//	//					  join s in Students
		//	//					  on new { e.FirstName, e.LastName }
		//	//					  equals new { s.FirstName, s.LastName }
		//	//					  select e.FirstName + " " + e.LastName;

		//	// Demo3
		//	Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
		//	Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
		//	Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
		//	Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
		//	Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };
		//	Person phyllis = new Person { FirstName = "Phyllis", LastName = "Harris" };

		//	Cat barley = new Cat { Name = "Barley", Owner = terry };
		//	Cat boots = new Cat { Name = "Boots", Owner = terry };
		//	Cat whiskers = new Cat { Name = "Whiskers", Owner = charlotte };
		//	Cat bluemoon = new Cat { Name = "Blue Moon", Owner = rui };
		//	Cat daisy = new Cat { Name = "Daisy", Owner = magnus };

		//	Dog fourwheeldrive = new Dog { Name = "Four Wheel Drive", Owner = phyllis };
		//	Dog duke = new Dog { Name = "Duke", Owner = magnus };
		//	Dog denim = new Dog { Name = "Denim", Owner = terry };
		//	Dog wiley = new Dog { Name = "Wiley", Owner = charlotte };
		//	Dog snoopy = new Dog { Name = "Snoopy", Owner = rui };
		//	Dog snickers = new Dog { Name = "Snickers", Owner = arlene };

		//	// Create three lists.
		//	List<Person> people =
		//		new List<Person> { magnus, terry, charlotte, arlene, rui, phyllis };
		//	List<Cat> cats =
		//		new List<Cat> { barley, boots, whiskers, bluemoon, daisy };
		//	List<Dog> dogs =
		//		new List<Dog> { fourwheeldrive, duke, denim, wiley, snoopy, snickers };

		//	var queryThreeSources = from p in people
		//							join c in cats on p equals c.Owner
		//							join d in dogs on
		//							new { Owner = p, Letter = c.Name.Substring(0, 1) }
		//							equals new { d.Owner, Letter = d.Name.Substring(0, 1) }
		//							select new { CatName = c.Name, DogName = d.Name };
		//	foreach (var item in queryThreeSources)
		//	{
		//		Console.WriteLine($"{item.CatName} : {item.DogName}");
		//	}

		//	// Demo4
		//	//var queryTwoSources = from p1 in people
		//	//					  join p2 in pets on p1 equals p2.Owner
		//	//					  select new { OwnerName = p1.FirstName, PetName = p2.Name };
		//	//var queryTwoSources2 = from p1 in people
		//	//						join p2 in pets on p1 equals p2.Owner into gj
		//	//						from sub in gj
		//	//						select new { OwnerName = p1.FirstName, PetName = p2.Name };

		//}
	}
	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	class Pet
	{
		public string Name { get; set; }
		public Person Owner { get; set; }
	}

	class Cat : Pet
	{ }

	class Dog : Pet
	{ }
}
