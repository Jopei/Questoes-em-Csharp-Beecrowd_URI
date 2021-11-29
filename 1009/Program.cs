using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sellerName;
            double salary = 0.0, sales = 0.0;
            sellerName = Console.ReadLine();
            salary = double.Parse(Console.ReadLine());
            sales = double.Parse(Console.ReadLine());
            sales *= 0.15;// sales = sales * 0,15
            salary += sales; //salary = salary + sales
            Console.WriteLine("TOTAL = R$ " + salary.ToString("F2"));
            Console.ReadLine();
        }
    }
}
