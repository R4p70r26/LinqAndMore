using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInAction
{
    class Chapter3
    {
		public void Listing341()
		{
			// Method syntax (dot-notation)
			var processes1 =
				Process.GetProcesses()
		  .Where(process => process.WorkingSet64 > 20 * 1024 * 1024)
		  .OrderByDescending(process => process.WorkingSet64)
		  .Select(process => new { process.Id, Name = process.ProcessName });

			Console.WriteLine("With method syntax:");
			foreach (var process in processes1)
				Console.WriteLine(process);

			Console.WriteLine();

			// Query expression
			var processes2 =
				from process in Process.GetProcesses()
				where process.WorkingSet64 > 20 * 1024 * 1024
				orderby process.WorkingSet64 descending
				select new { process.Id, Name = process.ProcessName };

			Console.WriteLine("With query expression:");
			foreach (var process in processes2)
				Console.WriteLine(process);
		}

		public void ListingDB()
		{

		}
	}
}
