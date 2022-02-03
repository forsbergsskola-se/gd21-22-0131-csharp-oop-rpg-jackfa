using System;
using System.Security.Principal;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int loopCount = 2;

            Count(1, 3);
            Count(99, 101);
            Count(11, 8);
            Count(2, -1);
            Count(1338, 1337);
            for (int i = 0; i < 3; i++)
            {

            }

        }

        static void Count(int from, int to)
        {
            int countUp = to - from - 1;
            int countDown = -1;
            int fromTextUp = from + 1;
            int fromTextDown = from - 1;
            int toLoopUp = from + 2;

            if (from < to)
            {
                Console.WriteLine("Counting from " + fromTextUp + " to " + to);

                for (int i = from; i < toLoopUp; i++)
                {
                    from += countUp;
                    Console.WriteLine(from);
                }
            }
            else
            {
                Console.WriteLine("Counting from " + fromTextDown + " to " + to);

                for (int i = from; i > to; i--)
                {
                    from += countDown;
                    Console.WriteLine(from);
                }

            }
        }
    }
}