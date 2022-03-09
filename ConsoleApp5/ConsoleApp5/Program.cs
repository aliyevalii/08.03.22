using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter());
            Console.ReadLine();
        }
        static void HasLetter(string[] text)
        {
            
            bool has = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "all");
                {
                    has = true;
                    break;
                }
            }
            if (has) Console.WriteLine("axtarilan simvol var");
            else Console.WriteLine("axtarilan soz yoxdur");
            
        }

    }
}
