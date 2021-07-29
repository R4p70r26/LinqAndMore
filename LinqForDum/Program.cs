using System;

namespace LinqForDum
{
    class Program
    {
        static void Main(string[] args)
        {
			Chapter2 chap2 = new Chapter2();
			//			chap2.Listing21();
			//			chap2.Listing22();
			//			chap2.Listing23();
			//			chap2.Listing24();
			//			chap2.Listing25();
			//			chap2.Listing26();	

			Chapter3 chap3 = new Chapter3();
			//			chap3.Listing31();


			Chapter5 chap5 = new Chapter5();
			//chap5.Listing51();
			//chap5.Listing52();
			//chap5.Listing53();
			//chap5.Listing54();
			//chap5.Listing55();

			Chapter6 chap6 = new Chapter6();
			//			chap6.Listing63();
			//			chap6.Listing64();
			//			chap6.Listing65();
			//			chap6.Listing67();
			//			chap6.Listing68();
			//			chap6.Listing69();
			//			chap6.Listing610();
			//			chap6.Listing611();
			//			chap6.Listing612();
			//			chap6.Listing613();
			//			chap6.Listing614();
			//			chap6.Listing615();




			RdnPracCh2 rndprac = new RdnPracCh2();
			//			rndprac.LinqOrder();
			//rndprac.numsRange();
			//rndprac.MinLentoUp();
			//rndprac.SelectWordSE();
			//rndprac.TopfiveNums();
			//			rndprac.SquareGreat();
			//rndprac.ReplaceSub();
			//rndprac.RetLetE();
			//			int[] intA = {19, 5, 42, 2, 77};
			//			Console.WriteLine(rndprac.SumLowst(intA));
			//			intA = new int[]{10, 343445353, 3453445, 345353453};
			//			Console.WriteLine(rndprac.SumLowst(intA));
			//			int[] arr = rndprac.MinMax(new int[]{ 1, 2, 3, 4, 5 });
			//			foreach (var element in arr) 
			//				Console.WriteLine(element);
			//			arr = rndprac.MinMax(new int[]{ 2334454, 5 });
			//			foreach (var element in arr) 
			//				Console.WriteLine(element);
			//			arr = rndprac.MinMax(new int[]{ 1 });
			//			foreach (var element in arr) 
			//				Console.WriteLine(element);
			//			rndprac.SqrDigit(9119);
			//			rndprac.SortOdd(new int[]{ 7, 1 });
			//			rndprac.SortOdd(new int[]{ 5, 8, 6, 3, 4 });
			//			rndprac.SortOdd(new int[]{ 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
			//			rndprac.FindOddInt(new int[]{20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5});//5
			//			rndprac.FindOddInt(new int[]{1,1,2,-2,5,2,4,4,-1,-2,5});//-4
			//			rndprac.FindOddInt(new int[]{20,1,1,2,2,3,3,5,5,4,20,4,5});//5
			//			rndprac.FindOddInt(new int[]{1,1,1,1,1,1,10,1,1,1,1});//10
			//			rndprac.FindOddInt(new int[]{5,4,3,2,1,5,4,3,2,10,10});//1
			//			rndprac.Tickets(new int[]{ 25, 25, 50, 100 }); //yes
			//			rndprac.Tickets(new int[]{ 25, 25, 25, 25, 50, 100, 50 }); //yes
			//			rndprac.Tickets(new int[]{ 25, 25, 50 });//yes
			//			rndprac.Tickets(new int[]{ 25, 25, 50, 50, 100 });//no
			//			Console.WriteLine(rndprac.SquareArr(new int[]{1,2,2}));//9
			//			rndprac.SquareArr(new int[]{1,2});//5
			//			rndprac.SquareArr(new int[]{5,3,4});//50
			rndprac.SumNums(-1, 2);
			rndprac.SumNums(-1, 0);
			rndprac.SumNums(1, 1);



			// TODO: Implement Functionality Here

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
    }
}
