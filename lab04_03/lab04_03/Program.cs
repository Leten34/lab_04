using System;

namespace lab04_03
{
    class Utils
    {
        public static bool Factorial(int n, out int answer)
        {
            int k; // Loop counter
            int f = 1; // Working value
            bool ok = true;
            try
            {
                checked
                {
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {

                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int f;
            bool ok;
            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if(ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
}
