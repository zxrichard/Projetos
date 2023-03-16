using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s;
            double alt, pesoId;
            Console.WriteLine("Escreva seu genero: \n1-Feminino \n2-Masculino");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Escreva sua altura: ");
            alt = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (s==1)
            {
                pesoId = (62.1 * alt) - 44.7;
                Console.Write("Seu peso ideal é: {0}kg", pesoId);
            }
            else
            {
                pesoId = (72.7 * alt) - 58;
                Console.Write("Seu peso ideal é: {0}kg", pesoId);
            }
            Console.ReadKey();
        }
       
    }
}
