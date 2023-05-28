using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static double Func(double x)
        {
            return Math.Pow(x, 5) - 3.5 * x + 0.55;
        }
        static double Func1(double x)//производная
        {
            return 5 * Math.Pow(x, 4) - 3.5;
        }
        static double Func2(double x)//производная
        {
            return 20 * Math.Pow(x, 3);
        }

        static void Main(string[] args)
        {
            int m = 4;
            double x;
            double a = 3 + 0.1 * m;
            double b = 0.4 + 0.03 * m;
            double exp = Math.Pow(10, -4);
            int k;
            double p = Func(a) * Func2(a);
            double p1 = Func(b) * Func2(b);
            if (p > 0)
            {
                x = a;
            }
            else
            {
                if (p1 > 0)
                {
                    x = b;
                }
                else
                {
                    x = -10E10;

                }
            }
            if (x > -10E10)
            {
                k = 0;
                while (Math.Abs(Func(x)) > exp)
                {
                    x = x - Func(x) / Func1(x);
                    k++;

                }
                Console.WriteLine("Корень х =" + x);
                Console.WriteLine(k);

            }
            Console.ReadKey();
        }
    }
}
