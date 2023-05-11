using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exerc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string simnao;
            do
            {
                double n = 0;
                double x = 0;
                double maior = 0;
                double menor = 9999;
                double soma = 0;
                double media = 0;
                double porcentagem = 0;
                double positivos = 0;
                double negativos = 0;
                Console.Write("\nDigite a quantidade de números a serem calculados (max: 20): ");
                n = double.Parse(Console.ReadLine());
                if (n <= 20 && n > 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("Insira um número: ");
                        x = double.Parse(Console.ReadLine());
                        if (x >= 0)
                            positivos++;
                        else
                            negativos++;
                        if (x > maior)
                            maior = x;
                        else if (x < maior && x < menor)
                            menor = x;
                        soma += x;
                        media = soma / n;
                        porcentagem = (positivos / 0.01) / n;
                        negativos = 100 - porcentagem;
                    }
                    Console.WriteLine("\nMaior valor: {0}", maior);
                    Console.WriteLine("\nMenor valor: {0}", menor);
                    Console.WriteLine("\nSoma dos valores: {0}", soma);
                    Console.WriteLine("\nMédia aritmética dos valores: {0}", media);
                    Console.WriteLine("\nPorcentagem de valores positivos: {0}", porcentagem);
                    Console.WriteLine("\nPorcentagem de valores negativos: {0}\n", negativos);
                }
                else
                {
                    Console.WriteLine("\nErro\n");
                    return;
                }
                Console.Write("\nDeseja executar novamente o programa? Responda com (S) ou (N): ");
                simnao = Console.ReadLine();
                if (simnao != "S" && simnao != "s" && simnao != "N" && simnao != "n")
                    Console.WriteLine("\nErro\n");
            } while (simnao == "S" || simnao == "s");
        }
    }
}
