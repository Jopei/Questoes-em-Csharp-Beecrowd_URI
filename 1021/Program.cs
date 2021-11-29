using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val = 0, money, coin;
            int rest;
            val = double.Parse(Console.ReadLine());
            rest = (int)Math.Truncate(val);
            Console.WriteLine("NOTAS:");
            //Nota de 100
            money = rest / 100;
            Console.WriteLine(money + " nota(s) de R$ 100.00");
            rest = rest % 100;
            //Nota de 50
            money = rest / 50;
            Console.WriteLine(money + " nota(s) de R$ 50.00");
            rest = rest % 50;
            //Nota de 20
            money = rest / 20;
            Console.WriteLine(money + " nota(s) de R$ 20.00");
            rest = rest % 20;
            //Nota de 10
            money = rest / 10;
            Console.WriteLine(money + " nota(s) de R$ 10.00");
            rest = rest % 10;
            //Nota de 5
            money = rest / 5;
            Console.WriteLine(money + " nota(s) de R$ 5.00");
            rest = rest % 5;
            //Nota de 2
            money = rest / 2;
            Console.WriteLine(money + " nota(s) de R$ 2.00");
            rest = rest % 2;


            //Moedas

            //Moeda de 1
            Console.WriteLine("MOEDAS:");
            money = rest / 1;
            Console.WriteLine(money + " moeda(s) de R$ 1.00");

           
            rest = 0;
            rest = (int)((val - (int)Math.Truncate(val)) * 100);
            //rest += 1;
            //Moeda de 50
            coin = rest / 50;
            Console.WriteLine(coin + " moeda(s) de R$ 0.50");
            rest = rest % 50;
            //Moeda de 25
            coin = rest / 25;
            Console.WriteLine(coin + " moeda(s) de R$ 0.25");
            rest = rest % 25;
            //Moeda de 10
            coin = rest / 10;
            Console.WriteLine(coin + " moeda(s) de R$ 0.10");
            rest = rest % 10;
            //Moeda de 5
            coin = rest / 5;
            Console.WriteLine(coin + " moeda(s) de R$ 0.05");
            rest = rest % 5;
            //Moeda de 1
            money = rest / 1;
            Console.WriteLine(money + " moeda(s) de R$ 0.01");
            Console.ReadLine();
        }
    }
}
