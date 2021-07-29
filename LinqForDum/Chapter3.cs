using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqForDum
{
    class Chapter3
    {
        public Chapter3()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
        }

        // Create the delegate used for filtering strings.
        public delegate Boolean CheckString(String Str);

        // This is a generic function that will accept any
        // array of strings and filter it. The output is a
        // filtered arrary of strings.
        public static String[] FilterStrings(String[] Input, CheckString Filter)
        {
            // Create an array to hold the output.
            ArrayList ResultList = new ArrayList();

            // Check each of the input array elements.
            foreach (String ThisString in Input)
            {

                // Determine whether the string meets the filtering
                // criteria.
                if (Filter(ThisString))

                    // When the string meets the filtering criteria,
                    // add the string to the output array.
                    ResultList.Add(ThisString);
            }

            // Return the list as output.
            return (String[])ResultList.ToArray(typeof(String));
        }


        public void Listing31()
        {
            // Create a string array.
            String[] TestArray =
                { "One", "Two", "Three", "Four", "Five" };

            // Filter the array.
            String[] OutputArray =
                FilterStrings(TestArray, TestStr => TestStr.Length > 3);

            // Display the results.
            foreach (String ThisString in OutputArray)
                Console.Write(ThisString + "\r\n");
        }

        public void Listing32()
        {
            // Create a string array.
            String[] TestArray =
                { "One", "Two", "Three", "Four", "Five" };

            // Create a query on the TestArray.
            IEnumerable<String> Results =
                TestArray.Where(TheValue => TheValue.Length > 3);

            // Display the results.
            foreach (String ThisString in Results)
                Console.Write(ThisString + "\r\n");
        }

        public void Listing32_1()
        {
            // Create a string array.
            String[] TestArray = { "One", "Two", "Three", "Four", "Five" };

            // Create a query on the TestArray.
            String[] Results =
                TestArray.Where(TheValue => TheValue.Length > 3).ToArray();

            // Display the results.
            foreach (String ThisString in Results)
                Console.Write(ThisString + "\r\n");
        }

        public struct MyAddress
        {
            public String Name;
            public String Company;
            public String Address1;
            public String Address2;
            public String City;
            public String State;
            public String ZIP;
        }

        public void Listing34()
        {
            // Instantiate the object.
            MyAddress ThisAddress = new MyAddress();

            // Initialize the object.
            ThisAddress.Name = "George Samuels";
            ThisAddress.Address1 = "1234 Anywhere";
            ThisAddress.City = "Somewhere";
            ThisAddress.State = "WA";
            ThisAddress.ZIP = "12345-1234";

            // Output the data.
            Console.Write(
                ThisAddress.Name + "\r\n" +
                ThisAddress.Address1 + "\r\n" +
                ThisAddress.City + ", " +
                ThisAddress.State + "     " +
                ThisAddress.ZIP);
        }

        public void Listing35()
        {
            // Create a new structure.
            MyAddress ThisAddress = new MyAddress
            {
                Name = "George Samuels",
                Address1 = "1234 Anywhere",
                City = "Somewhere",
                State = "WA",
                ZIP = "12345-1234"
            };

            // Output the data.
            Console.Write(
                ThisAddress.Name + "\r\n" +
                ThisAddress.Address1 + "\r\n" +
                ThisAddress.City + ", " +
                ThisAddress.State + "     " +
                ThisAddress.ZIP);
        }

        public void Listing36()
        {
            // Create and initialize the list.
            List<String> Names = new List<string> {
                "George",
                "Amy",
                "Zach",
                "Chris",
                "Renee"
            };

            // Display it on screen.
            foreach (String ThisName in Names)
                Console.Write(ThisName + "\r\n");
        }

        public void Listing37()
        {
            // Create a collection of addresses.
            List<MyAddress> AddressCollection = new List<MyAddress> {
                new MyAddress {
                    Name = "Sam Rugged",
                    Address1 = "1234 Somewhere",
                    Address2 = "Suite 3",
                    City = "Anywhere",
                    State = "WA",
                    ZIP = "12345"
                },
                new MyAddress {
                    Name = "Mary Wurth",
                    Company = "Faxes Our Us",
                    Address1 = "1414 21st Street",
                    City = "Nowhere",
                    State = "MI",
                    ZIP = "99999"
                }
            };

            // Output the data.
            foreach (MyAddress ThisAddress in AddressCollection)
                Console.Write(
                    ThisAddress.Name + "\r\n" +
                    ThisAddress.Company + "\r\n" +
                    ThisAddress.Address1 + "\r\n" +
                    ThisAddress.Address2 + "\r\n" +
                    ThisAddress.City + ", " +
                    ThisAddress.State + "     " +
                    ThisAddress.ZIP + "\r\n\r\n");
        }

        public void Listing39()
        {
            // Define a string with special characters.
            String MyString = "abcd;@abc,abc:abc?abc+ hello!";

            // Obtain the number of special characters.
            int CharCount = MyString.SpecialCharCount();

            // Display the result.
            Console.Write("The number of special characters is: " + CharCount.ToString());
        }

        public void Listing313()
        {
            // Create the expression tree.
            Expression<Func<String, bool>> MyLambdaExpression =
                MyString => MyString.Length > 3;

            // Obtain the expression tree elements.
            // Contains the list of parameters.
            ParameterExpression Parameters =
                (ParameterExpression)MyLambdaExpression.Parameters[0];
            // Contains the evaluation.
            BinaryExpression TheEvaluation =
                (BinaryExpression)MyLambdaExpression.Body;
            // Contains the left side of the evaluation.
            MemberExpression LeftSide =
                (MemberExpression)TheEvaluation.Left;
            // Contains the right side of the evaluation.
            ConstantExpression RightSide =
                (ConstantExpression)TheEvaluation.Right;

            // Ouptut the elements of the expression tree.
            Console.Write("The tree contains:\r\nParameters: " +
            Parameters.ToString() + "\r\nEvaluation: " +
            TheEvaluation.ToString() + "\r\nLeft Side: " +
            LeftSide.ToString() + "\r\nRight Side: " +
            RightSide.ToString());
        }

        public void Listing314()
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

        public void Listing314_1()
        {
            // Create an array as a data source.
            String[] QueryString = { "One", "Two", "Three", "Four", "Five" };

            // Define the query.
            var ThisQuery = QueryString
               .Where(StringValue => StringValue.Length > 3)
               .Select(StringValue => StringValue + "\r\n");

            // Display the result.
            foreach (var ThisValue in ThisQuery)
                Console.Write(ThisValue);
        }


    }

    //Listing38
    public static class MyStrings
    {
        public static int SpecialCharCount(this String Str)
        {
            // Define a LINQ Query for special characters.
            var CharQuery = from ThisCount
                         in Str
                            where ThisCount == '!'
                                || ThisCount == '@'
                                || ThisCount == ';'
                                || ThisCount == ','
                                || ThisCount == ':'
                                || ThisCount == '?'
                                || ThisCount == '+'
                                || ThisCount == ' '
                            select ThisCount;

            // Return the number of special characters.
            return CharQuery.Count<Char>();
        }
    }

    //Listing310
    public partial class PMethodTest
    {
        // Create the method declarations.
        partial void DisplayMe(String Msg);
        partial void NoDisplayMe(String Msg);

        public PMethodTest(String Msg)
        {
            // Show that we're in the constructor.
            Console.WriteLine("Entering the Constructor.");

            // Perform the required tasks.
            DisplayMe(Msg);
            NoDisplayMe(Msg);

            // Show that we're exiting the constructor.
            Console.WriteLine("Leaving the Constructor.");
        }
    }
}
