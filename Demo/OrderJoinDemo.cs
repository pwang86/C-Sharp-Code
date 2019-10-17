using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class OrderJoinDemo
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

		List<Category> categories = new List<Category>()
		{
			new Category(){Name="Beverages", ID=001},
			new Category(){ Name="Condiments", ID=002},
			new Category(){ Name="Vegetables", ID=003},
			new Category() {  Name="Grains", ID=004},
			new Category() {  Name="Fruit", ID=005}
		};

		List<Product> products = new List<Product>()
		{
			new Product{Name="Cola",  CategoryID=001},
			new Product{Name="Tea",  CategoryID=001},
			new Product{Name="Mustard", CategoryID=002},
			new Product{Name="Pickles", CategoryID=002},
			new Product{Name="Carrots", CategoryID=003},
			new Product{Name="Bok Choy", CategoryID=003},
			new Product{Name="Peaches", CategoryID=005},
			new Product{Name="Melons", CategoryID=005},
		};

		//static void Main()
		//{
		//	OrderJoinDemo app = new OrderJoinDemo();
		//	app.OrderJoin();

		//	Console.WriteLine("Press any key");
		//	Console.ReadKey();
		//}
		void OrderJoin()
		{
			var query = from c in categories
						join p in products on c.ID equals p.CategoryID into gj
						orderby c.Name
						select new
						{
							CategoryName = c.Name,
							ProductsName = from p1 in gj
										  orderby p1.Name
										  select p1
						};

			foreach (var item in query)
			{
				Console.WriteLine($"{item.CategoryName}");
				foreach (var inner in item.ProductsName)
				{
					Console.WriteLine($"   {inner.Name,-10} {inner.CategoryID}");
				}
				
			
			}
		}
	}
}
