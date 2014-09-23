using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Euler7_Prime
{
    class Program
    {
        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10 001st prime number?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int result = new PrimeNumberGenerator().GetNthPrime(10001);

            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();
        }
    }

    [TestFixture]
    public class PrimeNumberGeneratorTest
    {
        [Test]
        public void IncrementalTests()
        {
            TestNthPrime(1, 2);
            TestNthPrime(2, 3);
            TestNthPrime(3, 5);
            TestNthPrime(4, 7);
            TestNthPrime(5, 11);
            TestNthPrime(6, 13);
        }

        private static void TestNthPrime(int nth, int expected)
        {
            int result = new PrimeNumberGenerator().GetNthPrime(nth);
            result.Should().Be(expected);
        }
    }

    public class PrimeNumberGenerator
    {
        public int GetNthPrime(int nth)
        {
            var primes = new List<int>();
            int i = 1;
            while (primes.Count < nth)
            {
                i++;
                if (primes.All(x => i%x != 0))
                {
                    primes.Add(i);
                }
            }
            return primes.Last();
        }
    }
}
