using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3, volume;
            Console.Write("Insira o primeiro valor: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o terceiro valor: ");
            v3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            volume = v1 * v2 * v3;
            Console.Write("O volume da caixa é: {0}", volume);
            Console.ReadKey();
        }
    }
}
