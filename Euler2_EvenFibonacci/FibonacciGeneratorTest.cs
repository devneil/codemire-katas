using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Euler2_EvenFibonacci
{
    [TestFixture]
    public class FibonacciGeneratorTest
    {
        [Test]
        public void StateTests()
        {
            TestSequence(2, new[] { 1 });
            TestSequence(3, new[] { 1, 2});
            TestSequence(4, new[] { 1, 2, 3 });
            TestSequence(5, new[] { 1, 2, 3 });
            TestSequence(6, new[] { 1, 2, 3, 5 });
            TestSequence(7, new[] { 1, 2, 3, 5 });
            TestSequence(8, new[] { 1, 2, 3, 5 });
            TestSequence(9, new[] { 1, 2, 3, 5, 8 });
        }

        private static void TestSequence(int upperBound, IEnumerable<int> expected)
        {
            int[] sequence = new FibonacciGenerator().GenerateToLessThan(upperBound);
            sequence.ShouldAllBeEquivalentTo(expected);
        }

    }
}