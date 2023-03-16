using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;
            Console.Write("Digite um lado do triangulo: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um lado do triangulo: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um lado do triangulo: ");
            l3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (l1 < (l2+l3))
            {
                if (l1 == l2 && l1==l3 && l2==l3)
                {
                    Console.Write("Esse triangulo é equilatero");
                } else if (l1 == l2 && l1 != l3 || l1==l3 && l1!=l2)
                {
                    Console.Write("Esse triangulo é isoscele");
                }
                else
                {
                    Console.Write("Esse triangulo é escaleno");
                }
                
            }
            Console.ReadKey();
        }
    }
}
