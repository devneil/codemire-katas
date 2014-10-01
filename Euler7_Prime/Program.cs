using System;

namespace Euler7_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Euler7();

            Euler10();
        }

        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// </summary>
        private static void Euler10()
        {
            const int twoMillion = 2000000;
            var result = new PrimeNumberGenerator().SumToPrimeLessThan(twoMillion);

            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();
        }


        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10 001st prime number?
        /// </summary>
        static void Euler7()
        {
            var result = new PrimeNumberGenerator().GetNthPrime(10001);

            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();
        }
    }
}
