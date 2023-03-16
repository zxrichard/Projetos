using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int n1, n2;

            Console.Write("Digite um nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite um nome: ");
            nome2 = Console.ReadLine();

            n1 = nome1.Length;
            n2 = nome2.Length;
            Console.Clear();
            if (n1>n2)
            {
                Console.Write("O primeiro nome é maior");
            }
            else
            {
                Console.Write("O segundo nome é maior");
            }
            Console.ReadKey();
        }
    }
}
