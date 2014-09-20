using System.Globalization;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [TestFixture]
    public class FizzBuzzTest
    {
        FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            FizzBuzzConfig fbc1 = new FizzBuzzConfig(3, "Fizz");
            FizzBuzzConfig fbc2 = new FizzBuzzConfig(5, "Buzz");
            _fizzBuzz = new FizzBuzz(new [] { fbc1, fbc2 });
        }
        [Test]
        public void StateTesting()
        {
            Test(1, "1");
            Test(2, "2");
            Test(3, "Fizz");
            Test(4, "4");
            Test(5, "Buzz");
            Test(6, "Fizz");
            Test(7, "7");
            Test(8, "8");
            Test(9, "Fizz");
            Test(10, "Buzz");
            Test(11, "11");
            Test(12, "Fizz");
            Test(13, "13");
            Test(14, "14");
            Test(15, "FizzBuzz");
            Test(30, "FizzBuzz");
        }

        private void Test(int input, string expected)
        {
            var result = _fizzBuzz.GetOutputString(input);
            result.Should().Be(expected);
        }

    }

    public class FizzBuzzConfig
    {
        public FizzBuzzConfig(int divisor, string printString)
        {
            Divisor = divisor;
            PrintString = printString;
        }

        public int Divisor { get; private set; }
        public string PrintString { get; private set; }
    }

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
