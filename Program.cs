using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_51
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            double[] salarios = new double[5];

            for (int p = 0; p < nomes.Length; p++)
            {
                Console.WriteLine($"Digite nome({p+1}):");
                nomes[p] = Console.ReadLine();
            }

            for(int p2=0; p2< salarios.Length; p2++ )
            {
                Console.WriteLine($"Digite salário({p2 + 1}):");
                nomes[p2] = Console.ReadLine();
            }
        }
    }
}
