using System;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz
{
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

        [Test]
        public void NullArgsCreatesDefaultConfigs()
        {
            FizzBuzzConfig[] configs = new ArgConvertor(null).GetConfigs();
            AssertConfig(configs[0], 3, "Fizz");
            AssertConfig(configs[1], 5, "Buzz");
        }

        [Test]
        public void EmptyArgsArrayCreatesDefaultConfigs()
        {
            FizzBuzzConfig[] configs = new ArgConvertor(new string[0]).GetConfigs();
            AssertConfig(configs[0], 3, "Fizz");
            AssertConfig(configs[1], 5, "Buzz");           
        }

        private static void AssertConfig(FizzBuzzConfig fizzBuzzConfig, int expectedDiv, string expectedString)
        {
            fizzBuzzConfig.Divisor.Should().Be(expectedDiv);
            fizzBuzzConfig.PrintString.Should().Be(expectedString);
        }
    }
}