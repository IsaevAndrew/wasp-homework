using System;

namespace Lesson_1
{
    class Program1_4
    {
        public static int fact(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int f = fact(i);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(f / (fact(i - j) * fact(j)));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}