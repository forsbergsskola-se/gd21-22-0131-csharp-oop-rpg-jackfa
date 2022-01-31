using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[11];
            Random random = new Random();

            Console.WriteLine("I will roll 10.000 numbers between 0 and 10.");

            for (int i = 0; i < 10000; i++)
            {
                int roll = random.Next(0, 11);
                if (roll == 0)
                {
                    array[0]++;
                }
                else if (roll == 1)
                {
                    array[1]++;
                }
                else if (roll == 2)
                {
                    array[2]++;
                }
                else if (roll == 3)
                {
                    array[3]++;
                }
                else if (roll == 4)
                {
                    array[4]++;
                }
                else if (roll == 5)
                {
                    array[5]++;
                }
                else if (roll == 6)
                {
                    array[6]++;
                }
                else if (roll == 7)
                {
                    array[7]++;
                }
                else if (roll == 8)
                {
                    array[8]++;
                }
                else if (roll == 9)
                {
                    array[9]++;
                }
                else if (roll == 10)
                {
                    array[10]++;
                }

            }
            Console.WriteLine("I rolled 0 a total of " + array[0] + " times");
            Console.WriteLine("I rolled 1 a total of " + array[1] + " times");
            Console.WriteLine("I rolled 2 a total of " + array[2] + " times");
            Console.WriteLine("I rolled 3 a total of " + array[3] + " times");
            Console.WriteLine("I rolled 4 a total of " + array[4] + " times");
            Console.WriteLine("I rolled 5 a total of " + array[5] + " times");
            Console.WriteLine("I rolled 6 a total of " + array[6] + " times");
            Console.WriteLine("I rolled 7 a total of " + array[7] + " times");
            Console.WriteLine("I rolled 8 a total of " + array[8] + " times");
            Console.WriteLine("I rolled 9 a total of " + array[9] + " times");
            Console.WriteLine("I rolled 10 a total of " + array[10] + " times");
        }
    }
}