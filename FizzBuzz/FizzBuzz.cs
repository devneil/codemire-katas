using System.Globalization;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private readonly FizzBuzzConfig[] _fizzBuzzConfigs;

        public FizzBuzz(FizzBuzzConfig[] fizzBuzzConfigs)
        {
            _fizzBuzzConfigs = fizzBuzzConfigs;
        }

        public string GetOutputString(int input)
        {
            var result = new StringBuilder();
            foreach (var fbc in _fizzBuzzConfigs)
            {
                if (input%fbc.Divisor == 0)
                {
                    result.Append(fbc.PrintString);
                }
            }
            if (result.Length == 0)
            {
                result.Append(input.ToString(CultureInfo.InvariantCulture));
            }
            return result.ToString();
        }
    }
}