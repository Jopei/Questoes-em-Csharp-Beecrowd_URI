using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double total;
            string[] item1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(item1[0]), qtd1 = int.Parse(item1[1]); 
            double price1 = double.Parse(item1[2]);

            string[] item2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(item2[0]), qtd2 = int.Parse(item2[1]);
            double price2 = double.Parse(item2[2]);

            total = (qtd1 * price1) + (qtd2 * price2); 
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
            Console.ReadLine();

        }
    }
}
 