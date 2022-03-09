using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            NumLength();
            Console.ReadLine();
        }


        static int NumLength(int number=12312312)
        {
            int digit = 0;
            int counter = 0;
            while (number>0)
            {
                digit = number % 10;
                    counter++;
                number /= 10;
            }
           
            Console.WriteLine(counter);
            return counter;
        }

    }
}
