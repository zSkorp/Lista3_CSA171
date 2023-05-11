using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            Console.Write("Insira o primeiro valor: ");
            valor1  = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Insira o segundo valor, sendo maior q o primeiro: ");
                valor2 = double.Parse(Console.ReadLine());
            } while (valor1 > valor2);
        }
    }
}
