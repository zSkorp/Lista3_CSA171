using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int fibonacci;
            Console.WriteLine("Sequência de Fibonacci até o 30º número");
            Console.Write("\nSequência: ");
            for (int i = 0; i < 30; i++)
            {
                fibonacci = x + y;
                Console.Write("{0} ", fibonacci);
                x = y;
                y = fibonacci;
            }
            Console.WriteLine("\n");
        }
    }
}
