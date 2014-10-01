using System.Collections.Generic;
using System.Linq;

namespace Euler7_Prime
{
    public class PrimeNumberGenerator
    {
        public int GetNthPrime(int nth)
        {
            var primes = new List<int>();
            var i = 1;
            while (primes.Count < nth)
            {
                AddIfPrime(primes, ++i);
            }
            return primes.Last();
        }

        private static void AddIfPrime(ICollection<int> primes, int i)
        {
            if (primes.All(x => i%x != 0))
            {
                primes.Add(i);
            }
        }

        public int SumToPrimeLessThan(int n)
        {
            var primes = new List<int>();
            var i = 3;
            while (i < n)
            {
                AddIfPrime(primes, i);
                i += 2; // only odds can be prime
            }
            return primes.Sum();
        }
    }
}