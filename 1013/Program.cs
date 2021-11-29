using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] item1 = Console.ReadLine().Split(' ');
            int n1 = int.Parse(item1[0]), n2 = int.Parse(item1[1]),n3 = int.Parse(item1[2]);
            int bigger= (n1 + n2 + Math.Abs(n1 - n2)) / 2;// Funcão de Comparação para descobrir o maior A e B
            int biggerFinal  = (bigger + n3 + Math.Abs(bigger - n3)) / 2; // Funcão de Comparação para descobrir o maior AB e C
            Console.WriteLine(biggerFinal + " eh o maior");
            Console.ReadLine();
            
        }
    }
}
