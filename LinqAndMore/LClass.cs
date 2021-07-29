using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace LinqAndMore
{
    public class LClass
    {
        public void queryWhere()
        {

            //where
            string[] words = { "humpty", "dumpty", "set", "on", "a", "wall" };

            IEnumerable<string> query = from word in words
                                        where word.Length == 3
                                        select word;

            foreach (string str in query)
                Console.WriteLine(str);

        }

        public void querySelect()
        {
            List<string> words = new List<string>() {
                "an",
                "apple",
                "a",
                "day"
            };

            var query = from word in words
                        select word.Substring(0, 1);

            foreach (string s in query)
                Console.WriteLine(s);
        }

        public void querySelectMany()
        {
            List<string> phrases = new List<string>() {
                "an apple a day",
                "the quick brown fox"
            };

            var query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;

            foreach (string s in query)
                Console.WriteLine(s);
        }

        public void queryOrderby()
        {
            int[] num = { -20, 12, 6, 10, 0, -3, 1 };

            //create a query that obtain the values in sorted order
            var posNums = from n in num
                          orderby n
                          select n;

            Console.Write("Values in ascending order: ");

            // Execute the query and display the results.

            foreach (int i in posNums)
                Console.Write(i + " \n");

            var posNumsDesc = from n in num
                              orderby n descending
                              select n;

            Console.Write("\nValues in descending order: ");

            // Execute the query and display the results.

            foreach (int i in posNumsDesc)
                Console.Write(i + " \n");
        }

        public void queryGroupby()
        {
            List<int> numbers = new List<int>() {
                35,
                44,
                200,
                84,
                3987,
                4,
                199,
                329,
                446,
                208
            };

            IEnumerable<IGrouping<int, int>> query = from number in numbers
                                                     group number by number % 2;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");

                foreach (int i in group)
                    Console.WriteLine(i);
            }

        }

        public void queryExcept()
        {
            double[] numbers1 = { 2.0, 2.1, 2.2, 2.3, 2.4, 2.5 };
            double[] numbers2 = { 2.2 };

            IEnumerable<double> onlyInFirstSet = numbers1.Except(numbers2);

            foreach (double number in onlyInFirstSet)
                Console.WriteLine(number);
            Console.ReadLine();
        }

        public void queryIntersect()
        {
            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };

            IEnumerable<int> both = id1.Intersect(id2);

            foreach (int id in both)
                Console.WriteLine(id);
        }

        public void queryUnion()
        {
            int[] ints1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
            int[] ints2 = { 8, 3, 6, 4, 4, 9, 1, 0 };

            IEnumerable<int> union = ints1.Union(ints2);

            foreach (int num in union)
            {
                Console.Write("{0} ", num);
                Console.Write("\n");
            }
        }

        public void queryElementat()
        {
            string[] names = { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow",
                "Hedlund, Magnus", "Ito, Shu"
            };
            Random random = new Random(DateTime.Now.Millisecond);

            string name = names.ElementAt(random.Next(0, names.Length));

            Console.WriteLine("The name chosen at random is '{0}'.", name);
        }

        public void queryFirst()
        {
            int[] numbers = {
                9,
                34,
                65,
                92,
                87,
                435,
                3,
                54,
                83,
                23,
                87,
                435,
                67,
                12,
                19
            };

            int first = numbers.First();

            Console.WriteLine(first);
        }

        public void queryLast()
        {
            int[] numbers = {
                9,
                34,
                65,
                92,
                87,
                435,
                3,
                54,
                83,
                23,
                87,
                435,
                67,
                12,
                19
            };

            int last = numbers.Last();

            Console.WriteLine(last);
        }

        public void queryLinqtoObjects()
        {
            string[] tools = {
                "Tablesaw",
                "Bandsaw",
                "Planer",
                "Jointer",
                "Drill",
                "Sander"
            };
            var list = from t in tools
                       select t;

            StringBuilder sb = new StringBuilder();

            foreach (string s in list)
            {
                sb.Append(s + Environment.NewLine);
            }

            Console.WriteLine(sb.ToString(), "Tools");
            //https://www.tutorialspoint.com/linq/linq_objects.htm
        }

        //xml linq
        public void queryXmltoLinq()
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
        }

        public void queyXmltoLinqnewNode()
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new Element
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add new Element at First
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
        }

        public void queryRemoveNode()
        {
            string myXML = @"<Departments>
                       <Department>Support</Department>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       <Department>Finance</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Remove Sales Department
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
        }

        //lambda
        delegate int del(int i);
        public void lambdaExpression()
        {
            del myDelegate = y => y * y;
            int j = myDelegate(5);
            Console.WriteLine(j);
        }

        public void lambdaOnQuery()
        {
            int[] fibNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            double averageValue = fibNum.Where(num => num % 2 == 1).Average();
            Console.WriteLine(averageValue);
        }

        public void lambdaStatement()
        {
            int[] source = new[] { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };

            foreach (int i in source.Where(x =>
            {
                if (x <= 3)
                    return true;
                else if (x >= 7)
                    return true;
                return false;
            }
         ))
                Console.WriteLine(i);
        }


    }
}
