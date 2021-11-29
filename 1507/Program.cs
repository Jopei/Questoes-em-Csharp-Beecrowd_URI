using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1507
{
    class Program
    {

        public static bool Equal(string principal, string sub)
        {

            int charCh = 0,index = 0;

            foreach (char caractere in principal)
            {
                if (caractere == sub[index])
                {
                    charCh++;
                    index++;

                    if (charCh == sub.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder saida = new StringBuilder();

            for (int j = 0; j < N; j++)
            {
                string S = Console.ReadLine();
                int Q = int.Parse(Console.ReadLine());
                string[] R = new string[Q];
                for (int i = 0; i < Q; i++)
                {
                    R[i] = Console.ReadLine();
                }

                byte[] asciiBytes = Encoding.ASCII.GetBytes(S);
                for (int i = 0; i < Q; i++)
                {
                    if (Equal(S, R[i]))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }

    }
}


