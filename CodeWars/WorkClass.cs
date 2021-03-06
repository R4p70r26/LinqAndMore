using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class WorkClass
    {
        public static int SumLowst(int[] intA)
        {
            return intA.OrderBy(x => x).Take(2).Sum();
        }

        public static int[] MinMax(int[] arr)
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

        public static int SqrDigit(int num)
        {
            var query = num.ToString().Select(x => Convert.ToInt32(x) - 48).ToArray().Select(x => x * x);

            //			Console.WriteLine(query);
            string n = "";
            foreach (var element in query)
                n = n + element;

            Console.WriteLine(n);

            return Convert.ToInt32(n);

        }

        public static int[] SortOdd(int[] arr)
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

        public static int FindOddInt(int[] arr)
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

        public static string Tickets(int[] dolla)
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

        public static int SquareArr(int[] arr)
        {
            var query = arr.Select(x => x * x).Sum();

            Console.WriteLine(query);

            return arr.Select(x => x * x).Sum();
        }

        public int SumNums(int a, int b)
        {
            //			woCls.SumNums(-1, 2);
            //			woCls.SumNums(-1, 0);
            //			woCls.SumNums(1, 1);

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

        public string VowelRemove(string str)
        {//			woCls.VowelRemove("This website is for losers LOL!");

            //			var query = str.ToCharArray().Where(x => x != 'a').Where(x => x != 'e').Where(x => x != 'i').Where(x => x != 'o').Where(x => x != 'u');
            var query = str.Where(x => !"aeiou".Contains(x)).Where(x => !"aeiou".ToUpper().Contains(x)).Select(x => x);
            str = "";
            foreach (var element in query)
            {
                Console.Write(element);
                str += element;
            }

            return str;
            //			return String.Concat(str.Where(x => !"aeiou".Contains(x)).Where(x => !"aeiou".ToUpper().Contains(x)).Select(x => x));
            //			return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public string RemoveLastChar(string str)
        {//			woCls.RemoveLastChar("Find odd");
            str = str.Remove(str.Length - 1, 1).Remove(0, 1);
            return str;
        }

        public int SmallestIntArray(int[] args)
        {
            //			woCls.SmallestIntArray(new int[]{34, 15, 88, 2});
            //			woCls.SmallestIntArray(new int[]{34, -345, -1, 100});
            return args.Min();
        }

        public int OnesAndZeros(int[] binArr)//binaryint array to decimal
        {
            //			woCls.OnesAndZeros(new int[]{0,0,0,1});//1
            //			woCls.OnesAndZeros(new int[]{1,0,0,1});//2
            string str = "";
            foreach (var element in binArr)
            {
                str += element;
            }
            Console.WriteLine(Convert.ToInt32(str, 2));

            return Convert.ToInt32(str, 2);

            //return Convert.ToInt32(string.Join("", binArr), 2);
        }

        public string NoSpaceString(string str)
        {
            //			woCls.NoSpaceString("s i m p l e");
            Console.WriteLine(str.Replace(" ", ""));
            return str.Replace(" ", "");
        }

        public string RGBtoHex(int r, int g, int b)
        {
            //			woCls.RGBtoHex(255,255,255);
            //			woCls.RGBtoHex(255,255,300);
            //			woCls.RGBtoHex(0,0,0);
            //			woCls.RGBtoHex(148,0,211);
            //			woCls.RGBtoHex(148,-20,211);
            //			woCls.RGBtoHex(212,53,12);
            if (r > 255)
            {
                r = 255;
            } else if (r < 0)
            {
                r = 0;
            }
            if (g > 255)
            {
                g = 255;
            } else if (g < 0)
            {
                g = 0;
            }
            if (b > 255)
            {
                b = 255;
            } else if (b < 0)
            {
                b = 0;
            }

            Console.WriteLine(string.Format("{0:X2}{1:X2}{2:X2}", r, g, b));

            return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);


            //return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");

        }

        public string CamelCase(string str)
        {
            //			woCls.CamelCase("the-stealth-warrior");
            //			woCls.CamelCase("The_Stealth_Warrior");
            if (str.Contains("-"))
            {
                char[] chArr = str.ToCharArray();

                for (int i = 1; i < chArr.Length; i++)
                {
                    if (chArr[i] == '-')
                    {
                        chArr[i + 1] = char.ToUpper(chArr[i + 1]);
                    }
                }
                str = new String(chArr).Replace("-", "");
            }

            if (str.Contains("_"))
            {
                char[] chArr = str.ToCharArray();

                for (int i = 1; i < chArr.Length; i++)
                {
                    if (chArr[i] == '_')
                    {
                        chArr[i + 1] = char.ToUpper(chArr[i + 1]);
                    }
                }
                str = new String(chArr).Replace("_", "");
            }

            return str;

            //return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());

        }

        public int IQTest(string numsStr)
        {
            //			woCls.IQTest("2 4 7 8 10");
            //			woCls.IQTest("1 2 2");
            //			woCls.IQTest("2 4 7 8 10");
            //			woCls.IQTest("5 3 2");
            //			woCls.IQTest("100 100 1");
            int[] nums = numsStr.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int cOdd = 0;
            int cEvn = 0;
            int posOdd = 0;
            int posEvn = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    posEvn = i;
                    cEvn++;
                } else
                {
                    posOdd = i;
                    cOdd++;
                }
            }

            if (cEvn > cOdd)
            {
                Console.WriteLine(posOdd + 1);
                return posOdd + 1;
            } else
            {
                Console.WriteLine(posEvn + 1);
                return posEvn + 1;
            }

            //			var ints = numbers.Split(' ').Select(int.Parse).ToList();
            //			var unique = ints.GroupBy(n => n % 2).OrderBy(c => c.Count()).First().First();
            //			return ints.FindIndex(c => c == unique) + 1;
            //
            //
            //			return numbers.Split(' ')
            //    .Select((v, i) => new {numbers = v, index = i})
            //    .GroupBy(g => Convert.ToInt32(g.numbers) % 2)
            //    .First(w => w.Count() == 1)
            //    .Select(s => s.index).First() + 1;

            //https://www.codewars.com/kata/552c028c030765286c00007d/solutions/csharp
        }

        public void EvenOdd(int num)
        {
            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> retList = new List<string>();
            char[] wordChar = word.ToCharArray();//get chars on original string
            Array.Sort(wordChar);//sort them out

            for (int i = 0; i < words.Count; i++)
            {
                char[] temp = words[i].ToCharArray();
                Array.Sort(temp);
                if (new String(wordChar) == new String(temp))
                {//creates 2 new strings to compare them
                    Console.WriteLine(words[i]);
                    retList.Add(words[i]);//adds the word to the list
                }
            }
            return retList;

            //			var pattern = word.OrderBy(p => p).ToArray();
            //			return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();

            //			return words?.Where(w => w.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
        }

        //		public List<string> Anagrams2(string word, List<string> words) =>
        //          words
        //         .Where(x => String.Concat(x.OrderBy(c => c)).Equals(String.Concat(word.OrderBy(c => c))))
        //         .Select(x => x)
        //         .ToList();


        public static String Maskify(string str)
        {
            string retStr = "";
            if (str.Length > 4)
            {

                for (int i = 0; i < str.Length - 4; i++)
                {
                    retStr += "#";
                }
                retStr += str.Substring(str.Length - 4, 4);
                return retStr;
            }

            return str;

            //            return str.Substring(str.Length < 4 ? 0 : str.Length - 4).PadLeft(str.Length, '#');
        }


        public static int DigitalRoot(long num)
        {
            long sum = 0;
            while (num > 0)
            {
                sum += (num % 10);
                num = num / 10;

                if (sum >= 10 && num == 0)
                {
                    num = sum;
                    sum = 0;
                }
            }
            return (int)sum;

            //return (int)(1 + (n - 1) % 9);

            //			while (n > 9)
            //                n = n.ToString().Select(c => Convert.ToInt32(c.ToString())).Sum();
            //          return (int)n

        }

        public int OrderInteger(int num)
        {
            var q = num.ToString().OrderByDescending(n => n).Select(n => n);
            string str = "";

            foreach (var element in q)
            {
                str += element;
            }

            return Convert.ToInt32(str);


            //return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }

        public int FindUniqueNum(IEnumerable<int> numbers)
        {
            //			woCls.FindUniqueNum(new []{ 1, 1, 1, 2, 1, 1 });//2
            //			woCls.FindUniqueNum(new []{ 0, 0, 5, 0, 0 });//0.55
            //			woCls.FindUniqueNum(new []{ 1, 2, 2, 2 });//1
            //			woCls.FindUniqueNum(new []{ -2, 2, 2, 2 });//-2
            //			woCls.FindUniqueNum(new []{ 11, 11, 14, 11, 11 });//14
            var query = numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);

            foreach (var element in query)
            {
                //				Console.WriteLine(element);
                return element;
            }

            Console.WriteLine(query);

            return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;

        }

        public string OrderString(string words)
        {
            //TODO: remove numbers for fun

            //woCls.OrderString("is2 Thi1s T4est 3a");
            //woCls.OrderString("4of Fo1r pe6ople g3ood th5e the2");
            List<string> list = words.Split(' ').ToList();
            words = "";

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Contains((i + 1).ToString()))
                    {
                        words += String.Concat(list[j] + " ");
                    }
                }
            }

            Console.WriteLine(words.TrimEnd(' '));
            return words.TrimEnd(' ');

            //			return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        }

        public String SumOddEvn(int[] arr)
        {
            // Console.WriteLine(woCls.SumOddEvn(new int[]{0,1,4}));
            // Console.WriteLine(woCls.SumOddEvn(new int[]{0,-1,-5}));
            return (arr.Sum() % 2) == 0 ? "even" : "odd";
        }

        public string[] SplitStrings(string str)
        {
            // woCls.SplitStrings("abc");
            // woCls.SplitStrings("abcdef");
            if ((str.Length % 2) == 1)
            {
                str += "_";
            }

            List<string> pair = new List<string>();

            foreach (Match match in Regex.Matches(str, ".."))
            {
                pair.Add(match.Value);
            }

            string[] paStr = pair.ToArray();

            return paStr;

            ///LINQ
            //             if (str.Length % 2 != 0)
            //                 str += "_";
            //             return Enumerable.Range(0, str.Length)
            //               .Where(x => x % 2 == 0)
            //               .Select(x => str.Substring(x, 2))
            //               .ToArray();

            //Regex
            //            return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        }

        public int VowelCount(string str)
        {
            // Console.WriteLine(woCls.VowelCount("The input string will only"));
            return str.Where(x => "aeiou".Contains(x)).Select(x => x).Count();
        }

        public int ParOutlier(int[] inArr)
        {
            //returns the only odd or even on the array

            //Console.WriteLine(woCls.ParOutlier(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
            //Console.WriteLine(woCls.ParOutlier(new int[] { 160, 3, 1719, 19, 11, 13, -21 }));
            return inArr.GroupBy(x => (x % 2 == 0)).Single(x => x.Count() == 1).FirstOrDefault();
        }

        public String AbbrevName(String name)
        {
            string[] arr = name.Split(' ');
            return String.Format("{0}.{1}", arr[0].Substring(0, 1), arr[1].Substring(0, 1)).ToUpper();

            // string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
        }

        public string CreatePhone(int[] nArr)
        {
            // Console.WriteLine(woCls.CreatePhone(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            string number = "(";
            for (int i = 0; i < 3; i++)
            {
                number += nArr[i];
            }
            number += ") ";
            for (int i = 3; i < 6; i++)
            {
                number += nArr[i];
            }
            number += "-";
            for (int i = 6; i < 10; i++)
            {
                number += nArr[i];
            }
            return number;

            // return long.Parse(string.Concat(nArr)).ToString("(000) 000-0000");

        }

        public string MinMax(string numbers)
        {
            //            Console.WriteLine(woCls.MinMax("1 2 3 4 5"));
            //            Console.WriteLine(woCls.MinMax("1 2 -3 4 5"));
            //            Console.WriteLine(woCls.MinMax("1 2 3 4 -5"));
            string[] sArr = numbers.Split(' ');
            int[] nArr = new int[sArr.Length];

            for (int i = 0; i < sArr.Length; i++)
            {
                nArr[i] = Convert.ToInt32(sArr[i]);
            }

            int max = nArr.Max();
            int min = nArr.Min();

            return String.Format("{0} {1}", max, min);


            //			 var parsed = numbers.Split().Select(int.Parse);
            //			 return parsed.Max() + " " + parsed.Min();

        }

        public void TwotoOne()
        {
            string str1 = "xyaabbbccccdefww";
            string str2 = "xxxxyyyyabklmopq";
            Console.WriteLine(longest(str1, str2));

            str1 = "aretheyhere";
            str2 = "yestheyarehere";
            Console.WriteLine(longest(str1, str2));

            str1 = "loopingisfunbutdangerous";
            str2 = "lessdangerousthancoding";
            Console.WriteLine(longest(str1, str2));

            str1 = "inmanylanguages";
            str2 = "theresapairoffunctions";
            Console.WriteLine(longest(str1, str2));
        }

        private string longest(string str1, string str2)
        {
            return String.Concat(String.Concat(str1, str2).OrderBy(c => c).Distinct());
        }

        public void Tester(string str)
        {
            var ints = str.Split(' ').Select(int.Parse).ToList();

            var uniq = ints.GroupBy(x => x % 2).OrderBy(n => n.Count()).First().First();

            Console.WriteLine(ints.FindIndex(x => x == uniq) + 1);
        }

        public static int[] Divisors(int n)
        {
            List<int> divs = new();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    divs.Add(i);
                }
            }

            int[] arr = divs.Count != 0 ? divs.ToArray() : null;

            return arr;

            //var div = Enumerable.Range(2, (int)Math.Sqrt(n))
            //            .Where(x => n % x == 0 && x < n)
            //            .SelectMany(x => new[] { x, n / x })
            //            .OrderBy(x => x)
            //            .Distinct()
            //            .ToArray();

            //return div.Any() ? div : null;
        }

        public IEnumerable<string> Permutate(string str)//permutates but only dif chars
        {
            if (str.Length <= 1)
            {
                return new List<string> { str };
            }

            var permutations = from c in str
                               from p in Permutate(new String(str.Where(x => x != c).ToArray()))
                               select c + p;
            return permutations;

        }

        public static IEnumerable<string> GetPermutations(string s)//permute 
        {
            if (s.Length > 1)
                return from ch in s
                       from permutation in GetPermutations(s.Remove(s.IndexOf(ch), 1))
                       select string.Format("{0}{1}", ch, permutation);

            else
                return new string[] { s };
        }

        public static IEnumerable<string> OpenOrSenior(int[][] arr)
        {
            string[] value = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0] >= 55 && arr[i][1] > 7)
                {
                    value[i] = "Senior";
                } else
                {
                    value[i] = "Open";
                }
            }


            return value.ToList();

            //return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }

    }
}
