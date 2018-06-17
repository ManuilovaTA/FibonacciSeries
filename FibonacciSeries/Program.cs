using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Ряд Фибоначи==============");
            Console.WriteLine(Fibonacci.FibonacciElement(77));
            Fibonacci.FibonacciRange(13, 29);
            Fibonacci.FibonacciElementsLength(10, 100);

            Console.ReadKey();
        }
    }
}
