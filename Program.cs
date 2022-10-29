using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont =1, idade;

            //contar de 1 a 10

            do
            {
                Console.WriteLine($"Número {cont}");
                cont++;
            } while (cont <= 10);

            //fazendo a validação de uma idade que tem 
            // que ser maior ou igual a 0
            do
            {
                Console.WriteLine("Digite uma idade:");
                idade = Convert.ToInt32(Console.ReadLine());
            } while (idade < 0);

            //idade = -1 //forçar a entrada
            
                Console.WriteLine("Digite a idade:");
                idade = Convert.ToInt32(Console.ReadLine());
                while(idade<0)
                {
                    Console.WriteLine("Digite a idade");
                    idade = Convert.ToInt32(Console.ReadLine());
                }
            

            Console.ReadKey();
        }

    }
}
