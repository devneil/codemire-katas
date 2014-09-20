using System;
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
        public void SingleArgsShouldThrow()
        {
            new ArgConvertor("1");

        }
    }

    public class ArgConvertor
    {
        public ArgConvertor(string arg)
        {
            throw new ArgumentException();
        }
    }
}
