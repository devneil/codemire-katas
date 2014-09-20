using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            var fbc1 = new FizzBuzzConfig(3, "Fizz");
            var fbc2 = new FizzBuzzConfig(5, "Buzz");
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
}