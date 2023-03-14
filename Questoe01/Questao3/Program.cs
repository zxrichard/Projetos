using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id, id2, id3, id4, id5, m;
            Console.Write("Idade do primeiro aluno: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Idade do segundo aluno: ");
            id2 = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Idade do terceiro aluno: ");
            id3 =Convert.ToInt32(Console.ReadLine());   
            Console.Write("Idade do quarto aluno: ");
            id4 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Idade do quinto aluno: ");
            id5 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            m = (id+id2+id3+id4+id5)/ 5;
            Console.Write("A média da idade dos alunos é {0}", m);
            Console.ReadKey();
        }
    }
}
