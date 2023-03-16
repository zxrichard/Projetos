using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, imc;
            Console.Write("Digite sua altura: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            imc = n2 / (n1 * n1);
            Console.Clear();
            Console.Write("seu imc é: {0}", imc);
            Console.ReadKey();

        }
    }
}
