using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salario2;
            Console.Write("Digite o salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            if (salario<=1500)
            {
                salario2 = salario + (salario * 0.23);
                Console.Write("Seu novo salario é: {0}", salario2);
            }
            else
            {
                salario2 = salario + (salario*0.18);
                Console.Write("Seu novo salario é: {0}", salario2);
            }
            Console.ReadKey();
        }
    }
}
