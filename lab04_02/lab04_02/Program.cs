using System;

namespace lab04_02
{
    class Utils
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
            public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
            Console.WriteLine("До swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);
        }
    }
}
