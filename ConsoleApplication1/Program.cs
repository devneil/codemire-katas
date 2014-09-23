using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result += i*(i - 1);
            }
            Console.WriteLine("The Result is: {0}",result);
            Console.ReadLine();
        }
    }
}
