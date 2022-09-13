using System;

namespace MethodsPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator");

            Console.WriteLine(Add(2, 5, 13, 7));

            Console.WriteLine(Multiply(3, 8, 24));
        }

        //addition method
        //takes a variable number of int arguments
        //returns sum of arguments
        public static int Add(params int[] List)
        {
            int sum = 0;
            for (int i = 0; i < List.Length; i++)
            {
                sum += List[i];
            }
            return sum;
        }

        //multiplication method
        //takes a variable number of int arguments
        //returns product of arguments
        public static int Multiply(params int[] List)
        {
            int product = 1;

            for (int i = 0; i < List.Length; i++)
            {
                product *= List[i];
            }
            return product;
        }
    }
}