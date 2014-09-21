using System;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Primitives;
using NUnit.Framework;

namespace Euler4_LargestPalindromeProduct
{
    class Program
    {
        /// <summary>
        /// A palindromic number reads the same both ways. 
        /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var maxPalindrome = 0;
            var h = new Helper();
            for (var i = 999; i > 99; i--)
            {
                for (var j = 999; j > 99; j--)
                {
                    int product = i*j;
                    if (h.IsPalindrome(product))
                    {
                        if (product > maxPalindrome)
                        {
                            maxPalindrome = product;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("The Result is: {0}", maxPalindrome);
            Console.ReadLine();
        }

    }

    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void StateTests()
        {
            TrueTest(3);
            FalseTest(34);
            TrueTest(33);
            TrueTest(123454321);
            FalseTest(12345432);
        }

        private static void TrueTest(int i)
        {
            new Helper().IsPalindrome(i).Should().BeTrue();
        }

        private static void FalseTest(int i)
        {
            new Helper().IsPalindrome(i).Should().BeFalse();
        }
    }

    public class Helper
    {
        public bool IsPalindrome(int i)
        {
            char[] asChars = i.ToString(CultureInfo.InvariantCulture).ToCharArray();
            return asChars.SequenceEqual(asChars.Reverse());
        }
    }
}
