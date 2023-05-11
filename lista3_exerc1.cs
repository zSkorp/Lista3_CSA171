using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            do
            {
                Console.Write("Entre com um número positivo: ");
                valor = double.Parse(Console.ReadLine());
            } while (valor <= 0);
            Console.WriteLine("Número positivo!");
        }
    }
}
