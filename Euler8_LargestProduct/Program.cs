using System;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Euler8_LargestProduct
{
    /// <summary>
    /// The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
    /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. 
    /// What is the value of this product?
    /// </summary>
    class Program
    {
        const string TestNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        static void Main(string[] args)
        {
            var result = new Products(TestNumber).ScanLargestProduct(13);
            
            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();
        }
    }

    [TestFixture]
    public class ProductTester
    {
        [Test]
        public void ProductsTesting()
        {
            TestProducts("1", 1, 1);
            TestProducts("2", 1, 2);
            TestProducts("11", 1, 1);
            TestProducts("12", 1, 2);
            TestProducts("12", 2, 2);
            TestProducts("22", 2, 4);
            TestProducts("222", 2, 4);
            TestProducts("01234567890", 3, 7*8*9);
        }

        private static void TestProducts(string stringOfInts, int consecutiveNums, int expected)
        {
            long result = new Products(stringOfInts).ScanLargestProduct(consecutiveNums);
            result.Should().Be(expected);
        }

    }

    public class Products
    {
        private readonly string _stringOfInts;

        public Products(string stringOfInts)
        {
            _stringOfInts = stringOfInts;
        }

        public long ScanLargestProduct(int consecutiveNums)
        {
            long returnVal = 1L;
            for (int i = 0; i < _stringOfInts.Length - consecutiveNums + 1; i++)
            {
                long currentVal = 1L;
                string breakString = _stringOfInts.Substring(i, consecutiveNums);
                if (!breakString.Contains("0"))
                {
                    foreach (char c in breakString)
                    {
                        currentVal *= Convert.ToInt64(c.ToString(CultureInfo.InvariantCulture));
                    }
                    if (currentVal > returnVal)
                    {
                        returnVal = currentVal;
                    }
                }
            }
            return returnVal;
        }
    }
}
