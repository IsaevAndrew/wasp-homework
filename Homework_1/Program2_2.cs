using System;

namespace Lesson_1
{
    class Program2_2
    {
        public static int add(int n1, int n2)
        {
            int a = n1, b = n2, c;
            while (b != 0)
            {
                c = a & b;
                a = a ^ b;
                b = c << 1;
            }
            return a;
        }
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
            int n1 = Convert.ToInt32(Console.ReadLine()), n2 = Convert.ToInt32(Console.ReadLine());
            String a1 = ten_to_bi(n1);
            String a2 = ten_to_bi(n2);
            String res = ten_to_bi(add(n1, n2));
            Console.WriteLine(a1.PadLeft(res.Length, '0'));
            Console.WriteLine(a2.PadLeft(res.Length, '0'));
            Console.WriteLine("".PadLeft(res.Length, '-'));
            Console.WriteLine(res);
        }
    }
}