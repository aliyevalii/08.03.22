using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sahe(10,5,2)); 

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
