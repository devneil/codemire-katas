using System.Collections.Generic;
using System.Linq;

namespace Euler7_Prime
{
    public class PrimeNumberGenerator
    {
        public long GetNthPrime(int nth)
        {
            var primes = new List<long>();
            var i = 1;
            while (primes.Count < nth)
            {
                AddIfPrime(primes, ++i);
            }
            return primes.Last();
        }

        public long SumToPrimeLessThan(int n)
        {
            var primes = new List<long>();
            var i = 2;
            while (i < n)
            {
                AddIfPrime(primes, i);
                i++;
            }
            return primes.Sum();
        }

        private static void AddIfPrime(ICollection<long> primes, int i)
        {
            if (primes.All(x => i % x != 0))
            {
                primes.Add(i);
            }
        }
    }
}