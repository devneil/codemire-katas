using System;
using System.Collections.Generic;
using System.Linq;
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
            int[] factors = new Factors().GetPrimeFactorsOf(600851475143);
            int max = factors.Max();


            Console.WriteLine("The result is: {0}", max);
            Console.ReadLine();
        }
    }

    [TestFixture]
    public class FactorsTest
    {
        [Test]
        public void PrimeFactorStateTests()
        {
            TestEmpty(1);
            Test(2, new[] { 2 });
            Test(3, new[] { 3 });
            Test(4, new[] { 2, 2 });
            Test(5, new[] { 5 });
            Test(6, new[] { 2, 3});
            Test(7, new[] { 7 });
            Test(8, new[] { 2, 2, 2 });
            Test(9, new[] { 3, 3 });
            Test(10, new[] { 5, 2 });
            Test(11, new[] { 11 });
            Test(12, new[] { 2, 2, 3 });
            Test(13195, new[] { 5, 7, 13, 29 });

        }

        [Test]
        public void MaxPrimeFactorStateTests()
        {
            TestMax(2, 2);
            TestMax(3, 3);
            TestMax(4, 2);
            TestMax(13195, 29);
        }

        private static void TestMax(int thisNumber, int expected)
        {
            int[] factors = new Factors().GetPrimeFactorsOf(thisNumber);
            int max = factors.Max();

            max.Should().Be(expected);
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
        public int[] GetPrimeFactorsOf(long thisNumber)
        {
            var returnVal = new List<int>();

            for (int i = 2; i < thisNumber; i++)
            {
                while (thisNumber%i == 0)
                {
                    thisNumber = thisNumber/i;
                    returnVal.Add(i);
                }
            }
            if (thisNumber > 1)
            {
                // cast to int ok because we know our primes won't be that large
                returnVal.Add((int)thisNumber);
            }
            return returnVal.ToArray();
        }
    }
}
