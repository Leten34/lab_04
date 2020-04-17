using System;

namespace lab04_05
{
    class Funct
    {
        public static double Myroot(double a, double b, double c,  ref double x1, ref double x2)
        {
            double d = b*b - 4*a*c;
            if (d < 0)
            {
                return -1;
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return 0;
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1 = 0;
            double x2 = 0;
            Console.WriteLine("Введите первое число:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            c = double.Parse(Console.ReadLine());
            double k = Funct.Myroot(a, b, c, ref x1, ref x2);
            if (k < 0)
            {
                Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет.");
            }
            else if (k == 0)
            {
                Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c } равен x1 = x2 = {x1}");
            }
            else if (k == 1)
            {
                Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны x1 = {x1}, x2 = {x2}");
            }
               
        }
    }
}
