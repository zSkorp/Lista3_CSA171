using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int intervalo;
            int produto;
            
            Console.WriteLine("\nTabuadas de 1 a 20 no intervalo de 1 a 10!\n");

            for (valor = 1; valor <= 20; valor++)
            {
                for (intervalo = 1; intervalo <= 10; intervalo++)
                {
                    produto = valor * intervalo;
                    Console.WriteLine("{0} x {1} = {2}", valor, intervalo, produto);
                }
                if (valor == 20)
                {
                    Console.WriteLine();
                    break;
                }
                else
                Console.WriteLine("\nPressione qualquer tecla para continuar vendo as tabuadas\n");
                Console.ReadKey(true);
            }
        }
    }
}
