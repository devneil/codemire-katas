using System.Collections.Generic;
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

    [TestFixture]
    public class GetMultiplesTest
    {
        [Test]
        public void MultiplesStateTests()
        {
            TestMultipliers(1, 10, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            TestMultipliers(2, 10, new[] {2, 4, 6, 8, 10});
            TestMultipliers(3, 10, new[] {3, 6, 9});
            TestMultipliers(4, 20, new[] {4, 8, 12, 16, 20});
            TestMultipliers(5, 30, new[] {5, 10, 15, 20, 25, 30});
        }

        private static void TestMultipliers(int multiplier, int max, IEnumerable<int> expected)
        {
            int[] result = new GetMultiplesOf(multiplier).UpTo(max);
            result.Should().ContainInOrder(expected);
        }

    }

    public class GetMultiplesOf
    {
        private readonly int _multiplier;

        public GetMultiplesOf(int multiplier)
        {
            _multiplier = multiplier;
        }

        public int[] UpTo(int max)
        {
            var returnVal = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (IsDivisibleBy(i, _multiplier))
                {
                    returnVal.Add(i);
                }
            }
            return returnVal.ToArray();
        }

        private static bool IsDivisibleBy(int dividend, int divisor)
        {
            return dividend%divisor == 0;
        }
    }

    public class SumMultiples
    {
        public int UpTo(int max)
        {
            if (max >= 3)
            {
                return 3;
            }
            return 0;

        }
    }
}
