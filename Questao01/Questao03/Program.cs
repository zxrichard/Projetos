using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, m;
            string nome;

            Console.Write("Digite o nome de um aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite uma nota desse aluno: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Outro: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Outro: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Outro: ");
            n4 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            m = (n1 + n2 + n3 + n4) / 4;
            if (m > 60)
            {
                Console.Write("Ele passou de ano, com a média de: {0}", m);
            }
            else
            {
                Console.Write("Reprovado, a média foi de: {0}", m);
            }
            Console.ReadKey();
        }
    }
}
