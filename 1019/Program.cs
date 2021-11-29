using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sec, min, hor, val;
            val = int.Parse(Console.ReadLine());
            hor = val / 3600; 
            val -= hor * 3600;
            sec = val % 60;
            min = val / 60;
            Console.WriteLine(hor + ":" + min + ":" + sec);
            Console.ReadLine();
        }
    }
}
