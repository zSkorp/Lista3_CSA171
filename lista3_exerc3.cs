using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            do
            {
                Console.Write("Insira o sexo somente com M ou F: ");
                sexo = Console.ReadLine();
            } while (sexo != "M" && sexo != "m" && sexo != "F" && sexo != "f");
        }
    }
}
