using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Euler2_EvenFibonacci
{
    [TestFixture]
    public class EvenFilterTest
    {
        [Test]
        public void NoEvensReturnsEmpty()
        {
            TestNoEvens(new[] {1});
            TestNoEvens(new[] {1, 3, 5, 7, 5, 9, 345});
        }

        private static void TestNoEvens(int[] ints)
        {
            int[] sequence = new EvenFilter().GetValues(ints);
            sequence.Should().BeEmpty();
        }

        [Test]
        public void WithEvensReturnsEvens()
        {
            TestWithEvens(new []{2}, new[]{2});
            TestWithEvens(new[] { 2, 4, 6, 8, 2 }, new[] { 2, 4, 6, 8, 2 });
            TestWithEvens(new[] { 2, 5, 7, 5, 7, 4, 6, 8, 5, 3, 1, 2 }, new[] { 2, 4, 6, 8, 2 });
        }

        private static void TestWithEvens(int[] ints, IEnumerable<int> expectation)
        {
            int[] sequence = new EvenFilter().GetValues(ints);
            sequence.ShouldAllBeEquivalentTo(expectation);
        }
    }
}