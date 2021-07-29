using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqForDum
{
    class Chapter2
    {
        public void Listing21()
        {
            // Create an array as a data source.
            String[] QueryString = { "One", "Two", "Three", "Four", "Five" };
            // Define the query.
            var ThisQuery =
                from StringValue in QueryString
                select StringValue + "\r\n";
            // Display the result.
            foreach (var ThisValue in ThisQuery)
                Console.Write(ThisValue);
        }

        public void Listing22()
        {
            // Create an array as a data source.
            String[] QueryString =
                { "One", "Two", "Three", "Four", "Five" };
            // Define the query.
            var ThisQuery =
                from StringValue in QueryString
                where StringValue.Length > 3
                select StringValue + "\r\n";
            // Display the result.
            foreach (var ThisValue in ThisQuery)
                Console.Write(ThisValue);
        }

        public void Listing23()
        {
            String[] QueryString =
                { "One", "Two", "Three", "Four", "Five", "Six" };

            // Define the query.
            var ThisQuery =
                from StringValue
                in QueryString
                orderby StringValue
                orderby StringValue.Length
                select StringValue + "\r\n";

            // Display the result.
            foreach (var ThisValue in ThisQuery)
                Console.Write(ThisValue);
        }

        public void Listing24()
        {
            // Define two test arrays.
            Int32[] ArrayA = { 1, 2, 3, 4, 8 };
            Int32[] ArrayB = { 1, 3, 5, 7, 8 };

            // Create the query.
            var Joined = from QueryA in ArrayA
                         join QueryB in ArrayB
                on QueryA equals QueryB
                         select new { QueryA, QueryB };

            // Display the results.
            Console.Write("\r\nJoin Results:\r\n\r\n");

            foreach (var OutPair in Joined)
                Console.Write(OutPair.QueryA.ToString() + " - " + OutPair.QueryB.ToString() + "\r\n");
        }

        public void Listing25()
        {
            // Define two test arrays.
            Int32[] ArrayA = { 1, 2, 3, 4, 8 };
            Int32[] ArrayB = { 1, 3, 5, 7, 8 };

            // Create the query.
            var TwoFroms = from QueryA in ArrayA
                           from QueryB in ArrayB
                           where QueryA == QueryB
                           select new { QueryA, QueryB };

            // Display the results.
            Console.Write("\r\nTwo From Results:\r\n\r\n");

            foreach (var OutPair in TwoFroms)
                Console.Write(OutPair.QueryA.ToString() + " - " + OutPair.QueryB.ToString() + "\r\n");
        }

        public void Listing26()
        {
            // Create an array as a data source.
            Int32[] ArrayA = { 1, 2, 3, 4 };
            Int32[] ArrayB = { 1, 2, 3, 4 };

            // Define the query.
            var Squares =
                from QueryA in ArrayA
                from QueryB in ArrayB
                let TheSquare = QueryA * QueryB
                where TheSquare > 4
                select new { QueryA, QueryB, TheSquare };

            // Display the result.
            foreach (var ThisSquare in Squares)
                Console.Write(ThisSquare.QueryA.ToString() + " * " + ThisSquare.QueryB.ToString() + " = " + ThisSquare.TheSquare.ToString() + "\r\n");
        }

    }

    // The extension method must appear in a public static class.
    //	public static class MyWhere
    //	{
    //		// Define the new version of where.
    //		// The definition must match precisely.
    //		public static IEnumerable<TSource> Where<TSource>(
    //			this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    //		{
    //			// Obtain the number of elements in the source array.
    //			int ThisCount = source.Count<TSource>();
    //
    //			// Create a new array of the correct type.
    //			TSource[] Results = new TSource[ThisCount];
    //
    //			// Initialize the array.
    //			Results.Initialize();
    //
    //			// Create a counter to track the current results element.
    //			int ArrayCount = 0;
    //
    //			// Process the source array.
    //			foreach (TSource ThisValue in source) {
    //				// When the source array element meets the required value...
    //				if (ThisValue.ToString().Length > 3) {
    //					// add it to the results array and increment the array
    //					// counter.
    //					Results[ArrayCount] = ThisValue;
    //					ArrayCount++;
    //				}
    //			}
    //
    //			// Return the matching elements.
    //			return Results;
    //		}
    //	}
}
