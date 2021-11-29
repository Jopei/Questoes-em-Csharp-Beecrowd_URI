using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            //sentence = Console.ReadLine();


            while (!string.IsNullOrWhiteSpace(sentence = Console.ReadLine()))
            {
                string finalSentence = sentence;
                Dictionary<byte, int> asciiList = new Dictionary<byte, int>();
                while (finalSentence.Length != 0)
                {
                    int totalLength = finalSentence.Length;
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(finalSentence); // Char de byte 
                    finalSentence = finalSentence.Trim(finalSentence.ToCharArray()[0]);
                    asciiList.Add(asciiBytes[0], (totalLength - finalSentence.Length));

                    //asciiList.Add(asciiBytes[0]);
                    //repeticoesAsciiList.Add(totalLength - finalSentence.Length);
                }

                foreach (KeyValuePair<byte, int> value in asciiList.OrderBy(key => key.Value))
                {
                    Console.WriteLine("{0} {1}", value.Key, value.Value);
                }
                Console.WriteLine("\n");

            }


            //Console.WriteLine(final);
            // Console.ReadLine();
        }
    }
}
