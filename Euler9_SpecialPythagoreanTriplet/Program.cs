using System;
using System.Collections.Generic;
using System.Globalization;
using FluentAssertions;
using NUnit.Framework;

namespace Euler9_SpecialPythagoreanTriplet
{
    class Program
    {
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        /// a2 + b2 = c2
        /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        /// 
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = GetAbc();
            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();
        }

        private static int GetAbc()
        {
            var numbersWithNaturalSquares = new List<int>();
            var sq = new SquareRooter();

            for (int i = 1; i < 1000; i++)
            {
                numbersWithNaturalSquares.Add(i*i);
            }

            for (int i = 0; i < numbersWithNaturalSquares.Count; i++)
            {
                for (int j = 0; j < numbersWithNaturalSquares.Count; j++)
                {
                    var a2 = numbersWithNaturalSquares[i];
                    var b2 = numbersWithNaturalSquares[j];
                    int c2 = a2 + b2;
                    if (numbersWithNaturalSquares.Contains(c2))
                    {
                        var a = sq.GetSquareRoot(a2);
                        var b = sq.GetSquareRoot(b2);
                        var c = sq.GetSquareRoot(c2);
                        if (a + b + c == 1000)
                        {
                            return a*b*c;
                        }
                    }
                }
            }
            return 0;
        }
    }
    
    [TestFixture]
    public class TestSquareRoots
    {
        [Test]
        public void SquareTests()
        {
            TestIsNaturalSquare(4);
            TestIsNotNaturalSquare(5);
            TestIsNaturalSquare(16);
            TestIsNaturalSquare(25);
            TestIsNaturalSquare(36);
            TestIsNotNaturalSquare(39);
        }
        
        private static void TestIsNotNaturalSquare(int num)
        {
            GetIsNatural(num).Should().BeFalse();
        }

        private static void TestIsNaturalSquare(int num)
        {
            GetIsNatural(num).Should().BeTrue();
        }


        private static bool GetIsNatural(int num)
        {
            return new SquareRooter().IsNatural(num);
        }
    }

    internal class SquareRooter
    {
        public bool IsNatural(int num)
        {
            int dummy;
            return int.TryParse(Math.Sqrt(num).ToString(CultureInfo.InvariantCulture), out dummy);
        }

        public int GetSquareRoot(int num)
        {
            int result;
            if (int.TryParse(Math.Sqrt(num).ToString(CultureInfo.InvariantCulture), out result))
            {
                return result;
            }
            return 0;
        }
    }
}
