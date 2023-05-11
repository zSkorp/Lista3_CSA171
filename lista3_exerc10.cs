using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double maior = 0;
            double soma = 0;
            double media = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (x >= 0)
                {
                    Console.Write("Insira um valor positivo: ");
                    x = double.Parse(Console.ReadLine());
                    if (x > maior)
                        maior = x;
                    soma += x;
                    media = soma / 10;
                }
                else
                {
                    Console.WriteLine("\nErro\n");
                    return;
                }
            }
            Console.WriteLine("\nMaior valor: {0}", maior);
            Console.WriteLine("\nSoma dos valores: {0}", soma);
            Console.WriteLine("\nMédia aritmética dos valores: {0}\n", media);
        }
    }
}
