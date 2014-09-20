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
        [Test]
        public void OneReturnsOne()
        {
            string result = new FizzBuzz().GetOutputString(1);

            result.Should().Be("1");
        }

        [Test]
        public void TwoReturnsTwo()
        {
            string result = new FizzBuzz().GetOutputString(2);
            result.Should().Be("2");
        }
    }

    public class FizzBuzz
    {
        public string GetOutputString(int input)
        {
            return input.ToString();
        }
    }
}
