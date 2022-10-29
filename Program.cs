using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //crie um vetor de 5 strings
            String[] nomes = new string[5];
            //crie um vettor de 3 inetiros
            //int[] numeros = new int[3];
            //crie um vetor de 2 doubles (salário) e já coloca o valor
            //double[] salarios = { 1500.99, 3400.00 };

            //para atribuir um dado fixo
            //nomes[0] = "João";

            //para atribur um dado do usuario
            //numeros[2] = Convert.ToInt32(Console.ReadLine());

            //int pos = 2;
            //nomes[pos] = Console.ReadLine();

            //entrada de dados automatico
            for(int p=0; p<nomes.Length; p++)
            {
                Console.WriteLine($"Digite o Nome[{p + 1}]");
                nomes[p] = Console.ReadLine();
            }
            //não funciona para exibir os dados dos nomes
            //Console.WriteLine(nomes);
            //Console.WriteLine(nomes[]);

            //para exibir todos os nomes
            for(int p=0; p<nomes.Length; p++)
            {
                Console.WriteLine($"Nomes[{p + 1}]:{nomes[p]}");
            }


            //Outra forma
            //foreach(String p in nomes)
            //{
            //    Console.WriteLine($"Nomes: {p}");
            //}

            Console.ReadKey();
        }


    }
}
