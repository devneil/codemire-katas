using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void OneReturnsOne()
        {
            string result = _fizzBuzz.GetOutputString(1);
            result.Should().Be("1");
        }

        [Test]
        public void TwoReturnsTwo()
        {
            string result = _fizzBuzz.GetOutputString(2);
            result.Should().Be("2");
        }
    }

    public class FizzBuzz
    {
        public string GetOutputString(int input)
        {
            return input.ToString(CultureInfo.InvariantCulture);
        }
    }
}
