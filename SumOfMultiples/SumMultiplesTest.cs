using FluentAssertions;
using NUnit.Framework;

namespace SumOfMultiples
{
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
}