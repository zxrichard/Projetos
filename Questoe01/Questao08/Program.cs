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
            double a, b;
            string r;
            int op;
            do
            {
                Console.Write("Insira um numero: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Outro: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Operação que você quer:\n 1-Adição\n 2-Subtração\n 3-Multiplicaçao \n 4- Divisao");
                op =Convert.ToInt32( Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write(a + b);
                        Console.Read();
                        Console.Clear();
                        break;
                    case 2: 
                        Console.Write(a - b);
                        Console.Read();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write(a * b);
                        Console.Read();
                        Console.Clear();
                        break;
                    case 4:
                       Console.WriteLine(a / b);
                       Console.Read();
                       Console.Clear();
                        break;

                    default:
                        break;
                }
                Console.Write("Alguma outra operação?");
                r = Console.ReadLine();
                Console.Clear();
                } while (r == "sim");

        }
    }
}
