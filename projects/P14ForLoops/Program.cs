using System;

    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 1001; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 200; i > 99; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1024; i > 0 ; i /= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
