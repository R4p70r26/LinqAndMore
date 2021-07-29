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


            //			w3Exe.Exe29();
            //			csExe.HManyDays(new DateTime(1946,1,1),DateTime.Now);




            //			woCls.SortOdd(new int[]{ 7, 1 });
            //			woCls.SortOdd(new int[]{ 5, 8, 6, 3, 4 });
            //			woCls.SortOdd(new int[]{ 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            //			woCls.FindOddInt(new int[]{ 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });//5
            //			woCls.FindOddInt(new int[]{ 1, 1, 2, -2, 5, 2, 4, 4, -1, -2, 5 });//-4
            //			woCls.FindOddInt(new int[]{ 20, 1, 1, 2, 2, 3, 3, 5, 5, 4, 20, 4, 5 });//5
            //			woCls.FindOddInt(new int[]{ 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });//10
            //			woCls.FindOddInt(new int[]{ 5, 4, 3, 2, 1, 5, 4, 3, 2, 10, 10 });//1

            //			woCls.Tickets(new int[]{ 25, 25, 50, 100 }); //yes
            //			woCls.Tickets(new int[]{ 25, 25, 25, 25, 50, 100, 50 }); //yes
            //			woCls.Tickets(new int[]{ 25, 25, 50 });//yes
            //			woCls.Tickets(new int[]{ 25, 25, 50, 50, 100 });//no

            //			Console.WriteLine(woCls.SquareArr(new int[]{ 1, 2, 2 }));//9
            //			woCls.SquareArr(new int[]{ 1, 2 });//5
            //			woCls.SquareArr(new int[]{ 5, 3, 4 });//50

            //			woCls.SumNums(-1, 2);
            //			woCls.SumNums(-1, 0);
            //			woCls.SumNums(1, 1);

            //			woCls.VowelRemove("This website is for losers LOL!");

            //			woCls.RemoveLastChar("Find odd");

            //			woCls.SmallestIntArray(new int[]{34, 15, 88, 2});
            //			woCls.SmallestIntArray(new int[]{34, -345, -1, 100});

            //			woCls.OnesAndZeros(new int[]{0,0,0,1});//1
            //			woCls.OnesAndZeros(new int[]{1,0,0,1});//2

            //			woCls.NoSpaceString("s i m p l e");

            //			woCls.RGBtoHex(255,255,255);
            //			woCls.RGBtoHex(255,255,300);
            //			woCls.RGBtoHex(0,0,0);
            //			woCls.RGBtoHex(148,0,211);
            //			woCls.RGBtoHex(148,-20,211);
            //			woCls.RGBtoHex(212,53,12);

            //			woCls.CamelCase("the-stealth-warrior");
            //			woCls.CamelCase("The_Stealth_Warrior");

            //			woCls.IQTest("2 4 7 8 10");
            //			woCls.IQTest("1 2 2");
            //			woCls.IQTest("5 3 2");
            //			woCls.IQTest("100 100 1");

            //			woCls.EvenOdd(10);
            //			woCls.EvenOdd(11);

            //			woCls.Tester("2 4 7 8 10");

            //			woCls.Anagrams("abba", new List<string>{ "aabb", "abcd", "bbaa", "dada" });//aabb bbaa
            //			woCls.Anagrams("racer", new List<string>{ "crazer", "carer", "racar", "caers", "racer" });//carer racer
            //			woCls.Anagrams("laser", new List<string>{ "lazing", "lazy",  "lacer" });// nothing
            //			woCls.Anagrams("a", new List<string>{ "a", "b",  "c", "d","e"});//a
            //			woCls.Anagrams("racer", new List<string>{ "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"});//carer arcre carre

            //			Console.WriteLine(woCls.Maskify("64607935616"));// should return "############5616"
            //			Console.WriteLine(woCls.Maskify("4556364607935616"));// should return "#######5616"
            //			Console.WriteLine(woCls.Maskify("1"));// should return "1"
            //			Console.WriteLine(woCls.Maskify(""));// should return ""
            //			Console.WriteLine(woCls.Maskify("Skippy"));// should return "##ippy"
            //			Console.WriteLine(woCls.Maskify("Nananananananananananananananana Batman!"));// should return "####################################man!"
            //			Console.WriteLine(woCls.Maskify("123456"));

            //			Console.WriteLine(woCls.DigitalRoot(16));//7
            //			Console.WriteLine(woCls.DigitalRoot(942));//15 6
            //			Console.WriteLine(woCls.DigitalRoot(132189));//24 6
            //			Console.WriteLine(woCls.DigitalRoot(493193));//29 11 2

            //			woCls.FindUniqueNum(new []{ 1, 1, 1, 2, 1, 1 });//2
            //			woCls.FindUniqueNum(new []{ 0, 0, 5, 0, 0 });//0.55
            //			woCls.FindUniqueNum(new []{ 1, 2, 2, 2 });//1
            //			woCls.FindUniqueNum(new []{ -2, 2, 2, 2 });//-2
            //			woCls.FindUniqueNum(new []{ 11, 11, 14, 11, 11 });//14

            //woCls.OrderString("is2 Thi1s T4est 3a");
            //			woCls.OrderString("4of Fo1r pe6ople g3ood th5e the2");

            // Console.WriteLine(woCls.SumOddEvn(new int[]{0,1,4}));
            // Console.WriteLine(woCls.SumOddEvn(new int[]{0,-1,-5}));

            // woCls.SplitStrings("abc");
            // woCls.SplitStrings("abcdef");

            // Console.WriteLine(woCls.VowelCount("The input string will only"));

            // Console.WriteLine(woCls.ParOutlier(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
            // Console.WriteLine(woCls.ParOutlier(new int[] { 160, 3, 1719, 19, 11, 13, -21 }));

            // Console.WriteLine(woCls.CreatePhone(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));

            //            Console.WriteLine(woCls.MinMax("1 2 3 4 5"));
            //            Console.WriteLine(woCls.MinMax("1 2 -3 4 5"));
            //            Console.WriteLine(woCls.MinMax("1 2 3 4 -5"));











            stopwatch.Start();//start the watch
                              //execute whateva

            regexClass.Examp();
            stopwatch.Stop();//stop watch

            Console.WriteLine("Time: {0}", Convert.ToInt32(stopwatch.ElapsedMilliseconds));


            //268
            // TODO: Implement Functionality Here


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
