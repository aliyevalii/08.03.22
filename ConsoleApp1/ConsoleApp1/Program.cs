using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 123, 333, 875, 12315, 35,-3 };
            Min(array);
            Console.WriteLine(Min(array));
        }


        static int Min(int[] array)
        {
            
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min>array[i])
                {
                    min = array[i];
                }
                
            }
            return min;
       }
    }
}
