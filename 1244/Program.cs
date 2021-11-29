using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1244
{
    internal class Program
    {
        //Ordenação da String 
        public static void SortByLength(String[] w) //Ordenação por bolha( Utilizei de Atividade realizadas na Linguagem C)
        {
            int[] Wvet = GetSizes(w);
            for (int i = 0; i < Wvet.Length - 1; i++)
            {
                for (int j = 0; j < Wvet.Length - i - 1; j++)
                {
                    if (Wvet[j] < Wvet[j + 1])
                    {
                        Swap(j, j + 1, w, Wvet);
                    }
                }
            }
        }
        public static void Swap(int w1, int w2, String[] words, int[] Wvet)//Pivo para 
        {
            string strjoke = words[w1];
            int joke = Wvet[w1];
            words[w1] = words[w2];
            Wvet[w1] = Wvet[w2];
            words[w2] = strjoke;
            Wvet[w2] = joke;
        }
        //Tamanho da String 
        public static int[] GetSizes(String[] wrd)
        {
            int[] WordSizes = new int[wrd.Length];
            for (int i = 0; i < wrd.Length; i++)
            {
                WordSizes[i] = wrd[i].Length;
            } 
            return WordSizes;
        }
        

        static void Main(string[] args)
        {
            int TestCases = int.Parse(Console.ReadLine());
            string[] w;

            for (int j = 0; j < TestCases; j++)
            {
                w = Console.ReadLine().Split(' ');
                SortByLength(w);
                for (int i = 0; i < w.Length; i++)
                {
                    Console.Write(w[i]);
                    if (i == w.Length - 1)
            continue;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        /*private static void SortByLength(string v)
        {
            throw new NotImplementedException();
        }*/
    }
}
