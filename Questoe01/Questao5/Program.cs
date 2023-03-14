using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l, km, consumo;
            Console.Write("Quantidade de combustivel: ");
            l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Distancia: ");
            km = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            consumo = km/l;
            Console.WriteLine("O consumo de combustivel é de: {0}", consumo);
            Console.ReadKey(); 
        }
    }
}
