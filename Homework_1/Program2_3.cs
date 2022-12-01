using System;

namespace Lesson_1
{
    class Program2_3
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
            int n1 = Convert.ToInt32(Console.ReadLine()), n2 = Convert.ToInt32(Console.ReadLine()), n3 = Convert.ToInt32(Console.ReadLine()), n4 = Convert.ToInt32(Console.ReadLine());
            String a1 = ten_to_bi(n1).PadLeft(16, '0');
            String a2 = ten_to_bi(n2).PadLeft(16, '0');
            String a3 = ten_to_bi(n3).PadLeft(16, '0');
            String a4 = ten_to_bi(n4).PadLeft(16, '0');
            long res = Convert.ToInt64(a4 + a3 + a2 + a1, 2);
            Console.WriteLine(res);
        }
    }
}