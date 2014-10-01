using FluentAssertions;
using NUnit.Framework;

namespace Euler7_Prime
{
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
}