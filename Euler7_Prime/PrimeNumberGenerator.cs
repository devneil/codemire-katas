using System.Collections.Generic;
using System.Linq;

namespace Euler7_Prime
{
    public class PrimeNumberGenerator
    {
        public int GetNthPrime(int nth)
        {
            var primes = new List<int>();
            int i = 1;
            while (primes.Count < nth)
            {
                i++;
                if (primes.All(x => i%x != 0))
                {
                    primes.Add(i);
                }
            }
            return primes.Last();
        }

        public int SumToPrimeLessThan(int n)
        {
            return n-1;
        }
    }
}