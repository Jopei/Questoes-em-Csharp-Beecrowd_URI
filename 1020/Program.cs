using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, day, val;
            val = int.Parse(Console.ReadLine());
            year = val / 365;
            month = (val % 365)/30;
            day = ((val % 365) % 30); ///30;
            Console.WriteLine(year + " ano(s)");
            Console.WriteLine(month + " mes(es)");
            Console.WriteLine(day + " dia(s)");
            Console.ReadLine();
        }
    }
}
