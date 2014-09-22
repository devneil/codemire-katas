using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Euler5_SmallestMultiple
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            var fac = new Factors();
            // increment by 7 as that is the lowest prime numbered factor
            for (int i = 2520; i <= int.MaxValue; i = i + 7)
            {
                // minimal factors removed from array
                if (fac.AreAllFactors(i, new[] { 7, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}))
                {
                    result = i;
                    break;
                }
            }

            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();
        }
    }

    [TestFixture]
    public class FactorsTest
    {
        [Test]
        public void StateTests()
        {
            TestAreAllFactors(10, new[] {2, 5}).Should().BeTrue();
            TestAreAllFactors(10, new[] {2, 5, 7}).Should().BeFalse();
            TestAreAllFactors(20, new[] {2, 5, 10, 4}).Should().BeTrue();
            TestAreAllFactors(2520, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).Should().BeTrue();
            
        }

        private static bool TestAreAllFactors(int of, int[] ints)
        {
            return new Factors().AreAllFactors(of, ints);
        }
    }

    public class Factors
    {
        public bool AreAllFactors(int num, int[] ints)
        {
            for (int i = ints.Length; i > 0; i--)
            {
                if (num%ints[i-1] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
