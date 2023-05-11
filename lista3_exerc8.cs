using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int i;
            Console.WriteLine("Soma de todos os números inteiros de 1 a 100");
            for (i = 0; i <= 100; i++)
                contador += i;
            Console.WriteLine("\nTotal: {0}\n", contador);
        }
    }
}
