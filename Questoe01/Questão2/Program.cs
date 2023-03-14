using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Digite um numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Outro: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Resultado é: " + a * b);
            Console.ReadKey();

        }
    }
}
