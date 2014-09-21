using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace SumOfMultiples
{
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
}