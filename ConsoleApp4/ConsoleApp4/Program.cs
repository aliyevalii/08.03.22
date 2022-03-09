using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sahe(result));

            double result1= Convert.ToDouble(Console.ReadLine());
            double result12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sahe(result1));

            double result21 = Convert.ToDouble(Console.ReadLine());
            double result22 = Convert.ToDouble(Console.ReadLine());
            double result23 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sahe(result21));

            double result3 = Convert.ToDouble(Console.ReadLine());
            double result31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sahe(result3));

        }
        static double Sahe(double side1 )
        {           
                  return side1 * side1 * 3;
                                   
        }
        static double Sahe(double side1, double side2)
        {
            return side1 * side2; 


        }
        static double Sahe(double side1, double side2, double side3)
        {
            return 2 * (side1 * side2 + side1 * side3 + side2 * side3);
           
        }
        static double Sahe(int side1,int halfperm)
        {
            
            return side1 * halfperm;
           
        }
    }
}
