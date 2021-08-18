using System;

namespace EX09BooleanIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int x;

            if (a + b == b) 
            {
                x = 1;
            }
            else
            {
                if (b - a == a) //True
                {
                    x = 2;
                    Console.WriteLine();
                    Console.WriteLine(x);
                }
                if (c - b == b)
                {
                    x = 3;
                    Console.WriteLine();
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
