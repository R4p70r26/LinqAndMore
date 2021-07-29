using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqForDum
{
    class Chapter6
    {
		public void Listing61()
		{

			//            // Add the appropriate text to the list.
			//            cbResult.Items.Add(cbResult.Text);
			//
			//            // Perform the required LINQ update.
			//            String[] CBQuery =
			//               cbResult.Items.Cast<String>().OrderBy(
			//               TheseItems => TheseItems).Select(
			//               TheseItems => 
			//                  TheseItems.Substring(0, 1).ToUpper() + 
			//                  TheseItems.Substring(1, 
			//                     TheseItems.Length - 1).ToLower()).
			//                        ToArray();
			//
			//            // Clear the current Items list.
			//            cbResult.Items.Clear();
			//
			//            // Add the updated list to the Items property.
			//            foreach (String ThisString in CBQuery)
			//               cbResult.Items.Add(ThisString);


		}

		public void Listing62()
		{
			// Define two test arrays.
			String[] First = { "One", "Two", "Three" };
			String[] Second = { "Four", "Five", "Six" };

			// Create the query.
			var ThisQuery = First.Concat<String>(Second);

			// Display the output.
			foreach (String ThisElement in ThisQuery)
				Console.Write(ThisElement + "\r\n");
		}

		//		Listing63
		private enum NumToWord
		{
			Zero,
			One,
			Two,
			Three,
			Four,
			Five,
			Six,
			Seven,
			Eight,
			Nine,
			Ten
		}

		public void Listing63()
		{
			string[] numStr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

			// Create the query.
			var ThisQuery =
				numStr.Where(
					ThisElement => Convert.ToInt32(ThisElement) > 3).
			   Select(ThisElement => (NumToWord)Convert.ToInt32(ThisElement));

			// Display the output.
			foreach (var ThisElement in ThisQuery)
				Console.Write(ThisElement.ToString() + "\r\n");
		}

		public void Listing64()
		{
			// Define a test object.
			Dictionary<String, Object> TestData =
				new Dictionary<string, object>();

			// Fill the test object with data.
			TestData.Add("One", 1);
			TestData.Add("Two", "Two");
			TestData.Add("Three", 3);
			TestData.Add("Four", "Four");
			TestData.Add("Five", 5);
			TestData.Add("Six", "Six");
			TestData.Add("1", 1);
			TestData.Add("2", "somesome");
			TestData.Add("3", "1");
			TestData.Add("4", 2);

			// Create the query.
			var ThisQuery = TestData.Values.OfType<String>();

			// Display the output.
			foreach (String ThisElement in ThisQuery)
				Console.Write(ThisElement + "\r\n");
		}

		public void Listing65()
		{
			// Define a test object.
			List<String> TestData = new List<String>();

			// Create the query.
			var ThisQuery = from TheData in TestData
							select TheData;

			// Display the output.
			foreach (var ThisElement in ThisQuery.DefaultIfEmpty())
				Console.Write(ThisElement + "\r\n");

			// Fill the array with data.
			TestData.Add("One");
			TestData.Add("Two");
			TestData.Add("Three");

			// Display the output again.
			foreach (var ThisElement in ThisQuery.DefaultIfEmpty())
				Console.Write(ThisElement + "\r\n");
		}

		public void Listing67()
		{
			// Define a test object.
			String[] TestData = {"One", "Two", "Three", "Four",
				"Five", "Six", "Seven", "Eight",
				"Nine", "Ten"
			};

			// Create the query.
			var ThisQuery = from ThisElement in TestData
							group ThisElement
						 by ThisElement.Substring(0, 1)
						 into Groups
							orderby Groups.Key
							select Groups;

			var ThisQueryLambda = TestData.GroupBy(
									  ThisElement => ThisElement.Substring(0, 1));

			// Display the output.
			foreach (var ThisElement in ThisQuery)
			{
				Console.Write(ThisElement.Key + "\r\n");
				foreach (String ThisText in ThisElement)
					Console.Write("  " + ThisText + "\r\n");
			}
		}

		public void Listing68()
		{
			// Define a test object.
			String[] TestData = {"One", "Two", "Three", "Four",
				"Five", "Six", "Seven", "Eight",
				"Nine", "Ten"
			};

			// Create the query.
			var ThisQuery =
				TestData.SkipWhile(ThisElement => ThisElement != "Four").
			TakeWhile(ThisElement => ThisElement != "Nine");

			// Display the output.
			foreach (var ThisElement in ThisQuery)
				Console.Write(ThisElement + "\r\n");
		}

		public void Listing69()
		{
			// Define a test object.
			List<MyNumbers> TestData = new List<MyNumbers>();

			// Fill the test object with data.
			TestData.Add(new MyNumbers
			{
				NumName = "Single Digit",
				NumValue = new List<Int32> { 0, 1, 2 }
			});
			TestData.Add(new MyNumbers
			{
				NumName = "Double Digit",
				NumValue = new List<Int32> { 10, 21, 32 }
			});
			TestData.Add(new MyNumbers
			{
				NumName = "Triple Digit",
				NumValue = new List<Int32> { 100, 211, 322 }
			});

			// Create the query.
			var ThisQuery =
				TestData.SelectMany(ThisElement => ThisElement.NumValue);

			// Display the output.
			foreach (var ThisElement in ThisQuery)
				Console.Write(ThisElement.ToString() + "\r\n");
		}

		public void Listing610()
		{
			// Define two test arrays.
			String[] First =
				{ "One", "Two", "Two", "Three", "Four" };
			String[] Second =
				{ "Three", "Four", "Five", "Six" };

			// Create the Distinct query.
			var ShowDistinct = First.Distinct();

			// Display the output.
			Console.Write("Distinct:\r\n");
			foreach (String ThisElement in ShowDistinct)
				Console.Write(
					ThisElement + "\r\n");

			// Create the Except query.
			var ShowExcept = First.Except(Second);

			// Display the output.
			Console.Write(
				"\r\n\r\nExcept:\r\n");
			foreach (String ThisElement in ShowExcept)
				Console.Write(
					ThisElement + "\r\n");

			// Create the Intersect query.
			var ShowIntersect = First.Intersect(Second);

			// Display the output.
			Console.Write(
				"\r\n\r\nIntersect:\r\n");
			foreach (String ThisElement in ShowIntersect)
				Console.Write(
					ThisElement + "\r\n");

			// Create the Union query.
			var ShowUnion = First.Union(Second);

			// Display the output.
			Console.Write(
				"\r\n\r\nUnion:\r\n");
			foreach (String ThisElement in ShowUnion)
				Console.Write(
					ThisElement + "\r\n");
		}

		public void Listing611()
		{
			// Define a test object.
			String[] TestData = {"One", "Two", "Three", "Four",
				"Five", "Six", "Seven", "Eight",
				"Nine", "Ten"
			};

			// Create the query.
			var ThisQuery =
				TestData.OrderByDescending(ThisKey => ThisKey.Length).
			ThenBy(ThisKey => ThisKey.Substring(0, 1));

			// Display the output.
			foreach (var ThisElement in ThisQuery)
				Console.Write(
					ThisElement + "\r\n");
		}

		public void Listing612()
		{
			// Define a test object.
			String[] TestData = {"One", "Two", "Three", "Four",
				"Five", "Six", "Seven", "Eight",
				"Nine", "Ten"
			};

			Int32[] TestData2 = { 1, 2, 3, 4, 5 };

			// Create the query.
			var ThisQuery =
				TestData.Aggregate(
					(ThisElement, Next) =>
				  ThisElement + "\r\n" + Next);

			// Display the output.
			Console.Write("Strings:\r\n");
			Console.Write(ThisQuery);

			// Create the query.
			var ThisQuery2 =
				TestData2.Aggregate(
					(ThisElement, Next) => ThisElement + Next);

			// Display the output.
			Console.Write("\r\n\r\nNumbers:\r\n");
			Console.WriteLine(ThisQuery2.ToString());
		}

		public void Listing613()
		{
			// Define a test object.
			String[] TestData = {"Zero", "One", "Two", "Three",
				"Four", "Five", "Six", "Seven",
				"Eight", "Nine", "Ten"
			};
			// Create the query.
			var ThisQuery = TestData.First();

			// Display the output.
			Console.Write("First Element: " + ThisQuery);

			// Get the last element.
			ThisQuery = TestData.Last();

			// Display the output.
			Console.Write(
				"\r\nLast Element: " + ThisQuery);

			// Get a particular element.
			ThisQuery = TestData.ElementAt(5);

			// Display the output.
			Console.Write("\r\nFifth Element: " + ThisQuery);
		}

		public void Listing614()
		{
			// Define the test objects.
			String[] Array1 = { "Zero", "One", "Two", "Three" };
			String[] Array2 = { "Zero", "One", "Two", "Three" };
			String[] Array3 = { "Two", "Zero", "One", "Three" };
			String[] Array4 = { "One", "Two", "Three", "Four" };

			// Check Array1 and Array2.
			var ThisQuery = Array1.SequenceEqual(Array2);

			// Display the output.
			Console.Write("Array1 = Array2: " + ThisQuery.ToString());

			// Check Array1 and Array3.
			ThisQuery = Array1.SequenceEqual(Array3);

			// Display the output.
			Console.Write("\r\nArray1 = Array3: " + ThisQuery.ToString());

			// Check Array1 and Array4.
			ThisQuery = Array1.SequenceEqual(Array4);

			// Display the output.
			Console.Write("\r\nArray1 = Array4: " + ThisQuery.ToString());
		}

		public void Listing615()
		{
			// Define a test object.
			String[] TestData = {"Zero", "One", "Two", "Three",
				"Four", "Five", "Six", "Seven",
				"Eight", "Nine", "Ten"
			};

			// Create the All query.
			var ThisQuery = TestData.All(
								ThisElement => ThisElement.Length == 4);

			// Display the output.
			Console.Write("All elements have 4 characters: " + ThisQuery);

			// Create the Any query.
			ThisQuery = TestData.Any(ThisElement => ThisElement.Length == 4);

			// Display the output.
			Console.Write(
				"\r\n\r\nAt least one element has 4 characters: " +
				ThisQuery);

			// Create the Any query.
			ThisQuery = TestData.Contains("Four");

			// Display the output.
			Console.Write(
				"\r\n\r\nThe sequence contains 'Four': " + ThisQuery);
		}




	}

	//Listing69
	class MyNumbers
	{
		// Each number type name.
		public String NumName { get; set; }

		// can have multiple values associated with it.
		public List<Int32> NumValue { get; set; }
	}
}
