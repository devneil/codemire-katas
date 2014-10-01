using FluentAssertions;
using NUnit.Framework;

namespace Euler7_Prime
{
    [TestFixture]
    public class PrimeNumberGeneratorTest
    {
        private static PrimeNumberGenerator _gen;
        [SetUp]
        public void Setup()
        {
            _gen = new PrimeNumberGenerator();
        }

        [Test]
        public void SumTest()
        {
            TestSumToLessThan(1, 0);
            TestSumToLessThan(3, 2);
            TestSumToLessThan(4, 5); // 3 only
            TestSumToLessThan(6, 10); // 5 + 3
            TestSumToLessThan(8, 17); // 7 + 5 + 3
            TestSumToLessThan(12, 28); // 11 + 7 + 5 + 3

        }

        [Test]
        public void IncrementalNthTests()
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
            var result = _gen.GetNthPrime(nth);
            result.Should().Be(expected);
        }

        private static void TestSumToLessThan(int i, int expected)
        {
            var result = _gen.SumToPrimeLessThan(i);
            result.Should().Be(expected);
        }
    }
}