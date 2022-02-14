using System;

class Program
{
    static string[] names = new string[3];
    static void Main()
    {

        for (int i = 0; i < names.Length; i++)
        {
            names[i] = Console.ReadLine();
        }
        
        Console.Write(names[0] + ", " + names[1] + ", " + names[2]);
    }
}