using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int loopCount = 2;
            
            for (int i = 0; i < 3; i++)
            {
                CountUp(loopCount);
                CountDown(loopCount);
                loopCount++;
            }

        }

        static void CountUp(int to)
        {
            
            int countUp = -1;
            int toText = to - 1;
            
            Console.WriteLine("Counting from 0 to " + toText);


            for (int i = 0; i < to; i++)
            {
                countUp++;
                Console.WriteLine(countUp);
            }
        }
        
        static void CountDown(int to)
        {
            
            int countDown = to;
            int toText = countDown - 1;
            
            Console.WriteLine("Counting from " + toText + " to 0");
            
            for (int i = 0; i < to; i++)
            {
                countDown--;
                Console.WriteLine(countDown);
            }
        }
    }
}