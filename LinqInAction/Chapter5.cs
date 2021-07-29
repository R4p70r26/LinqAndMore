using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqInAction.BusinessObjects;

namespace LinqInAction
{
    class Chapter5
    {
		public void Listing55()
		{
			var query = from book in SampleData.Books
						group book by new { book.Publisher, book.Subject }
			into grouping
						select new { Publisher = grouping.Key.Publisher.Name, Subject = grouping.Key.Subject.Name, Books = grouping };

			ObjectDumper.Write(query);
		}

		public void Listing56()
		{
			var query =
				from book in SampleData.Books
				group book.Title by new { book.Publisher, book.Subject } into grouping
				select new
				{
					Publisher = grouping.Key.Publisher.Name,
					Subject = grouping.Key.Subject.Name,
					Titles = grouping
				};

			ObjectDumper.Write(query);

		}

		//dynamic query
		public void Listing57()
		{
			int minPageCount = 200;

			var books = from book in SampleData.Books
						where book.PageCount >= minPageCount
						select book;

			Console.WriteLine("Books with at least {0} pages: {1}", minPageCount, books.Count());

			minPageCount = 50;
			Console.WriteLine("Books with at least {0} pages: {1}", minPageCount, books.Count());

		}

		public void Listing58(int minPageCount)
		{
			var books = from book in SampleData.Books
						where book.PageCount >= minPageCount
						select book;

			Console.WriteLine("Books with at least {0} pages: {1}", minPageCount, books.Count());

		}

		public void Listing519()
		{
			var query = from line in File.ReadAllLines("books.csv")
						where !line.StartsWith("#")
						let parts = line.Split(',')
						select new { ISBN = parts[0], Title = parts[1], Publisher = parts[3] };


			ObjectDumper.Write(query);
		}

		public void Listing520()
		{
			var books =
				from line in File.ReadAllLines("books.csv")
				where !line.StartsWith("#")
				let parts = line.Split(',')
				select new
				{
					Isbn = parts[0],
					Title = parts[1],
					Publisher = parts[3],
					Authors =
			from authorFullName in parts[2].Split(';')
			let authorNameParts = authorFullName.Split(' ')
			select new
			{
				FirstName = authorNameParts[0],
				LastName = authorNameParts[1]
			}
				};

			ObjectDumper.Write(books, 1);
		}

		public void Listing521()
		{
			var books =
				from line in File.ReadAllLines("books.csv")
				where !line.StartsWith("#")
				let parts = line.Split(',')
				select new Book
				{
					Isbn = parts[0],
					Title = parts[1],
					Publisher = new Publisher { Name = parts[3] },
					Authors =
			from authorFullName in parts[2].Split(';')
			let authorNameParts = authorFullName.Split(' ')
			select new Author
			{
				FirstName = authorNameParts[0],
				LastName = authorNameParts[1]
			}
				};

			ObjectDumper.Write(books, 1);
		}

		public void Listing522()
		{
			List<Book> books = new List<Book>();

			foreach (String line in File.ReadAllLines("books.csv"))
			{
				if (line.StartsWith("#"))
				{
					continue;
				}

				String[] parts = line.Split(',');
				Book book = new Book();
				book.Isbn = parts[0];
				book.Title = parts[1];
				Publisher publisher = new Publisher();
				publisher.Name = parts[3];
				book.Publisher = publisher;

				List<Author> authors = new List<Author>();
				foreach (String authorFullName in parts[2].Split(';'))
				{
					String[] authorNameParts = authorFullName.Split(' ');
					Author author = new Author();
					author.FirstName = authorNameParts[0];
					author.LastName = authorNameParts[1];
					authors.Add(author);
				}
				book.Authors = authors;

				books.Add(book);
			}

		}




		public void Listing525()
		{
			SampleData.Books.Where(book => book.PageCount > 150).ForEach(book => Console.WriteLine(book.Title));
		}

		public void Listing526()
		{
			(from book in SampleData.Books
			 where book.PageCount > 150
			 select book).ForEach(book => Console.WriteLine(book.Title));
		}

		public void Listing527()
		{
			SampleData.Books.Where(book => book.PageCount > 150).ForEach(book => {
				book.Title += " (long)";
				Console.WriteLine(book.Title);
			});
		}


		public void Listing529()
		{
			using (StreamReader reader = new StreamReader("books.csv"))
			{
				var books = from line in reader.Lines()
							where !line.StartsWith("#")
							let parts = line.Split(',')
							select new { Title = parts[1], Publisher = parts[3], Isbn = parts[0] };

				ObjectDumper.Write(books, 1);
			}
		}

		public void Listing530()
		{
			using (StreamReader reader = new StreamReader("books.csv"))
			{
				var books = from line in reader.Lines()
							where !line.StartsWith("#")
							let parts = line.Split(',')
							select new { Title = parts[1], Publisher = parts[3], Isbn = parts[0] };

				foreach (var element in books)
				{
					Console.WriteLine(element);
				}
			}
		}

	}



	#region extension classes
	static class ExteBook
	{
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> func)
		{
			foreach (var item in source)
			{
				func(item);
			}
		}
	}

	static class StreamReaderEnumerable
	{
		public static IEnumerable<string> Lines(this StreamReader source)
		{
			String line;
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}

			while ((line = source.ReadLine()) != null)
			{
				yield return line;
			}
		}
	}


	#endregion
}
