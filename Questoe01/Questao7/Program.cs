using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalP, quantia, valor, vTotal, saldo, prest;
            Console.Write("Digite o numero de prestações a serem pagas: ");
            prest = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o numero de prestações que ja foram pagas: ");
            quantia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor das prestações: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            vTotal = valor * prest;
            totalP = quantia * valor;
            saldo = vTotal - totalP;
            Console.Write("Você pagou o total de {0} reais, e faltam {1} reais", totalP, saldo);
            Console.ReadKey();

        }
    }
}
