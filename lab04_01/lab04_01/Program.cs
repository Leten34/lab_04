using System;

namespace lab04_01
{
    class Utils
    {
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
            int x; int y;
            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
        }
    }
}
