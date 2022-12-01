using System;

namespace Lesson_1
{
    class Program3_2
    {
        public static void Main(string[] args)
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int ind = Convert.ToInt32(Console.ReadLine());
                Array.Sort(numbers);
                Console.WriteLine(numbers[ind - 1]);
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
        }
    }
}