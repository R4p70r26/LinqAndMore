using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndMore
{
    public class LnqPractice
    {
		public void QueryParts()
		{

			//first = data source
			int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			//second = query creation
			var nquery = from vrnum in nums where (vrnum % 2) == 0 select vrnum;

			//third = query execution
			foreach (int vrnum in nquery)
			{
				Console.WriteLine(vrnum);
			}

		}

		public void QueryPositiveHunt()
		{

			int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			var query = from nums in n1 where (nums > 0) where (nums < 12) select nums;

			foreach (int element in query)
			{
				Console.WriteLine(element);
			}

		}

		public void QuerySquareNum()
		{
			int[] numArr = { 3, 9, 2, 8, 6, 5 };

			var query = from int Number in numArr
						let SqrNo = Number * Number
						where SqrNo > 20
						select new { Number, SqrNo };

			foreach (var element in query)
			{
				Console.WriteLine(element);
			}

		}


		public void LnqPrac()
		{
			//Enumerable.Range(2,10).Select(c => new {Lenght = 2* c, height = c * c -1, hypoenuse = c * c +1}).Dump("Pythadorean triples");
			var some = Enumerable.Range(2, 10).Select(c => new { Lenght = 2 * c, height = c * c - 1, hypoenuse = c * c + 1 });

			foreach (var element in some)
			{
				Console.WriteLine(element);
			}

		}

		//https://www.w3resource.com/csharp-exercises/linq/index.php

	}


}
