using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SumOfMultiples
{
    class Program
    {
        /// <summary>
        /// Project Euler problem: Multiples of 3 and 5
        /// 
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        /// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int numbersLessThan = 1000;

            int sum = new SumMultiples().UpTo(numbersLessThan);

            Console.WriteLine("The result is: {0}", sum);

            Console.ReadLine();
        }
    }
}
