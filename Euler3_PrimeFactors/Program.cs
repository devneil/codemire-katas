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
        public void OneReturnsEmpty()
        {
            int[] factors = new Factors().GetPrimeFactorsOf(1);
            factors.Should().BeEmpty();
        }

        [Test]
        public void TwoReturnsTwo()
        {
            int[] factors = new Factors().GetPrimeFactorsOf(2);
            factors.ShouldAllBeEquivalentTo(new[]{2});
        }

        [Test]
        public void ThreeReturnsEmpty()
        {
            int[] factors = new Factors().GetPrimeFactorsOf(3);
            factors.Should().BeEmpty();
            
        }
    }

    public class Factors
    {
        public int[] GetPrimeFactorsOf(int thisNumber)
        {
            if (thisNumber%2 == 0)
            {
                return new[]{2};
            }
            return new int[0];
        }
    }
}
