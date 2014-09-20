using System.Globalization;
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
            _fizzBuzz = new FizzBuzz();
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
        }

        private void Test(int input, string expected)
        {
            var result = _fizzBuzz.GetOutputString(input);
            result.Should().Be(expected);
        }

    }

    public class FizzBuzz
    {
        public string GetOutputString(int input)
        {
            string result = string.Empty;
            if (input%3 == 0)
            {
                result += "Fizz";
            }
            if (input%5 == 0)
            {
                result += "Buzz";
            }
            if (result.Length == 0)
            {
                result = input.ToString(CultureInfo.InvariantCulture);
            }
            return result;
        }
    }
}
