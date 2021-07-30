using System;
using System.Diagnostics;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkClass woCls = new WorkClass();
            W3LnqExerci w3Exe = new W3LnqExerci();
            CSharpExercices csExe = new CSharpExercices();
            RegexClass regexClass = new RegexClass();

            Stopwatch stopwatch = new Stopwatch();







            stopwatch.Start();//start the watch
                              //execute whateva

            
            stopwatch.Stop();//stop watch

            Console.WriteLine("Time: {0}", Convert.ToInt32(stopwatch.ElapsedMilliseconds));



            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
