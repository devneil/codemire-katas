using System.Collections.Generic;
using System.Linq;

namespace SumOfMultiples
{
    public class SumMultiples
    {
        public int UpTo(int max)
        {
            var values = new List<int>();
            values.AddRange(new GetMultiplesOf(3).UpTo(max-1));
            values.AddRange(new GetMultiplesOf(5).UpTo(max-1));
            return values.Distinct().Sum();
        }
    }
}