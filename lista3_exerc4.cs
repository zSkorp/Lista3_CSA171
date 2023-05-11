using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicador = 0;
            int produto;
            Console.WriteLine("Tabuada do 5 no intervalo de 1 a 10");
            while (multiplicador != 10)
            {
                multiplicador++;
                produto = multiplicador * 5;
                Console.WriteLine("5 x {0} = {1}", multiplicador, produto);
            }
        }
    }
}
