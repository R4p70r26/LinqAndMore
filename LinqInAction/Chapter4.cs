using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqInAction.BusinessObjects;

namespace LinqInAction
{
    class Chapter4
    {
		public void Listing42()
		{
			Object[] arr = { "string", 12, true, 'a' };

			var query = arr.Select(item => item.GetType().Name).OrderBy(type => type);

			ObjectDumper.Write(query);

		}


		public void Listing43()
		{
			Book[] books = {
				new Book{ Title = "LINQ in Action" },
				new Book{ Title = "LINQ for Fun" },
				new Book{ Title = "Extreme LINQ" }
			};

			var query = books.Where(book => book.Title.Contains("Action")).Select(book => book.Title);

			ObjectDumper.Write(query);

		}

		public void Listing44()
		{
			List<Book> books = new List<Book>() {
				new Book{ Title = "LINQ in Action" },
				new Book{ Title = "LINQ for Fun" },
				new Book{ Title = "Extreme LINQ" }
			};

			var query = books.Where(book => book.Title.Contains("Action")).Select(book => book.Title);

			ObjectDumper.Write(query);
		}

		public void Listing45()
		{
			Dictionary<int, string> Numbers;
			Numbers = new Dictionary<int, string>();
			Numbers.Add(0, "zero");
			Numbers.Add(1, "adin");
			Numbers.Add(2, "dba");
			Numbers.Add(3, "tri");
			Numbers.Add(4, "chitirie");

			var evenFrenchNumbers =
				from entry in Numbers
				where (entry.Key % 2) == 0
				select entry.Value;

			ObjectDumper.Write(evenFrenchNumbers);
		}

		public void Listing46()
		{
			var count = "Non-letter characters in this string: 8".Where(c => !Char.IsLetter(c)).Count();
			Console.WriteLine(count);
		}


		///nice explanation of methods 
		///157
		///
	}
}
