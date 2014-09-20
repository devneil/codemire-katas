using System;
using System.Collections.Generic;
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
    }

    public class FizzBuzz
    {
        public string GetOutputString(int input)
        {
            return "1";
        }
    }
}
