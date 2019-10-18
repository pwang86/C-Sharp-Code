using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class CustomJoinDemo
	{
		class Product
		{
			public string Name { get; set; }
			public int CategoryID { get; set; }
		}

		class Category
		{
			public string Name { get; set; }
			public int ID { get; set; }
		}

		// Specify the first data source.
		List<Category> categories = new List<Category>()
 {
	 new Category(){Name="Beverages", ID=001},
	 new Category(){ Name="Condiments", ID=002},
	 new Category(){ Name="Vegetables", ID=003},
 };

		// Specify the second data source.
		List<Product> products = new List<Product>()
{
   new Product{Name="Tea",  CategoryID=001},
   new Product{Name="Mustard", CategoryID=002},
   new Product{Name="Pickles", CategoryID=002},
   new Product{Name="Carrots", CategoryID=003},
   new Product{Name="Bok Choy", CategoryID=003},
   new Product{Name="Peaches", CategoryID=005},
   new Product{Name="Melons", CategoryID=005},
   new Product{Name="Ice Cream", CategoryID=007},
   new Product{Name="Mackerel", CategoryID=012},
 };
		//static void Main()
		//{
		//	CustomJoinDemo app = new CustomJoinDemo();
		//	app.NonEquijoin();

		//	Console.WriteLine("Press any key to exit.");
		//	Console.ReadKey();
		//}
		void NonEquijoin()
		{
			var query = from p in products
						let categoryId = from c in categories
										 select c.ID
						where categoryId.Contains(p.CategoryID) == true
						select new { Product = p.Name, categoryID = p.CategoryID };

			foreach (var item in query)
			{
				Console.WriteLine($"{item.categoryID,-5}{item.Product}");
			}

		}
	}
}
