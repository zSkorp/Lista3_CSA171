using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuadaX;
            int intervaloB;
            int intervaloA;
            int produto;
            do
            {
                Console.Write("Entre com um valor positivo: ");
                tabuadaX = int.Parse(Console.ReadLine());
            } while (tabuadaX <= 0);

            do
            {
                Console.Write("Entre com o maior valor para multiplicar: ");
                intervaloB = int.Parse(Console.ReadLine());
            } while (intervaloB <= 0);

            do
            {
                Console.Write("Entre com o menor valor para multiplicar: ");
                intervaloA = int.Parse(Console.ReadLine());
            } while (intervaloA <= 0 || intervaloA > intervaloB);

            Console.WriteLine("Tabuada do {0} no intervalo de {1} a {2}", tabuadaX, intervaloB, intervaloA);

            do
            {
                produto = tabuadaX * intervaloB;
                Console.WriteLine("{0} x {1} = {2}", tabuadaX, intervaloB, produto);
                intervaloB--;
                if (intervaloB == intervaloA)
                {
                    produto = tabuadaX * intervaloB;
                    Console.WriteLine("{0} x {1} = {2}", tabuadaX, intervaloB, produto);
                }
            } while (intervaloB != intervaloA);
        }
    }
}
