using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val=0, money, rest;
            val = int.Parse(Console.ReadLine());
            rest = val;
            Console.WriteLine(val);
            //Nota de 100
            money = rest / 100;
            Console.WriteLine(money + " nota(s) de R$ 100,00");
            rest = rest % 100;
            //Nota de 50
            money = rest / 50;
            Console.WriteLine(money + " nota(s) de R$ 50,00");
            rest = rest % 50;
            //Nota de 20
            money = rest / 20;
            Console.WriteLine(money + " nota(s) de R$ 20,00");
            rest = rest % 20;
            //Nota de 10
            money = rest / 10;
            Console.WriteLine(money + " nota(s) de R$ 10,00");
            rest = rest % 10;
            //Nota de 5
            money = rest / 5;
            Console.WriteLine(money + " nota(s) de R$ 5,00");
            rest = rest % 5;
            //Nota de 2
            money = rest / 2;
            Console.WriteLine(money + " nota(s) de R$ 2,00");
            rest = rest % 2;
            //Nota de 1
            money = rest / 1;
            Console.WriteLine(money + " nota(s) de R$ 1,00");
            Console.ReadLine();
            
        }
    }
}
