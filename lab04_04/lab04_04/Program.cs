using System;

namespace lab04_04
{
    class Operation
    {
        private static bool Chek(double a, double b, double c)
        {
            bool ok = true;
            if (a < b + c && b < a + c && c < a + b)
                return ok;
            else
            {
                ok = false;
                return ok;
            }
        }
        public static double Formula(double a, double b, double c)
        {
            bool d = Operation.Chek(a, b, c);
            if (d)
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else
            {
                Console.WriteLine("Треугольник НЕ СУЩЕСТВУЕТ");
                return 0;
            }
        }
        public static double Formula(double a)
        {
            double p = a * 3 / 2;
            double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите стороны треугольника:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if(a == b && a == c)
            {
                double r = Operation.Formula(a);
                Console.WriteLine("Площадь равностороннего треугольника равна: {0}", r);
            }
            else
            {
                double s = Operation.Formula(a, b, c);
                Console.WriteLine("Площадь треугольника равна: {0}", s);
            }
        }
    }
}
