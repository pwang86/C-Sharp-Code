﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class JoinDemo
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
		   new Category {Name="Beverages", ID=001},
		   new Category {Name="Condiments", ID=002},
		   new Category {Name="Vegetables", ID=003},
		   new Category {Name="Grains", ID=004},
		   new Category {Name="Fruit", ID=005}
		};

		List<Product> products = new List<Product>()
		{
			new Product {Name="Cola",  CategoryID=001},
			new Product {Name="Tea",  CategoryID=001},
			new Product {Name="Mustard", CategoryID=002},
			new Product {Name="Pickles", CategoryID=002},
			new Product {Name="Carrots", CategoryID=003},
			new Product {Name="Bok Choy", CategoryID=003},
			new Product {Name="Peaches", CategoryID=005},
			new Product {Name="Melons", CategoryID=005},
		};

		static void Main()
		{
			JoinDemo app = new JoinDemo();
			app.InnerJoin();
			app.GroupJoin();
			app.GroupInnerJoin();
			app.GroupJoin3();
			app.LeftOuterJoin();
			app.LeftOuterJoin2();

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		void InnerJoin()
		{
			var innerJoinQuery =
				from category in categories
				join prod in products on category.ID equals prod.CategoryID
				select new { Category = category.ID, Product = prod.Name };
		}

		void GroupJoin()
		{
			var groupJoinQuery =
				from category in categories
				join prod in products on category.ID equals prod.CategoryID into prodGroup
				select prodGroup;
			int totalItems = 0;
			Console.WriteLine("Simple GroupJoin:");

			foreach (var prodGrouping in groupJoinQuery)
			{
				Console.WriteLine("Group:");
				foreach (var item in prodGrouping)
				{
					totalItems++;
					Console.WriteLine("  {0,-10}{1}", item.Name, item.CategoryID);
				}
			}
			Console.WriteLine("Unshaped GroupJoin: {0} items in {1} unnamed groups", totalItems, groupJoinQuery.Count());
			Console.WriteLine(System.Environment.NewLine);
		}

		void GroupInnerJoin()
		{
			var groupJoinQuery2 =
			   from category in categories
			   orderby category.ID
			   join prod in products on category.ID equals prod.CategoryID into prodGroup
			   select new
			   {
				   Category = category.Name,
				   Products = from prod2 in prodGroup
							  orderby prod2.Name
							  select prod2
			   };

			//Console.WriteLine("GroupInnerJoin:");
			int totalItems = 0;

			Console.WriteLine("GroupInnerJoin:");
			foreach (var productGroup in groupJoinQuery2)
			{
				Console.WriteLine(productGroup.Category);
				foreach (var prodItem in productGroup.Products)
				{
					totalItems++;
					Console.WriteLine("  {0,-10} {1}", prodItem.Name, prodItem.CategoryID);
				}
			}
			Console.WriteLine("GroupInnerJoin: {0} items in {1} named groups", totalItems, groupJoinQuery2.Count());
			Console.WriteLine(System.Environment.NewLine);
		}

		void GroupJoin3()
		{
			var groupJoinQuery3 =
			   from category in categories
			   join product in products on category.ID equals product.CategoryID into prodGroup
			   from prod in prodGroup
			   orderby prod.CategoryID
			   select new { Category = prod.CategoryID, ProductName = prod.Name };

			//Console.WriteLine("GroupInnerJoin:");
			int totalItems = 0;

			Console.WriteLine("GroupJoin3:");
			foreach (var item in groupJoinQuery3)
			{
				totalItems++;
				Console.WriteLine("   {0}:{1}", item.ProductName, item.Category);
			}

			Console.WriteLine("GroupJoin3: {0} items in 1 group", totalItems);
			Console.WriteLine(System.Environment.NewLine);
		}

		void LeftOuterJoin()
		{
			var leftOuterQuery =
			  from category in categories
			  join prod in products on category.ID equals prod.CategoryID into prodGroup
			  select prodGroup.DefaultIfEmpty(new Product() { Name = "Nothing!", CategoryID = category.ID });

			// Store the count of total items (for demonstration only).
			int totalItems = 0;

			Console.WriteLine("Left Outer Join:");

			// A nested foreach statement  is required to access group items
			foreach (var prodGrouping in leftOuterQuery)
			{
				Console.WriteLine("Group:");
				foreach (var item in prodGrouping)
				{
					totalItems++;
					Console.WriteLine("  {0,-10}{1}", item.Name, item.CategoryID);
				}
			}
			Console.WriteLine("LeftOuterJoin: {0} items in {1} groups", totalItems, leftOuterQuery.Count());
			Console.WriteLine(System.Environment.NewLine);
		}

		void LeftOuterJoin2()
		{
			var leftOuterQuery2 =
			 from category in categories
			 join prod in products on category.ID equals prod.CategoryID into prodGroup
			 from item in prodGroup.DefaultIfEmpty()
			 select new { Name = item == null ? "Nothing!" : item.Name, CategoryID = category.ID };

			Console.WriteLine("LeftOuterJoin2: {0} items in 1 group", leftOuterQuery2.Count());
			// Store the count of total items
			int totalItems = 0;

			Console.WriteLine("Left Outer Join 2:");

			// Groups have been flattened.
			foreach (var item in leftOuterQuery2)
			{
				totalItems++;
				Console.WriteLine("{0,-10}{1}", item.Name, item.CategoryID);
			}
			Console.WriteLine("LeftOuterJoin2: {0} items in 1 group", totalItems);
		}
	}
}
