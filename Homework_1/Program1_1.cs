using System;

namespace Lesson_1
{
    class Program1_1
    {
        public static void Main(string[] args)
        {
            for (int i = 4; i < 10; i++)
            {
                for (int j = 3; j < i; j++)
                {
                    for (int k = 2; k < j; k++)
                    {
                        for (int l = 1; l < k; l++)
                        {
                            Console.WriteLine(i.ToString() + j.ToString() + k.ToString() + l.ToString());
                        }
                    }
                }
            }


        }
    }
}