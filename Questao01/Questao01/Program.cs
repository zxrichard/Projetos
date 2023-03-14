using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 ;
            Console.Write("Escreva um numero ");
            n1 = Convert.ToInt32(Console.ReadLine());
         

            if (n1%2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            Console.ReadKey();

        }
    }
}
