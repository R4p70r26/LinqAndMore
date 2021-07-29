using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInAction
{
    class Chapter1
    {
		public void Listing16()
		{
			string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

			// Get only short words
			var shortWords =
				from word in words
				where word.Length <= 5
				select word;

			// Print each word out
			foreach (var word in shortWords)
				Console.WriteLine(word);
		}

		public void Listing19()
		{
			string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

			// Group words by length
			var groups =
				from word in words
				orderby word ascending
				group word by word.Length into lengthGroups
				orderby lengthGroups.Key descending
				select new { Length = lengthGroups.Key, Words = lengthGroups };

			// Print each group out
			foreach (var group in groups)
			{
				Console.WriteLine("Words of length " + group.Length);
				foreach (string word in group.Words)
					Console.WriteLine("  " + word);
			}
		}
	}
}
