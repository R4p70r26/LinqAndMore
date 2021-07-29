using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class W3LnqExerci
    {
		/// <summary>
		/// https://www.w3resource.com/csharp-exercises/linq/index.php
		/// https://csharpexercises.com/linq
		/// 
		/// https://www.codewars.com/collections/linq-exercises
		/// </summary>

		public void Exe1()
		{
			//  The first part is Data source.
			int[] n1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			Console.Write("\nBasic structure of LINQ : ");
			Console.Write("\n---------------------------");

			// The second part is Query creation.
			// nQuery is an IEnumerable<int>
			var nQuery =
				from VrNum in n1
				where (VrNum % 2) == 0
				select VrNum;

			var query = n1.Where(x => x % 2 == 0).Select(x => x);

			//			foreach (var element in query) {
			//				Console.WriteLine(element);
			//			}

			// The third part is Query execution.

			Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
			foreach (int VrNum in nQuery)
			{
				Console.Write("{0} ", VrNum);
			}
			Console.Write("\n\n");
		}

		public void Exe2()
		{
			int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
			Console.Write("\n-----------------------------------------------------------------------------");

			var nQuery =
				from VrNum in n1
				where VrNum > 0
				where VrNum < 12
				select VrNum;

			var query = n1.Where(x => x > 0).Where(x => x < 12).Select(x => x);

			Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
			foreach (var VrNum in nQuery)
			{
				Console.Write("{0}  ", VrNum);
			}
			Console.Write("\n\n");
		}

		public void Exe3()
		{
			var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

			Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
			Console.Write("\n------------------------------------------------------------------------\n");

			var sqNo = from int Number in arr1
					   let SqrNo = Number * Number
					   where SqrNo > 20
					   select new { Number, SqrNo };

			var query = arr1.Select(Number => new { Number, sqrN = Number * Number }).Where(x => x.sqrN > 20).Select(x => x);

			foreach (var a in sqNo)
				Console.WriteLine(a);

		}

		public void Exe4()
		{
			int[] arr1 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
			Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
			Console.Write("---------------------------------------------------------------------\n");
			Console.Write("The numbers in the array  are : \n");
			Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

			var n = from x in arr1
					group x by x into y
					select y;

			Console.WriteLine("\nThe number and the Frequency are : \n");
			foreach (var arrNo in n)
			{
				Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
			}
			Console.WriteLine("\n");


			var quer = arr1.GroupBy(x => x).Select(x => x);
			foreach (var element in quer)
			{
				Console.WriteLine(string.Format("Number {0} appears {1} times", element.Key, element.Count()));
			}
		}

		public void Exe5(string str)
		{
			Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
			Console.Write("\n----------------------------------------------------------------------------\n");

			var FreQ = from x in str
					   group x by x into y
					   select y;
			Console.Write("The frequency of the characters are :\n");
			foreach (var ArrEle in FreQ)
			{
				Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
			}

			var quer = str.GroupBy(x => x).Select(x => x);
			foreach (var element in quer)
			{
				Console.WriteLine(string.Format("Char {0} appears {1} times", element.Key, element.Count()));
			}
		}

		public void Exe6()
		{
			string[] dayWeek = {
				"Sunday",
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday"
			};

			Console.Write("\nLINQ : Display the name of the days of a week : ");
			Console.Write("\n------------------------------------------------\n");


			var days = from WeekDay in dayWeek
					   select WeekDay;
			foreach (var WeekDay in days)
			{
				Console.WriteLine(WeekDay);
			}


			var qDays = dayWeek.Select(x => x);
			foreach (var element in qDays)
				Console.WriteLine(element);



		}

		public void Exe7()
		{

			int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
			Console.Write("\nLINQ : Display numbers, number*frequency and frequency : ");
			Console.Write("\n-------------------------------------------------------\n");
			Console.Write("The numbers in the array are : \n");
			Console.Write("  5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n\n");


			var m = from x in nums
					group x by x into y
					select y;
			Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
			Console.Write("------------------------------------------------\n");

			foreach (var arrEle in m)
			{
				Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
			}
			Console.WriteLine();


			var query = nums.GroupBy(x => x).Select(x => x);
			foreach (var element in query)
			{
				Console.WriteLine(string.Format("{0}\t{1}\t\t\t{2}", element.Key, element.Sum(), element.Count()));
			}
		}

		public void Exe8()
		{
			string chst, chen;
			char ch;
			string[] cities = {
				"ROME",
				"LONDON",
				"NAIROBI",
				"CALIFORNIA",
				"ZURICH",
				"NEW DELHI",
				"AMSTERDAM",
				"ABU DHABI",
				"PARIS"
			};

			Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
			Console.Write("\n-----------------------------------------------------------------------\n");
			Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

			Console.Write("\nInput starting character for the string : ");
			ch = (char)Console.Read();
			chst = ch.ToString();
			Console.Write("\nInput ending character for the string : ");
			ch = (char)Console.Read();
			chen = ch.ToString();


			var _result = from x in cities
						  where x.StartsWith(chst)
						  where x.EndsWith(chen)
						  select x;
			Console.Write("\n\n");
			foreach (var city in _result)
			{
				Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
			}

			Console.ReadLine();

			chst = "Z";
			chen = "H";

			var query = cities.Where(x => x.StartsWith(chst)).Where(x => x.EndsWith(chen)).Select(x => x);
			foreach (var element in query)
			{
				Console.WriteLine("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, element);
			}
		}

		public void Exe9()
		{
			List<int> templist = new List<int>();
			templist.Add(55);
			templist.Add(200);
			templist.Add(740);
			templist.Add(76);
			templist.Add(230);
			templist.Add(482);
			templist.Add(95);

			Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
			Console.Write("\n-------------------------------------------------------------------------\n");
			Console.WriteLine("\nThe members of the list are : ");
			foreach (var lstnum in templist)
			{
				Console.Write(lstnum + " ");
			}
			List<int> FilterList = templist.FindAll(x => x > 80 ? true : false);
			Console.WriteLine("\n\nThe numbers greater than 80 are : ");
			foreach (var num in FilterList)
			{
				Console.WriteLine(num);
			}
		}

		public void Exe10()
		{
			int memlist, n, m;
			List<int> templist = new List<int>();
			Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
			Console.Write("\n----------------------------------------------------------------------------------------\n");

			Console.Write("Input the number of members on the List : ");
			n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.Write("Member {0} : ", i);
				memlist = Convert.ToInt32(Console.ReadLine());
				templist.Add(memlist);
			}

			Console.Write("\nInput the value above you want to display the members of the List : ");
			m = Convert.ToInt32(Console.ReadLine());

			List<int> FilterList = templist.FindAll(x => x > m ? true : false);
			Console.WriteLine("\nThe numbers greater than {0} are : ", m);
			foreach (var num in FilterList)
			{
				Console.WriteLine(num);
			}
		}

		public void Exe11()
		{
			List<int> templist = new List<int>();
			templist.Add(5);
			templist.Add(7);
			templist.Add(13);
			templist.Add(24);
			templist.Add(6);
			templist.Add(9);
			templist.Add(8);
			templist.Add(7);

			Console.Write("\nLINQ : Display top nth  records from the list : ");
			Console.Write("\n----------------------------------------------\n");

			Console.WriteLine("\nThe members of the list are : ");
			foreach (var lstnum in templist)
			{
				Console.WriteLine(lstnum + " ");
			}

			Console.Write("How many records you want to display ? : ");
			int n = Convert.ToInt32(Console.ReadLine());

			templist.Sort();
			templist.Reverse();

			Console.Write("The top {0} records from the list are : \n", n);
			foreach (int topn in templist.Take(n))
			{
				Console.WriteLine(topn);
			}
		}

		public void Exe12()
		{
			Console.Write("\nLINQ : Find the uppercase words in a string : ");
			Console.Write("\n----------------------------------------------\n");

			string strNew;

			Console.Write("Input the string : ");
			strNew = Console.ReadLine();

			var ucWord = WordFilt(strNew);
			Console.Write("\nThe UPPER CASE words are :\n ");
			foreach (string strRet in ucWord)
			{
				Console.WriteLine(strRet);
			}
		}
		static IEnumerable<string> WordFilt(string mystr)
		{
			var upWord = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));
			return upWord;
		}

		public void Exe13()
		{
			string[] arr1;
			int n;

			Console.Write("\nLINQ : Convert a string array to a string : ");
			Console.Write("\n------------------------------------------\n");
			Console.Write("Input number of strings to  store in the array :");
			n = Convert.ToInt32(Console.ReadLine());
			arr1 = new string[n];

			Console.Write("Input {0} strings for the array  :\n", n);
			for (int i = 0; i < n; i++)
			{
				Console.Write("Element[{0}] : ", i);
				arr1[i] = Console.ReadLine();
			}

			string newstring = String.Join(", ", arr1.Select(s => s.ToString()).ToArray());
			Console.Write("\nHere is the string below created with elements of the above array  :\n\n");
			Console.WriteLine(newstring);
			Console.Write("\n");
		}


		public class Students
		{
			public string StuName { get; set; }
			public int GrPoint { get; set; }
			public int StuId { get; set; }

			public List<Students> GtStuRec()
			{
				List<Students> stulist = new List<Students>();
				stulist.Add(new Students
				{
					StuId = 1,
					StuName = " Joseph ",
					GrPoint = 800
				});
				stulist.Add(new Students
				{
					StuId = 2,
					StuName = "Alex",
					GrPoint = 458
				});
				stulist.Add(new Students
				{
					StuId = 3,
					StuName = "Harris",
					GrPoint = 900
				});
				stulist.Add(new Students
				{
					StuId = 4,
					StuName = "Taylor",
					GrPoint = 900
				});
				stulist.Add(new Students
				{
					StuId = 5,
					StuName = "Smith",
					GrPoint = 458
				});
				stulist.Add(new Students
				{
					StuId = 6,
					StuName = "Natasa",
					GrPoint = 700
				});
				stulist.Add(new Students
				{
					StuId = 7,
					StuName = "David",
					GrPoint = 750
				});
				stulist.Add(new Students
				{
					StuId = 8,
					StuName = "Harry",
					GrPoint = 700
				});
				stulist.Add(new Students
				{
					StuId = 9,
					StuName = "Nicolash",
					GrPoint = 597
				});
				stulist.Add(new Students
				{
					StuId = 10,
					StuName = "Jenny",
					GrPoint = 750
				});
				return stulist;
			}
		}

		public void Exe14()
		{
			Students e = new Students();


			Console.Write("\nLINQ : Find the nth Maximum Grade Point achieved by the students from the list of student : ");
			Console.Write("\n------------------------------------------------------------------------------------------\n");

			Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
			int grPointRank = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n");
			var stulist = e.GtStuRec();
			var students = (from stuMast in stulist
							group stuMast by stuMast.GrPoint into g
							orderby g.Key descending
							select new { StuRecord = g.ToList() }).ToList();
			students[grPointRank - 1].StuRecord.ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));


			//extension
			var studs = (stulist.GroupBy(x => x.GrPoint).OrderByDescending(x => x.Key).Select(rec => new { sturec = rec.ToList() })).ToList();
			studs[grPointRank - 1].sturec.ForEach(x => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", x.StuId, x.StuName, x.GrPoint));
		}

		public void Exe15()
		{
			string[] arr1 = {
				"aaa.frx",
				"bbb.TXT",
				"xyz.dbf",
				"abc.pdf",
				"aaaa.PDF",
				"xyz.frt",
				"abc.xml",
				"ccc.txt",
				"zzz.txt"
			};

			Console.Write("\nLINQ : Count file extensions and group it : ");
			Console.Write("\n------------------------------------------\n");

			Console.Write("\nThe files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf");
			Console.Write("\n                aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt\n");

			Console.Write("\nHere is the group of extension of the files : \n\n");

			var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
					 .GroupBy(z => z, (fExt, extCtr) => new { Extension = fExt, Count = extCtr.Count() });

			foreach (var m in fGrp)
				Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
		}

		public void Exe16()
		{
			string[] dirfiles = Directory.GetFiles(@"C:\Users\raptor\Documents\Kaichou Wa Maid-Sama");
			// there are three files in the directory abcd are :
			// abcd.txt, simple_file.txt and xyz.txt

			Console.Write("\nLINQ : Calculate the size of file : ");
			Console.Write("\n------------------------------------\n");

			var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
			avgFsize = Math.Round(avgFsize / 10, 1);
			Console.WriteLine("The Average file size is {0} MB", avgFsize);
		}

		public void Exe17()
		{
			List<string> listOfString = new List<string>();
			listOfString.Add("m");
			listOfString.Add("n");
			listOfString.Add("o");
			listOfString.Add("p");
			listOfString.Add("q");


			Console.Write("\nLINQ : Remove items from list using remove function : ");
			Console.Write("\n----------------------------------------------------\n");

			var _result1 = from y in listOfString
						   select y;
			Console.Write("Here is the list of items : \n");
			foreach (var tchar in _result1)
			{
				Console.WriteLine("Char: {0} ", tchar);
			}

			//extension
			var query = listOfString.Select(x => x);
			foreach (var element in query)
			{
				Console.WriteLine("Char: {0} ", element);
			}



			string newstr = listOfString.FirstOrDefault(en => en == "o");
			listOfString.Remove(newstr);


			var _result = from z in listOfString
						  select z;
			Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
			foreach (var rChar in _result)
			{
				Console.WriteLine("Char: {0} ", rChar);
			}

			//extension
			var query2 = listOfString.Select(x => x);
			foreach (var element in query2)
			{
				Console.WriteLine("Char: {0} ", element);
			}


		}

		public void Exe18()
		{
			List<string> listOfString = new List<string>();
			listOfString.Add("m");
			listOfString.Add("n");
			listOfString.Add("o");
			listOfString.Add("p");
			listOfString.Add("q");


			Console.Write("\nLINQ : Remove items from list by creating object internally by filtering  : ");
			Console.Write("\n--------------------------------------------------------------------------\n");

			var _result1 = from y in listOfString
						   select y;
			Console.Write("Here is the list of items : \n");
			foreach (var tchar in _result1)
			{
				Console.WriteLine("Char: {0} ", tchar);
			}


			listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


			var _result = from z in listOfString
						  select z;
			Console.Write("\nHere is the list after removing the item 'p' from the list : \n");
			foreach (var rChar in _result)
			{
				Console.WriteLine("Char: {0} ", rChar);
			}
		}

		public void Exe19()
		{
			List<string> listOfString = new List<string>();
			listOfString.Add("m");
			listOfString.Add("n");
			listOfString.Add("o");
			listOfString.Add("p");
			listOfString.Add("q");


			Console.Write("\nLINQ : Remove items from list by passing filters  : ");
			Console.Write("\n--------------------------------------------------\n");

			var _result1 = from y in listOfString
						   select y;
			Console.Write("Here is the list of items : \n");
			foreach (var tchar in _result1)
			{
				Console.WriteLine("Char: {0} ", tchar);
			}


			listOfString.RemoveAll(en => en == "q");


			var _result = from z in listOfString
						  select z;
			Console.Write("\nHere is the list after removing item 'q' from the list : \n");
			foreach (var rChar in _result)
			{
				Console.WriteLine("Char: {0} ", rChar);
			}
		}

		public void Exe20()
		{
			List<string> listOfString = new List<string>();
			listOfString.Add("m");
			listOfString.Add("n");
			listOfString.Add("o");
			listOfString.Add("p");
			listOfString.Add("q");


			Console.Write("\nLINQ : Remove items from list by passing item index  : ");
			Console.Write("\n--------------------------------------------------\n");

			var _result1 = from y in listOfString
						   select y;
			Console.Write("Here is the list of items : \n");
			foreach (var tchar in _result1)
			{
				Console.WriteLine("Char: {0} ", tchar);
			}

			listOfString.RemoveAt(3);

			var _result = from z in listOfString
						  select z;
			Console.Write("\nHere is the list after removing item index 3 from the list : \n");
			foreach (var rChar in _result)
			{
				Console.WriteLine("Char: {0} ", rChar);
			}
		}

		public void Exe21()
		{
			List<string> listOfString = new List<string>();
			listOfString.Add("m");
			listOfString.Add("n");
			listOfString.Add("o");
			listOfString.Add("p");
			listOfString.Add("q");


			Console.Write("\nLINQ : Remove range of items from list by passing start index and number of elements to delete  : ");
			Console.Write("\n------------------------------------------------------------------------------------------------\n");

			var _result1 = from y in listOfString
						   select y;
			Console.Write("Here is the list of items : \n");
			foreach (var tchar in _result1)
			{
				Console.WriteLine("Char: {0} ", tchar);
			}

			listOfString.RemoveRange(1, 3);

			var _result = from z in listOfString
						  select z;
			Console.Write("\nHere is the list after removing the three items starting from the item index 1 from the list : \n");
			foreach (var rChar in _result)
			{
				Console.WriteLine("Char: {0} ", rChar);
			}
		}

		public void Exe22()
		{
			string[] arr1;
			int n, ctr;

			Console.Write("\nLINQ : Find the strings for a specific minimum length : ");
			Console.Write("\n------------------------------------------------------\n");

			Console.Write("Input number of strings to  store in the array :");
			n = Convert.ToInt32(Console.ReadLine());
			arr1 = new string[n];
			Console.Write("\nInput {0} strings for the array  :\n", n);
			for (int i = 0; i < n; i++)
			{
				Console.Write("Element[{0}] : ", i);
				arr1[i] = Console.ReadLine();
			}

			Console.Write("\nInput the minimum length of the item you want to find : ");
			ctr = Convert.ToInt32(Console.ReadLine());

			IEnumerable<string> objNew = from m in arr1
										 where m.Length >= ctr
										 orderby m
										 select m;
			Console.Write("\nThe items of minimum {0} characters are : \n", ctr);
			foreach (string z in objNew)
				Console.WriteLine("Item: {0}", z);


			var query = arr1.Where(x => x.Length >= ctr).OrderBy(x => x).Select(x => x);
			foreach (var element in query)
			{
				Console.WriteLine("Item: {0}", element);
			}
		}

		public void Exe23()
		{
			char[] charset1 = { 'X', 'Y', 'Z' };
			int[] numset1 = { 1, 2, 3, 4 };

			Console.Write("\nLINQ : Generate a cartesian product of two sets : ");
			Console.Write("\n------------------------------------------------\n");

			var cartesianProduct = from letterList in charset1
								   from numberList in numset1
								   select new { letterList, numberList };

			Console.Write("The cartesian product are : \n");
			foreach (var productItem in cartesianProduct)
			{
				Console.WriteLine(productItem);
			}

			var set1 = new string[] { "X", "Y", "Z" };
			var set2 = new int[] { 1, 2, 3, 4 };
			var query = set1.SelectMany(x => set2.Select(y => x + ' ' + y));
			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void Exe24()
		{
			char[] charset1 = { 'X', 'Y', 'Z' };
			int[] numset1 = { 1, 2, 3 };
			string[] colorset1 = { "Green", "Orange" };

			Console.Write("\nLINQ : Generate a cartesian product of three sets : ");
			Console.Write("\n----------------------------------------------------\n");

			var cartesianProduct = from letter in charset1
								   from number in numset1
								   from colour in colorset1
								   select new { letter, number, colour };

			Console.Write("The Cartesian Product are : \n");
			foreach (var ProductList in cartesianProduct)
			{
				Console.WriteLine(ProductList);
			}


			char[] set1 = { 'X', 'Y', 'Z' };
			int[] set2 = { 1, 2, 3 };
			string[] set3 = { "Green", "Pink" };

			var set12CartesianProduct = set1.SelectMany(letterList => set2.Select(numList => new { letterList, numList }));

			var cartesianProduct2 = set12CartesianProduct.SelectMany((set1and2) => set3.Select(colorList => new { set1and2.letterList, set1and2.numList, colorList }));

			Console.Write("The Cartesian Product are : \n");
			foreach (var ProductList in cartesianProduct2)
			{
				Console.WriteLine(ProductList);
			}
		}


		public class Item_mast
		{
			public int ItemId { get; set; }
			public string ItemDes { get; set; }
		}

		public class Purchase
		{
			public int InvNo { get; set; }
			public int ItemId { get; set; }
			public int PurQty { get; set; }
		}

		public void Exe25()
		{
			List<Item_mast> itemlist = new List<Item_mast> {
				new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
				new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
				new Item_mast { ItemId = 3, ItemDes = "Butter   " },
				new Item_mast { ItemId = 4, ItemDes = "Brade    " },
				new Item_mast { ItemId = 5, ItemDes = "Honey    " }
			};

			List<Purchase> purchlist = new List<Purchase> {
				new Purchase { InvNo = 100, ItemId = 3,  PurQty = 800 },
				new Purchase { InvNo = 101, ItemId = 2,  PurQty = 650 },
				new Purchase { InvNo = 102, ItemId = 3,  PurQty = 900 },
				new Purchase { InvNo = 103, ItemId = 4,  PurQty = 700 },
				new Purchase { InvNo = 104, ItemId = 3,  PurQty = 900 },
				new Purchase { InvNo = 105, ItemId = 4,  PurQty = 650 },
				new Purchase { InvNo = 106, ItemId = 1,  PurQty = 458 }
			};

			Console.Write("\nLINQ : Generate an Inner Join between two data sets : ");
			Console.Write("\n--------------------------------------------------\n");
			Console.Write("Here is the Item_mast List : ");
			Console.Write("\n-------------------------\n");

			foreach (var item in itemlist)
			{
				Console.WriteLine(
					"Item Id: {0}, Description: {1}",
					item.ItemId,
					item.ItemDes);
			}

			Console.Write("\nHere is the Purchase List : ");
			Console.Write("\n--------------------------\n");

			foreach (var item in purchlist)
			{
				Console.WriteLine(
					"Invoice No: {0}, Item Id : {1},  Quantity : {2}",
					item.InvNo,
					item.ItemId,
					item.PurQty);
			}

			Console.Write("\nHere is the list after joining  : \n\n");

			var innerJoin = from e in itemlist
							join d in purchlist on e.ItemId equals d.ItemId
							select new
							{
								itid = e.ItemId,
								itdes = e.ItemDes,
								prqty = d.PurQty
							};
			Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			Console.WriteLine("-------------------------------------------------------");
			foreach (var data in innerJoin)
			{
				Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
			}



			var queryJ = itemlist.Join(purchlist, item => item.ItemId, purch => purch.ItemId, (item, purch) => new { itID = item.ItemId, itDes = item.ItemDes, purQty = purch.PurQty });

			Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			Console.WriteLine("-------------------------------------------------------");
			foreach (var element in queryJ)
			{
				Console.WriteLine("{0}\t\t{1}\t\t{2}", element.itID, element.itDes, element.purQty);
			}

		}

		public void Exe26()
		{
			List<Item_mast> itemlist = new List<Item_mast> {
				new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
				new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
				new Item_mast { ItemId = 3, ItemDes = "Butter   " },
				new Item_mast { ItemId = 4, ItemDes = "Brade    " },
				new Item_mast { ItemId = 5, ItemDes = "Honey    " }
			};

			List<Purchase> purchlist = new List<Purchase> {
				new Purchase { InvNo = 100, ItemId = 3,  PurQty = 800 },
				new Purchase { InvNo = 101, ItemId = 2,  PurQty = 650 },
				new Purchase { InvNo = 102, ItemId = 3,  PurQty = 900 },
				new Purchase { InvNo = 103, ItemId = 4,  PurQty = 700 },
				new Purchase { InvNo = 104, ItemId = 3,  PurQty = 900 },
				new Purchase { InvNo = 105, ItemId = 4,  PurQty = 650 },
				new Purchase { InvNo = 106, ItemId = 1,  PurQty = 458 }
			};

			Console.Write("\nLINQ : Generate a Left Join between two data sets : ");
			Console.Write("\n--------------------------------------------------\n");
			Console.Write("Here is the Item_mast List : ");
			Console.Write("\n-------------------------\n");

			foreach (var item in itemlist)
			{
				Console.WriteLine(
					"Item Id: {0}, Description: {1}",
					item.ItemId,
					item.ItemDes);
			}

			Console.Write("\nHere is the Purchase List : ");
			Console.Write("\n--------------------------\n");

			foreach (var item in purchlist)
			{
				Console.WriteLine(
					"Invoice No: {0}, Item Id : {1},  Quantity : {2}",
					item.InvNo,
					item.ItemId,
					item.PurQty);
			}

			Console.Write("\nHere is the list after joining  : \n\n");


			var leftOuterJoin = from itm in itemlist
								join prch in purchlist
					on itm.ItemId equals prch.ItemId
					into a
								from b in a.DefaultIfEmpty(new Purchase())
								select new
								{
									itid = itm.ItemId,
									itdes = itm.ItemDes,
									prqty = b.PurQty
								};

			Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			Console.WriteLine("-------------------------------------------------------");
			foreach (var data in leftOuterJoin)
			{
				Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
			}


			var queryLJ = itemlist.GroupJoin(purchlist, item => item.ItemId, purch => purch.ItemId, (item, purch) => new { itemlist = item, purchlist = purch })
				.SelectMany(x => x.purchlist.DefaultIfEmpty(new Purchase()), (x, y) => new { itID = x.itemlist.ItemId, itDes = x.itemlist.ItemDes, purQty = y.PurQty });

			Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			Console.WriteLine("-------------------------------------------------------");
			foreach (var element in queryLJ)
			{
				Console.WriteLine("{0}\t\t{1}\t\t{2}", element.itID, element.itDes, element.purQty);
			}

		}

		public void Exe27()
		{
			List<Item_mast> itemlist = new List<Item_mast> {
				new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
				new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
				new Item_mast { ItemId = 3, ItemDes = "Butter   " },
				new Item_mast { ItemId = 4, ItemDes = "Brade    " },
				new Item_mast { ItemId = 5, ItemDes = "Honey    " }
			};

			List<Purchase> purchlist = new List<Purchase> {
				new Purchase { InvNo = 100, ItemId = 3,  PurQty = 800 },
				new Purchase { InvNo = 101, ItemId = 5,  PurQty = 650 },
				new Purchase { InvNo = 102, ItemId = 3,  PurQty = 900 },
				new Purchase { InvNo = 103, ItemId = 4,  PurQty = 700 },
				new Purchase { InvNo = 104, ItemId = 3,  PurQty = 900 },
				new Purchase { InvNo = 105, ItemId = 4,  PurQty = 650 },
				new Purchase { InvNo = 106, ItemId = 1,  PurQty = 458 }
			};

			Console.Write("\nLINQ : Generate a Right Join between two data sets : ");
			Console.Write("\n--------------------------------------------------\n");
			Console.Write("Here is the Item_mast List : ");
			Console.Write("\n-------------------------\n");

			foreach (var item in itemlist)
			{
				Console.WriteLine(
					"Item Id: {0}, Description: {1}",
					item.ItemId,
					item.ItemDes);
			}

			Console.Write("\nHere is the Purchase List : ");
			Console.Write("\n--------------------------\n");

			foreach (var item in purchlist)
			{
				Console.WriteLine(
					"Invoice No: {0}, Item Id : {1},  Quantity : {2}",
					item.InvNo,
					item.ItemId,
					item.PurQty);
			}

			Console.Write("\nHere is the list after joining  : \n\n");


			var rightOuterJoin = from p in purchlist
								 join i in itemlist
					on p.ItemId equals i.ItemId
					into a
								 from b in a.DefaultIfEmpty()
								 select new
								 {
									 itid = b.ItemId,
									 itdes = b.ItemDes,
									 prqty = p.PurQty
								 };

			Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			Console.WriteLine("-------------------------------------------------------");
			foreach (var data in rightOuterJoin)
			{
				Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
			}


			var queryROJ = (purchlist.GroupJoin(itemlist, left => left.ItemId, right => right.ItemId, (left, right) => new { itemlist = right, purchlist = left }))
				.SelectMany(p => p.itemlist.DefaultIfEmpty(), (x, y) => new { itID = x.purchlist.ItemId, itDes = y.ItemDes, purQty = x.purchlist.PurQty });
			Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			Console.WriteLine("-------------------------------------------------------");
			foreach (var element in queryROJ)
			{
				Console.WriteLine("{0}\t\t{1}\t\t{2}", element.itID, element.itDes, element.purQty);
			}
		}

		public void Exe28()
		{
			string[] cities = {
				"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
			};

			Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
			Console.Write("\n--------------------------------------------------------------------------------\n");
			Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
			Console.Write("\nHere is the arranged list :\n");
			IEnumerable<string> cityOrder = cities.OrderBy(str => str.Length).ThenBy(str => str);
			foreach (string city in cityOrder)
				Console.WriteLine(city);
		}

		public void Exe29()
		{
			string[] cities = {
				"ROME", "LONDON", "NAIROBI", "CALIFORNIA",
				"ZURICH", "NEW DELHI", "AMSTERDAM",
				"ABU DHABI", "PARIS", "NEW YORK"
			};

			Console.Write("\nLINQ : Split a collection of strings into some groups  : ");
			Console.Write("\n-------------------------------------------------------\n");
			Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI', \n");
			Console.Write("                   'AMSTERDAM','ABU DHABI','PARIS','NEW YORK' \n");
			Console.Write("\nHere is the group of cities : \n\n");

			var citySplit = from i in Enumerable.Range(0, cities.Length)
							group cities[i] by i / 3;

			foreach (var city in citySplit)
				cityView(string.Join(";  ", city.ToArray()));

		}

		static void cityView(string cityMetro)
		{
			Console.WriteLine(cityMetro);
			Console.WriteLine("-- here is a group of cities --\n");
		}

		public void Exe30()
		{
			Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : ");
			Console.Write("\n----------------------------------------------------------------\n");

			var itemlist = (from c in Item_Mast.GetItemMast()
							select c.ItemDes)
					.Distinct()
					.OrderBy(x => x);

			foreach (var item in itemlist)
				Console.WriteLine(item);
		}

	}

	class Item_Mast
	{
		public int ItemId { get; set; }
		public string ItemDes { get; set; }

		public static List<Item_Mast> GetItemMast()
		{
			List<Item_Mast> itemlist = new List<Item_Mast>();
			itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
			itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
			itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
			itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
			itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
			itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
			return itemlist;
		}
	}
}

