using System;

namespace Lesson_1
{
    class Program3_3
    {
        public static void Main(string[] args)
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int[] m = Array.ConvertAll(Console.ReadLine().Split(':'), int.Parse);
                if (m[2] < 0)
                {
                    for (int i = m[1]; i > m[0]; i += m[2])
                    {
                        Console.Write(a[i]+" ");
                    }
                }
                else if (m[2] > 0)
                {
                    for (int i = m[0]; i < m[1]; i += m[2])
                    {
                        Console.Write(a[i]+" ");
                    }
                }
                else
                    throw new Exception("Step = 0");

            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
        }
    }
}