using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqForDum
{
    class Chapter5
    {
		public void Listing51()//From
		{
			// Create an array as a data source.
			String[] QueryString = { "One", "Two", "Three", "Four", "Five",
				"Six", "Seven", "Eight", "Nine", "Ten"
			};

			// Define the query.
			var ThisQuery =
				from StringValue in QueryString
				select StringValue + "\r\n";

			// Display the result.
			foreach (var ThisValue in ThisQuery)
				Console.Write(ThisValue);
		}

		public void Listing52()//Join
		{
			// Create an array as a data source.
			String[] QueryString = { "One", "Two", "Three", "Four", "Five",
				"Six", "Seven", "Eight", "Nine", "Ten"
			};

			// Define a second array for the second data source.
			String[] IndexArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I",
				"J", "K", "L", "M", "N", "O", "P", "Q", "R",
				"S", "T", "U", "V", "W", "X", "Y", "Z"
			};

			// Define the query.
			var ThisQuery =
				from StringValue in QueryString
				join IndexValue in IndexArray
			on StringValue.Substring(0, 1) equals IndexValue
				select new { StringValue, IndexValue };

			//// Define the query using IndexArray first.
			//var ThisQuery = 
			//   from IndexValue in IndexArray
			//   join StringValue in QueryString 
			//   on IndexValue equals StringValue.Substring(0, 1)
			//   select new {StringValue, IndexValue};

			//// Define the query using two from keywords.
			//var ThisQuery = 
			//   from StringValue in QueryString 
			//   from IndexValue in IndexArray
			//   where StringValue.Substring(0, 1) == IndexValue
			//   select new {StringValue, IndexValue};

			// Display the result.
			foreach (var ThisValue in ThisQuery)
				Console.Write(
					ThisValue.IndexValue + " - " +
					ThisValue.StringValue + "\r\n");
		}

		public void Listing53()//Where
		{
			// Create an array as a data source.
			String[] QueryString = { "One", "Two", "Three", "Four", "Five",
				"Six", "Seven", "Eight", "Nine", "Ten"
			};

			// Define a second array for the second data source.
			String[] IndexArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I",
				"J", "K", "L", "M", "N", "O", "P", "Q", "R",
				"S", "T", "U", "V", "W", "X", "Y", "Z"
			};

			// Define the query.
			var ThisQuery =
				from StringValue in QueryString
				join IndexValue in IndexArray
			on StringValue.Substring(0, 1) equals IndexValue
				where Convert.ToChar(IndexValue) > 'F'
				select new { StringValue, IndexValue };

			// Display the result.
			foreach (var ThisValue in ThisQuery)
				Console.Write(
					ThisValue.IndexValue + " - " +
					ThisValue.StringValue + "\r\n");
		}

		public void Listing54()//OrderBy
		{
			// Create an array as a data source.
			String[] QueryString = { "One", "Two", "Three", "Four", "Five",
				"Six", "Seven", "Eight", "Nine", "Ten"
			};

			// Define a second array for the second data source.
			String[] IndexArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I",
				"J", "K", "L", "M", "N", "O", "P", "Q", "R",
				"S", "T", "U", "V", "W", "X", "Y", "Z"
			};

			// Define the query.
			var ThisQuery =
				from StringValue in QueryString
				join IndexValue in IndexArray
			on StringValue.Substring(0, 1) equals IndexValue
				where Convert.ToChar(IndexValue) > 'F'
				orderby IndexValue
				select new { StringValue, IndexValue };

			// Display the result.
			foreach (var ThisValue in ThisQuery)
				Console.Write(
					ThisValue.IndexValue + " - " +
					ThisValue.StringValue + "\r\n");
		}

		public void Listing55()//Let
		{
			// Create an array as a data source.
			String[] QueryString = { "One", "Two", "Three", "Four", "Five",
				"Six", "Seven", "Eight", "Nine", "Ten"
			};

			// Define the query.
			var ThisQuery =
				from StringValue in QueryString
				let IndexValue = StringValue.Substring(0, 1)
				where Convert.ToChar(IndexValue) > 'F'
				orderby IndexValue
				select new { StringValue, IndexValue };

			// Display the result.
			foreach (var ThisValue in ThisQuery)
				Console.Write(
					ThisValue.IndexValue + " - " +
					ThisValue.StringValue + "\r\n");
		}
	}
}
