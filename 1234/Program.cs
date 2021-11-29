using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234
{
    internal class Program
    {
        void Fprint(int cont,string result)
        {

            for (int i = 0; i < cont; i++)
            {

                Console.Write(result[i]);
                Console.WriteLine();

            }
        }
        private static void Fprint(int cont, List<string> result)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            int length;
            string sentence;
            
            int cont = 0;
            //sentence = Console.ReadLine();
            List<string> result = new List<string> { };
            while (!string.IsNullOrWhiteSpace(sentence = Console.ReadLine()))
            {

                //StringBuilder sentenceUpper = new StringBuilder(sentence);
                char[] sentenceChar = sentence.ToCharArray();
                bool upper = true;
                string sentenceUpper = "";
                length = sentence.Length;
                for (int i = 0; i < length; i++)
                {
                    /*if (sentence[i] == ' ')
                    {
                        sentenceUpper += " ";

                    }
                    else if (upper)
                    {
                        sentenceUpper += char.ToUpper(sentenceChar[i]); 
                        upper = false;

                    }
                    else
                    {
                        sentenceUpper += char.ToLower(sentenceChar[i]);
                        upper = true;
                    }*/
                    if (sentenceChar[i] != ' ')
                    {
                        if (upper)
                        {

                            sentenceUpper += char.ToUpper(sentenceChar[i]);
                        }

                        else
                        {
                            sentenceUpper += char.ToLower(sentenceChar[i]);
                        }

                        upper = !upper;
                    }

                    else
                    {
                        sentenceUpper += " ";
                    }
                }
                result.Insert(cont, sentenceUpper);
                cont++;
            }
            Fprint(cont, result);
            
            //Console.WriteLine(final);
            Console.ReadLine();

        }

       
    }
}
