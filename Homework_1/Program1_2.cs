using System;

namespace Lesson_1
{
    class Program1_2
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n - Math.Abs(i - j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}