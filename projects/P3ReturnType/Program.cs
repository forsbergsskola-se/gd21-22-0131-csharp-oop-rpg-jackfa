using System;
using System.Threading.Channels;

namespace ReturnType
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Which Fibonacci number do you want?");
            int position = Int32.Parse(Console.ReadLine());
            Fibonnaci(position);
        }

        static int Fibonnaci(int position)
        {
            int number = position - 1;
            int[] fibonacciArray = new int[number + 1];
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;
            
            for (int i = 2; i <= number; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 2] + fibonacciArray[i - 1];
            }
            
            Console.WriteLine("Number " + position + " has the value " + fibonacciArray[number]);
            
            return fibonacciArray[number];
        }
    }
}