using System.Linq;

namespace Euler2_EvenFibonacci
{
    public class EvenFilter
    {
        public int[] GetValues(int[] ints)
        {
            return ints.ToList().Where(x => x%2 == 0).ToArray();
        }
    }
}