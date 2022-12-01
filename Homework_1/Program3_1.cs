using System;

namespace Lesson_1
{
    class Program3_1
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] a1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = a1[0];
                double p = a1[1];
                double[] a = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                double x = 0;
                foreach (int i in a)
                {
                    x += Math.Pow(i, p);
                }
                Console.WriteLine(Math.Pow(x, (1/p)));
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
        }
    }
}