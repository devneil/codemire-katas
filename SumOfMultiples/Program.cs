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
            TestSumMultiples(3, 3);
            TestSumMultiples(4, 3);
            
        }

        private static void TestSumMultiples(int max, int expected)
        {
            int result = new SumMultiples().UpTo(max);
            result.Should().Be(expected);
        }
    }

    public class SumMultiples
    {
        public int UpTo(int max)
        {
            return new GetMultiplesOf(3).UpTo(max).Sum();
        }
    }
}
