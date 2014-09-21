using System.Collections.Generic;
using System.Linq;

namespace Euler2_EvenFibonacci
{
    public class FibonacciGenerator
    {
        public int[] GenerateToLessThan(int upperBound)
        {
            var sequence = new List<int>{1, 2};
            while (upperBound > sequence.Last())
            {
                sequence.Add(sequence.Reverse<int>().Take(2).Sum());
            }
            return sequence.Where(x => x < upperBound).ToArray();
        }
    }
}