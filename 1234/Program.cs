using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            bool upper = true;
            string sentence;
            sentence = Console.ReadLine();
            StringBuilder sentenceUpper = new StringBuilder(sentence);
            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] == ' ')
                {
                    sentenceUpper[i] = sentence[i];
                }
                else if (upper)
                {
                    sentenceUpper[i] = sentence.ToUpper()[i];
                    upper = false;

                }
                else
                {
                    sentenceUpper[i] = sentence.ToLower()[i];
                    upper = true;
                }
            }
            sentence = sentenceUpper.ToString();
            Console.WriteLine(sentence);
            Console.ReadLine();

        }

       
    }
}
