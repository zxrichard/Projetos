using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            string nome, bairro, tel;
          
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Insira seu bairro: ");
            bairro = Console.ReadLine();
            Console.Write("Insira seu numero: ");
            tel = Console.ReadLine();
           Console.Clear();
            Console.WriteLine("Suas informações são: {0}, {1}, {2}", nome, bairro, tel);
            Console.ReadKey();
            
        }
    }
}
