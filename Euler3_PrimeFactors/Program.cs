using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Euler3_PrimeFactors
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [TestFixture]
    public class FactorsTest
    {
        [Test]
        public void StateTests()
        {
            TestEmpty(1);
            Test(2, new[] { 2 });
            Test(3, new[] { 3 });
            Test(4, new[] { 2, 2 });
            Test(5, new[] { 5 });
        }

        private static void TestEmpty(int thisNumber)
        {
            int[] factors = new Factors().GetPrimeFactorsOf(thisNumber);
            factors.Should().BeEmpty();
        }

        private static void Test(int thisNumber, IEnumerable<int> expectation)
        {
            var factors = new Factors().GetPrimeFactorsOf(thisNumber);
            factors.ShouldAllBeEquivalentTo(expectation);
        }

    }

    public class Factors
    {
        public int[] GetPrimeFactorsOf(int thisNumber)
        {
            var returnVal = new List<int>();
            while (thisNumber % 2 == 0)
            {
                thisNumber = thisNumber / 2;
                returnVal.Add(2);
            }
            if (thisNumber > 1)
            {
                returnVal.Add(thisNumber);
            }
            return returnVal.ToArray();
        }
    }
}
