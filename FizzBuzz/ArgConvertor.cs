using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class ArgConvertor
    {
        private readonly string[] _args;

        public ArgConvertor(string[] args)
        {
            _args = (args != null) && (args.Length > 0) ? args : GetDefaultArgs();
            Validate(_args);
        }

        private static string[] GetDefaultArgs()
        {
            return new[] {"3", "Fizz", "5", "Buzz"};
        }

        private static void Validate(string[] args)
        {
            ValidateEvenArgumentsCount(args);
            ValidateOddArgumentsAreInts(args);

        }

        private static void ValidateOddArgumentsAreInts(IList<string> args)
        {
            for (int i = 0; i < args.Count; i = i + 2)
            {
                int dummy;
                if (!int.TryParse(args[i], out dummy))
                {
                    throw new ArgumentException("Odd arguments must be integers to be used as divisors.");
                }
            }
        }

        private static void ValidateEvenArgumentsCount(string[] args)
        {
            if (args.Length%2 != 0)
            {
                throw new ArgumentException(
                    "Argument count is uneven.  Arguments should be in divisor string pairs.");
            }

        }

        public FizzBuzzConfig[] GetConfigs()
        {
            var configs = new List<FizzBuzzConfig>();

            for (int i = 0; i < _args.Length; i = i + 2)
            {
                configs.Add( new FizzBuzzConfig(int.Parse(_args[i]), _args[i+1]));
            }

            return configs.ToArray();
        }
    }
}