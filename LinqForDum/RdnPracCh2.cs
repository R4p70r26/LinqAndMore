using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqForDum
{
    class RdnPracCh2
    {
		private int randomGenerator()
		{
			Random rnd = new Random();

			return rnd.Next(50);
		}

		private int[] rndArrGenerator()
		{
			int[] arr = new int[randomGenerator()];
			return arr;
		}

		private int[] fillArr(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = randomGenerator();
			}
			return arr;
		}

		public int[] arrGen()
		{
			return fillArr(rndArrGenerator());
		}

		public void LinqOrder()
		{
			int[] arrNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var query = from qNum in arrNum
						where (qNum % 2) == 0
						select qNum;

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public List<string> Nums(List<string> lstStr)
		{
			for (int i = 0; i < lstStr.Count; i++)
			{
				lstStr[i] = i + 1 + ": " + lstStr[i];
			}

			return lstStr;
		}

		//		public List<string> Number(List<string> lines) => lines.Select((x, i) => $"{i + 1}: {x}").ToList();


		//
		//https://csharpexercises.com/linq
		//
		public void numsRange()
		{
			int[] nums = { 67, 92, 153, 15 };

			//			var query = from qval in nums
			//			            where qval < 100
			//			            where qval > 30
			//			            select qval;

			//			var query = nums.Where(qval => qval < 100).Where(qval => qval > 30).Select(qval => qval);
			var query = nums.Where(qval => qval < 100).Where(qval => qval > 30);

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void MinLentoUp()
		{
			string[] strWo = { "computer", "usb", "website", "cookies" };

			var query = strWo.Where(x => x.Length >= 5).Select(x => x.ToUpper());

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void SelectWordSE()
		{
			string[] strA = {
				"alabam",
				"am",
				"balalam",
				"tara",
				"",
				"a",
				"axeliam",
				"39yo0m",
				"trol",
				"amsterdam"
			};

			var query = strA.Where(x => x.StartsWith("a")).Where(x => x.EndsWith("m"));

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void TopfiveNums()
		{
			int[] nums = {
				78,
				-9,
				0,
				23,
				54,
				21,
				7,
				86,
				6,
				0,
				999,
				11,
				443,
				6,
				1,
				24,
				54
			};

			var query = nums.OrderByDescending(x => x).Take(5);

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void SquareGreat()
		{
			int[] nums = { 7, 2, 30, 3, 9, 2, 4, 6, 5, 8 };

			var query = nums.Where(x => x * x > 20);

			foreach (var element in query)
			{
				Console.WriteLine(element + " || " + element * element);
			}
		}

		public void ReplaceSub()
		{
			string[] strW = {
				"learn",
				"current",
				"near",
				"speak",
				"tonight",
				"weapon",
				"customer",
				"deal",
				"lawyer"
			};

			var query = strW.Select(x => x.Contains("ea") ? x.Replace("ea", "**") : x);

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}
		}

		public void RetLetE()
		{
			List<string> strA = new List<string>() {
				"plane",
				"ferry",
				"car",
				"bike",
				"cow",
				"dog",
				"elephant",
				"cat",
				"rat",
				"squirrel",
				"snake",
				"stork"
			};

			var query = strA.OrderBy(x => x).LastOrDefault(x => x.Contains("e"));

			Console.WriteLine(query);

		}

		public int SumLowst(int[] intA)
		{
			return intA.OrderBy(x => x).Take(2).Sum();
		}

		public int[] MinMax(int[] arr)
		{
			//			if (arr.Length == 1) {
			//				int[] arT = new int[2];
			//				for (int i = 0; i < arT.Length; i++) {
			//					arT[i] = arr[0];
			//				}
			//				return arT;
			//			}
			//
			//			return arr.OrderBy(x => x).Take(1).Union(arr.OrderByDescending(x => x).Take(1)).ToArray();

			return new int[] { arr.Min(), arr.Max() };

		}

		public double ArithStr(int a, int b, string oper)
		{
			switch (oper.ToLower())
			{
				case "add":
					return a + b;
				case "subtract":
					return a - b;
				case "multiply":
					return a * b;
				case "divide":
					return a / b;
			}
			return Double.NaN;
		}

		public int SqrDigit(int num)
		{
			var query = num.ToString().Select(x => Convert.ToInt32(x) - 48).ToArray().Select(x => x * x);

			//			Console.WriteLine(query);
			string n = "";
			foreach (var element in query)
				n = n + element;

			Console.WriteLine(n);

			return Convert.ToInt32(n);

		}

		public int[] SortOdd(int[] arr)
		{
			List<int> odds = new List<int>();

			for (int i = 0; i < arr.Length; i++)
			{
				if ((arr[i] % 2) != 0)
				{
					odds.Add(arr[i]);
				}
			}

			odds.Sort();

			for (int i = 0; i < arr.Length; i++)
			{
				if ((arr[i] % 2) != 0)
				{
					arr[i] = odds[0];
					odds.RemoveAt(0);
				}
			}

			foreach (var element in arr)
			{
				Console.WriteLine(element);
			}

			return arr;

			//			Queue<int> odds = new Queue<int>(array.Where(e => e%2 == 1).OrderBy(e => e));
			//
			//          return array.Select(e => e%2 == 1 ? odds.Dequeue() : e).ToArray();
		}

		public int FindOddInt(int[] arr)
		{

			//			var dicti = new Dictionary<int,int>();
			//			foreach (var element in arr) {
			//				if (dicti.ContainsKey(element)) {
			//					dicti[element]++;
			//				} else {
			//					dicti[element] = 1;
			//				}
			//			}
			//
			//			foreach (var element in dicti) {
			////				Console.WriteLine(element.Key + " || " + element.Value);
			//
			//				if ((element.Value % 2) != 0) {
			//					//Console.WriteLine(element.Key);
			//					return element.Key;
			//				}
			//
			//			}

			Console.WriteLine(arr.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key);

			return arr.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
		}

		public string Tickets(int[] dolla)
		{

			int twfive = 0;
			int fift = 0;
			int hundr = 0;

			foreach (var element in dolla)
			{

				switch (element)
				{
					case 25:
						twfive += 1;
						break;
					case 50:
						if (twfive > 0)
						{
							fift += 1;
							twfive -= 1;
							break;
						}
						return "NO";
					case 100:
						if (twfive > 0 && fift > 0)
						{
							twfive -= 1;
							fift -= 1;
							hundr += 1;
							break;
						} else if (twfive >= 3)
						{
							twfive -= 3;
							hundr += 1;
							break;
						} else
						{
							return "NO";
						}
				}
			}

			return "YES";

		}

		public int SquareArr(int[] arr)
		{
			var query = arr.Select(x => x * x).Sum();

			Console.WriteLine(query);

			return arr.Select(x => x * x).Sum();
		}

		public int SumNums(int a, int b)
		{

			int min = Math.Min(a, b);
			int max = Math.Max(a, b);

			Console.WriteLine((max - min + 1) * (min + max) / 2);

			int res = 0;
			for (int i = min; i <= max; i++)
			{
				res += i;
			}
			Console.WriteLine(res);


			return (max - min + 1) * (min + max) / 2;


		}
	}
}
