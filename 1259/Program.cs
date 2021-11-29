using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1259
{
    internal class Program
    {
        static void Pair()
        {
            long qtd = long.Parse(Console.ReadLine());
            List<int> odd = new List<int>(); // Para impar
            List<int> pair = new List<int>();//Para par
            for(int i = 0; i < qtd; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    odd.Add(num);  
                }
                else
                {
                    pair.Add(num);
                }
            }
            odd.Sort();
            pair.Sort();
            odd.Reverse();
            #pragma warning disable CS0162 
            for (int i = 0; i < qtd; i++)
            #pragma warning restore CS0162 
            {
                for (int j = 0; j < pair.Count; j++)
                {

                    Console.WriteLine(pair[j]);
                }

                for (int k = 0; k < odd.Count; k++)
                {

                    Console.WriteLine(odd[k]);
                }
                break;
            }
        }
        static void Main(string[] args)
        {
            Pair();
            Console.ReadLine();
        }
    }
}
