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
            if (input%3 == 0)
            {
                return "Fizz";
            }
            if (input%5 == 0)
            {
                return "Buzz";
            }
            return input.ToString(CultureInfo.InvariantCulture);
        }
    }
}
