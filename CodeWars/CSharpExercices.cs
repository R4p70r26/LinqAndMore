using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class CSharpExercices
    {
		///https://csharpexercises.com/linq
		/// 


		public void NumsFromRange()
		{
			List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };


			var query = Numbers.Where(x => x > 30).Where(x => x < 100).Select(x => x);

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void MinLength()
		{
			List<string> animals = new List<string> {
				"zebra",
				"elephant",
				"cat",
				"dog",
				"rhino",
				"bat"
			};

			var query = animals.Where(x => x.Length >= 5).Select(x => x.ToUpper());
			foreach (var element in query)
			{
				Console.WriteLine(element);// ZEBRA, ELEPHANT, RHINO
			}

		}

		public void SelectWrdLetters()
		{
			List<string> words = new List<string> {
				"alabam",
				"am",
				"balalam",
				"tara",
				"",
				"a",
				"axeliam",
				"39yo0m",
				"trol"
			};

			var query = words.Where(x => x.StartsWith("a")).Where(x => x.EndsWith("m"));

			foreach (var element in query)
			{
				Console.WriteLine(element);// alabam, am, axeliam
			}

		}

		public void Top5Nums()
		{
			List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };

			var query = numbers.OrderByDescending(x => x).Take(5);

			foreach (var element in query)
			{
				Console.WriteLine(element);// 999 443 54 24 11
			}

		}


		public void SquareGtrthan20()
		{
			List<int> Numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

			var query = Numbers.Where(x => x * x > 20);
			foreach (var element in query)
			{
				Console.WriteLine("{0} -> {1}", element, element * element);// 9 - 81, 6 - 36, 5 - 25, 7 - 49
			}

		}

		public void ReplaceSubstring()
		{
			var words = new[] {
				"near",
				"speak",
				"tonight",
				"weapon",
				"customer",
				"deal",
				"lawyer"
			};

			var query = words.Select(x => x.Contains("ea") ? x.Replace("ea", "*") : x);
			foreach (var element in query)
			{
				Console.WriteLine(element);// n*r sp*k tonight w*pon customer d*l lawyer
			}

		}

		public void LastWrdConLtr()
		{
			var words = new List<string> {
				"cow",
				"dog",
				"elephant",
				"cat",
				"rat",
				"squirrel",
				"snake",
				"stork"
			};

			var query = words.OrderBy(x => x).Where(x => x.Contains("e")).Select(x => x);
			var word = words.OrderBy(x => x).LastOrDefault(w => w.Contains("e"));
			foreach (var element in query)
			{
				Console.WriteLine(element);// squirrel
			}

		}


		public void ShuffleArray()
		{
			var rnd = new Random();
			var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var query = array.OrderBy(x => rnd.Next());

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void DecryptNum()
		{
			var chars = new char[] {
				')',
				'!',
				'@',
				'#',
				'$',
				'%',
				'^',
				'&',
				'*',
				'('
			};

			var encryptedNumber = "#(@*%)$(&$*#&";
			var decryptedNumber = string.Join("", encryptedNumber.Select(c => Array.IndexOf(chars, c)));

			Console.WriteLine(decryptedNumber); // 3928504974837
		}

		public void MostFreqChar()
		{
			string str = "49fjs492jfJs94KfoedK0iejksKdsj3";

			var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

			Console.Write(mostFrequentCharacter);
		}

		public void UniqueVals()
		{
			var values = new List<string> {
				"Hi",
				"Meow",
				"Hello",
				"Meow",
				"Hi!",
				"Meow",
				"Hi",
				"Bye"
			};
			var query = values.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToList();

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void RetUppercase()
		{
			string word = "THIS is UPPERCASE string LOL";

			var query = word.Split(' ').Where(x => string.Equals(x, x.ToUpper()));

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void ArrdotProd()
		{
			int[] array1 = new int[] { 5, 8, 2, 9 };
			int[] array2 = new int[] { 1, 7, 2, 4 };

			var query = array1.Zip(array2, (x, y) => x * y).Sum();

			Console.WriteLine(query);

		}

		public void FreqLetrs()
		{
			string word = "abracadabra";

			var query = word.GroupBy(x => x);

			foreach (var element in query)
			{
				Console.WriteLine("Letter {0} occurs {1} time(s)", element.Key, element.Count());
			}

		}

		public void DayNames()
		{
			var query = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}
		}

		public void DoubleLtrs()
		{
			var query = Enumerable.Range((char)65, 26).SelectMany(x => Enumerable.Range((char)65, 26).Select(y => (char)x + "" + (char)y));
			foreach (var element in query)
			{
				Console.WriteLine(element + " ");
			}
		}

		public void HManyDays(DateTime past, DateTime now)
		{
			Console.WriteLine((now - past).Days);
		}
	}
}
