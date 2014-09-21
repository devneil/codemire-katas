using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using FluentAssertions;
using NUnit.Framework;

namespace SumOfMultiples
{
    class Program
    {
        /// <summary>
        /// Project Euler problem: Multiples of 3 and 5
        /// 
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        /// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int numbersLessThan = 1000;

            int sum = new SumMultiples().UpTo(numbersLessThan);

            Console.WriteLine("The result is: {0}", sum);

            Console.ReadLine();
        }
    }

    [TestFixture]
    public class SumMultiplesTest
    {
        [Test]
        public void StateTests()
        {
            TestSumMultiples(1, 0);
            TestSumMultiples(2, 0);
            TestSumMultiples(3, 0);
            TestSumMultiples(4, 3);
            TestSumMultiples(5, 3);
            TestSumMultiples(6, 8);
            TestSumMultiples(7, 14);
            TestSumMultiples(8, 14);
            TestSumMultiples(9, 14);
            TestSumMultiples(10, 23);
            TestSumMultiples(15, 45);
            TestSumMultiples(16, 60);
        }

        private static void TestSumMultiples(int lessThan, int expected)
        {
            int result = new SumMultiples().UpTo(lessThan);
            result.Should().Be(expected);
        }
    }

    public class SumMultiples
    {
        public int UpTo(int max)
        {
            var values = new List<int>();
            values.AddRange(new GetMultiplesOf(3).UpTo(max-1));
            values.AddRange(new GetMultiplesOf(5).UpTo(max-1));
            return values.Distinct().Sum();
        }
    }
}
