using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodeWars;
using System.Diagnostics;

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
    }
}
