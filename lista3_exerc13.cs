using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string simnao;
            do
            {
                int fatorial;
                do
                {
                    Console.Write("Digite o fatorial: ");
                    fatorial = int.Parse(Console.ReadLine());
                    if (fatorial < 0)
                    {
                        Console.WriteLine("Erro, digite um número positivo!");
                    }
                } while (fatorial < 0);
                for (int i = fatorial - 1; i >= 1; i--)
                    fatorial = fatorial * i;
                Console.WriteLine("\nFatorial: {0} ", fatorial);
                Console.Write("\nDeseja executar novamente o programa? Responda com (S) ou (N): ");
                simnao = Console.ReadLine();
                if (simnao != "S" && simnao != "s" && simnao != "N" && simnao != "n")
                    Console.WriteLine("\nErro\n");
            } while (simnao == "S" || simnao == "s");

        }
    }
}
