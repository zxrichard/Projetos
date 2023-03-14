using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano, m, s, n;
            Console.Write("Insira uma quantidade de dias: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            ano = n / 365;
            m = n / 31;
            s = n / 7;
            Console.Write("Os numeros de dias convertidos para anos {0}, para mes {1}, para semanas {2}", ano, m, s);
            Console.ReadKey ();

        }
    }
}
