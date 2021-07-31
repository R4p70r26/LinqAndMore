using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodeWars;
using System.Diagnostics;
using System.Collections.Generic;

namespace TestCodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumLowestTest()
        {
            Assert.AreEqual(7, WorkClass.SumLowst(new int[] { 19, 5, 42, 2, 77 }));
            Assert.AreEqual(3453455, WorkClass.SumLowst(new int[] { 10, 343445353, 3453445, 345353453 }));


            for (int i = 0; i < 10; i++)
            {
                int[] testArr = RndmIntArray();
                Assert.AreEqual(WorkClass.SumLowst(testArr), WorkClass.SumLowst(testArr));
            }

        }

        [TestMethod]
        public void MinMaxTest()
        {
            CollectionAssert.AreEqual(new int[] { 1, 5 }, WorkClass.MinMax(new int[] { 1, 2, 3, 4, 5 }));

            for (int i = 0; i < 10; i++)
            {
                var arr = RndmIntArray();
                CollectionAssert.AreEqual(WorkClass.MinMax(arr), WorkClass.MinMax(arr));
            }
        }

        [TestMethod]
        public void SquareDigitTest()
        {
            Assert.AreEqual(14916, WorkClass.SqrDigit(1234));
            Assert.AreEqual(811181, WorkClass.SqrDigit(9119));
            Assert.AreEqual(49, WorkClass.SqrDigit(23));
            Assert.AreEqual(1642564, WorkClass.SqrDigit(4258));
        }

        [TestMethod]
        public void SortOddTest()
        {
            CollectionAssert.AreEqual(new int[] { 1, 7 }, WorkClass.SortOdd(new int[] { 7, 1 }));
            CollectionAssert.AreEqual(new int[] { 3, 8, 6, 5, 4 }, WorkClass.SortOdd(new int[] { 5, 8, 6, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 1, 8, 3, 6, 5, 4, 7, 2, 9, 0 }, WorkClass.SortOdd(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
        }

        [TestMethod]
        public void FindOddIntTest()
        {
            Assert.AreEqual(5, WorkClass.FindOddInt(new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Assert.AreEqual(-1, WorkClass.FindOddInt(new int[] { 1, 1, 2, -2, 5, 2, 4, 4, -1, -2, 5 }));
            Assert.AreEqual(5, WorkClass.FindOddInt(new int[] { 20, 1, 1, 2, 2, 3, 3, 5, 5, 4, 20, 4, 5 }));
            Assert.AreEqual(10, WorkClass.FindOddInt(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 }));
            Assert.AreEqual(1, WorkClass.FindOddInt(new int[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 10, 10 }));
        }

        [TestMethod]
        public void TicketTest()
        {
            Assert.AreEqual("YES", WorkClass.Tickets(new int[] { 25, 25, 50, 100 }));
            Assert.AreEqual("YES", WorkClass.Tickets(new int[] { 25, 25, 25, 25, 50, 100, 50 }));
            Assert.AreEqual("YES", WorkClass.Tickets(new int[] { 25, 25, 50 }));
            Assert.AreEqual("NO", WorkClass.Tickets(new int[] { 25, 25, 50, 50, 100 }));
        }

        [TestMethod]
        public void SqrArraySumTest()
        {
            Assert.AreEqual(9, WorkClass.SquareArr(new int[] { 1, 2, 2 }));
            Assert.AreEqual(5, WorkClass.SquareArr(new int[] { 1, 2 }));
            Assert.AreEqual(50, WorkClass.SquareArr(new int[] { 5, 3, 4 }));
        }

        [TestMethod]
        public void AnagramTest()
        {
            CollectionAssert.AreEqual(new List<string> { "aabb", "bbaa" }, WorkClass.Anagrams("abba", new List<string> { "aabb", "abcd", "bbaa", "dada" }));
            CollectionAssert.AreEqual(new List<string> { "carer", "racer" }, WorkClass.Anagrams("racer", new List<string> { "crazer", "carer", "racar", "caers", "racer" }));
            CollectionAssert.AreEqual(new List<string> { }, WorkClass.Anagrams("laser", new List<string> { "lazing", "lazy", "lacer" }));
            CollectionAssert.AreEqual(new List<string> { "a" }, WorkClass.Anagrams("a", new List<string> { "a", "b", "c", "d", "e" }));
            CollectionAssert.AreEqual(new List<string> { "carer", "arcre", "carre" }, WorkClass.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }

        [TestMethod]
        public void MaskifyTest()
        {
            Assert.AreEqual("#######5616", WorkClass.Maskify("64607935616"));
            Assert.AreEqual("############5616", WorkClass.Maskify("4556364607935616"));
            Assert.AreEqual("1", WorkClass.Maskify("1"));
            Assert.AreEqual("", WorkClass.Maskify(""));
            Assert.AreEqual("##ippy", WorkClass.Maskify("Skippy"));
            Assert.AreEqual("####################################man!", WorkClass.Maskify("Nananananananananananananananana Batman!"));
            Assert.AreEqual("##3456", WorkClass.Maskify("123456"));
        }

        [TestMethod]
        public void DigitalRootTest()
        {
            //			Console.WriteLine(woCls.DigitalRoot(16));//7
            //			Console.WriteLine(woCls.DigitalRoot(942));//15 6
            //			Console.WriteLine(woCls.DigitalRoot(132189));//24 6
            //			Console.WriteLine(woCls.DigitalRoot(493193));//29 11 2

            Assert.AreEqual(7, WorkClass.DigitalRoot(16));
            Assert.AreEqual(6, WorkClass.DigitalRoot(942));
            Assert.AreEqual(6, WorkClass.DigitalRoot(132189));
            Assert.AreEqual(2, WorkClass.DigitalRoot(493193));
        }

        private int[] RndmIntArray()
        {
            Random random = new Random();

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(9999999);
            }
            return arr;

        }

        private void DivisorTest()
        {//https://www.codewars.com/kata/544aed4c4a30184e960010f4/solutions/csharp
            Random rnd = new Random();
            for (int i = 0; i < 100; ++i)
            {
                int test = rnd.Next(2, 101);
                int[] expected = WorkClass.Divisors(test);
                int[] actual = WorkClass.Divisors(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
