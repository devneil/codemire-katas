using System;

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
}
