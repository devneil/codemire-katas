using System.Collections.Generic;

namespace SumOfMultiples
{
    public class GetMultiplesOf
    {
        private readonly int _multiplier;

        public GetMultiplesOf(int multiplier)
        {
            _multiplier = multiplier;
        }

        public int[] UpTo(int max)
        {
            var returnVal = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (IsDivisibleBy(i, _multiplier))
                {
                    returnVal.Add(i);
                }
            }
            return returnVal.ToArray();
        }

        private static bool IsDivisibleBy(int dividend, int divisor)
        {
            return dividend%divisor == 0;
        }
    }
}