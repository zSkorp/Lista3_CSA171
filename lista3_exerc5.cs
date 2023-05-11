using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int multiplicador = 0;
            int produto;
            do
            {
                Console.Write("Entre com um valor positivo: ");
                valor = int.Parse(Console.ReadLine());
            } while (valor <= 0);
            Console.WriteLine("Tabuada do {0} no intervalo de 1 a 10", valor);
            while (multiplicador != 10)
            {
                multiplicador++;
                produto = valor * multiplicador;
                Console.WriteLine("{0} x {1} = {2}", valor, multiplicador, produto);
            }
        }
    }
}
