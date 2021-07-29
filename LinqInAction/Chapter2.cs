using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInAction
{
    class Chapter2
    {
		public void Listing21()
		{//listing processes
			List<String> processes = new List<String>();

			foreach (Process process in Process.GetProcesses())
			{
				processes.Add(process.ProcessName);
			}

			foreach (var element in processes)
			{
				Console.WriteLine(element);
			}

		}

		class ProcessData//listing22
		{
			public Int32 Id { get; set; }
			public Int64 Memory { get; set; }
			public String Name { get; set; }

			public ProcessData()
			{
			}

			public ProcessData(Int32 Id, Int64 Memory, String Name)
			{
				this.Id = Id;
				this.Memory = Memory;
				this.Name = Name;
			}
		}

		public void Listing22()
		{
			List<ProcessData> processes = new List<ProcessData>();

			foreach (Process proce in Process.GetProcesses())
			{
				ProcessData data = new ProcessData();
				data.Id = proce.Id;
				data.Name = proce.ProcessName;
				data.Memory = proce.WorkingSet64;
				processes.Add(data);
			}

			ObjectDumper.Write(processes);

		}

		public void Listing23()
		{
			var processes = new List<ProcessData>();

			foreach (var process in Process.GetProcesses())
			{
				var data = new ProcessData();
				data.Id = process.Id;
				data.Name = process.ProcessName;
				data.Memory = process.WorkingSet64;
				processes.Add(data);
			}

			ObjectDumper.Write(processes);

		}

		public void Listing24()//with constructor
		{
			var processes = new List<ProcessData>();
			foreach (var process in Process.GetProcesses())
			{
				processes.Add(new ProcessData(
					process.Id,
					Convert.ToInt64(process.ProcessName),
					process.WorkingSet64.ToString()
				));
			}
		}

		public void Listing25()//with object initializer
		{
			var processes = new List<ProcessData>();
			foreach (var process in Process.GetProcesses())
			{
				processes.Add(new ProcessData
				{
					Id = process.Id,
					Name = process.ProcessName,
					Memory = process.WorkingSet64
				});
			}

			ObjectDumper.Write(processes);
		}

		public void Listing26()//with hardcoded filtering condition
		{
			var processes = new List<ProcessData>();
			foreach (var process in Process.GetProcesses())
			{
				if (process.WorkingSet64 >= 20 * 1024 * 1024)
				{
					processes.Add(new ProcessData
					{
						Id = process.Id,
						Name = process.ProcessName,
						Memory = process.WorkingSet64
					});
				}
			}

			ObjectDumper.Write(processes);
		}
	}
}
