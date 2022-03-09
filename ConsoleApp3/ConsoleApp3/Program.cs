using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("saitlerin sayi : ");
            Console.Write(VowelLetter());
            Console.ReadLine();
        }

        static object VowelLetter(string text = "bbbbbaaa" )
        {
            
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'A' || text[i] == 'ı' || text[i] == 'I' || text[i] == 'o' || text[i] == 'O' || text[i] == 'u' || text[i] == 'U' || text[i] == 'e' || text[i] == 'E' || text[i] == 'ə' || text[i] == 'Ə' || text[i] == 'i' || text[i] == 'İ' || text[i] == 'ö' || text[i] == 'Ö' || text[i] == 'Ü' || text[i] == 'ü')
                {
                    counter++;
                }
                
                               
            }
            return counter;
        }
    }
}
