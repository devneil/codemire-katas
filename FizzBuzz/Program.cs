using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbc1 = new FizzBuzzConfig(3, "Fizz");
            var fbc2 = new FizzBuzzConfig(5, "Buzz");
            var fb = new FizzBuzz(new[] {fbc1, fbc2});
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fb.GetOutputString(i));
            }
            Console.ReadLine();
        }
    }

    [TestFixture]
    public class ArgConvertorTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void SingleArgsCountShouldThrow()
        {
            new ArgConvertor(new[] {"1"});
        }
        
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void OddArgsCountShouldThrow(){
            
            new ArgConvertor(new[] { "1", "2", "3" });
        }

        [Test]
        public void TwoArgsShouldBeValid()
        {
            new ArgConvertor(new[] {"1", "2"});
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void SingleArgsNonIntShoudThrow()
        {
            new ArgConvertor(new[] {"one", "2"});
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void OddArgsNonIntShoudThrow()
        {
            new ArgConvertor(new[] {"1", "2", "three", "4"});
        }

        [Test]
        public void CanCreateConfig()
        {
            FizzBuzzConfig[] configs = new ArgConvertor(new[] {"1", "two"}).GetConfigs();
            AssertConfig(configs[0], 1, "two");
        }
        
        [Test]
        public void CanCreateTwoConfigs()
        {
            FizzBuzzConfig[] configs = new ArgConvertor(new[] {"1", "two", "3", "four"}).GetConfigs();
            AssertConfig(configs[0], 1, "two");
            AssertConfig(configs[1], 3, "four");
        }

        private static void AssertConfig(FizzBuzzConfig fizzBuzzConfig, int expectedDiv, string expectedString)
        {
            fizzBuzzConfig.Divisor.Should().Be(expectedDiv);
            fizzBuzzConfig.PrintString.Should().Be(expectedString);
        }
    }

    public class ArgConvertor
    {
        private readonly string[] _args;

        public ArgConvertor(string[] args)
        {
            Validate(args);
            _args = args;
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
