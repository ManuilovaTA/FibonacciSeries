using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciSeries;

namespace FibonacciSeriesTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void test_FibonacciElement_succesfull()
        {
            long expectedResult = 233;
            int i = 13;

            long actualResult = Fibonacci.FibonacciElement(i);
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void test_FibonacciRange_succesfull()
        {
            long[] expectedResult = new long[] { 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229};

            long[] actualResult = Fibonacci.FibonacciRange(13, 29);
            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }           
        }

        [TestMethod]
        public void test_FibonacciElementsLength_succesfull()
        {
            string expectedResult = "13 21 34 55 89 ";
            
            Assert.AreEqual(expectedResult, Fibonacci.FibonacciElementsLength(10, 100));

        }




    }
}
