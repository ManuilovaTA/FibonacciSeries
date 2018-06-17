using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public static class Fibonacci
    {
        public static long FibonacciElement(int n)
        {            
                double goldenSection = (1 + Math.Sqrt(5)) / 2;
                double x = Math.Pow(goldenSection, n);
                double y = Math.Pow(goldenSection, -n);
                long first = Convert.ToInt64((x - (-y)) / (2 * goldenSection - 1));
            return first;
            
        }

        public static long[] FibonacciRange(int n1, int n2)
        {
            Console.WriteLine("Элементы в диапазоне от {0} до {1}", n1, n2);
            long[] range = new long[n2 - n1 +1];
            for (int i = n1, j = 0; j < range.Length; i++, j++)
            {
                range[j] = FibonacciElement(i);
                Console.Write(range[j] + " ");
            }

            Console.WriteLine();
            return range;
        }
       
        public static string FibonacciElementsLength(int startPos, int endPos)
        {
            int count = 0;
            string result = "";
            while (FibonacciElement(count) <= startPos)
            {
                count++;
                if (FibonacciElement(count) >= startPos)
                {
                    result += FibonacciElement(count) + " ";
                    Console.Write(FibonacciElement(count) +" ");
                }
            }
            while(FibonacciElement(count) >= startPos && FibonacciElement(count) <= endPos)
            {
                count++;
                if (FibonacciElement(count) <= endPos)
                {
                    result += FibonacciElement(count) + " ";
                    Console.Write(FibonacciElement(count) +" ");
                    
                }
            }
            return result;

        }

        
    }
}
