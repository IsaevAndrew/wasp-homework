using System;

namespace Lesson_1
{
    class Program2_1
    {
        public static String ten_to_bi(int n)
        {
            String ans_add = "";
            while (n != 1)
            {
                ans_add += Convert.ToString(n & 1);
                n >>= 1;
            }
            ans_add += Convert.ToString(n & 1);
            String reverse = "";
            for (int i = ans_add.Length - 1; i > -1; i--)
            {
                reverse += ans_add[i];
            }
            return reverse;
        }

        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ten_to_bi(a));
        }
    }
}