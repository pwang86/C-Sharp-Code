using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
	class GroupJoinDemo
	{
		static void Main()
		{
			Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
			Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
			Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
			Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };

			Pet barley = new Pet { Name = "Barley", Owner = terry };
			Pet boots = new Pet { Name = "Boots", Owner = terry };
			Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
			Pet bluemoon = new Pet { Name = "Blue Moon", Owner = terry };
			Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

			// Create two lists.
			List<Person> people = new List<Person> { magnus, terry, charlotte, arlene };
			List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

			var queryTwoSources = from person in people
								  join pet in pets on person equals pet.Owner into gj
								  select new { OwnerName = person.FirstName, Pets = gj };

			// Create XML
			XElement ownerAndPets = new XElement("PetOwners",
				from person in people
				join pet in pets on person equals pet.Owner into gj
				select new XElement("Person",
					new XAttribute("FirstName", person.FirstName),
					new XAttribute("LastName", person.LastName),
					from subpet in gj
					select new XElement("Pet", subpet.Name)));
			Console.WriteLine(ownerAndPets);

			foreach (var item in queryTwoSources)
			{
				Console.WriteLine($"{item.OwnerName}: ");
				foreach (var inner in item.Pets)
				{
					Console.WriteLine($" {inner.Name}");
				}
			}
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

	}
}
