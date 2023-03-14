using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, n2, n3;
            Console.Write("Numero 1: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (n>n2 && n>n3)
            {
                Console.Write("O maior número é: {0}", n);

            }
            else if (n2>n && n2>n3)
            {
                Console.Write("O maior número é: {0}", n2);

            }
            else
            {
                Console.Write("o maior número é: {0}", n3);
            }
            Console.ReadKey();
        }
    }
}
