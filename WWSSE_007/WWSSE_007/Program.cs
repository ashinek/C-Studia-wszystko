using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE_007
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = funckjaKwadratowa(2, 3, 1, 0);
            Console.WriteLine("1) Wartość wielomianu jest równa {0} ", w);
            double a2 = 4;
            double a1 = 2;
            double a0 = 5;
            w = funckjaKwadratowa(a2, a1, a0, 2);
            Console.WriteLine("2) Wartość wielomianu jest równa {0} ", w);
            w = funckjaKwadratowaHorner(2, 3, 1, 0);
            Console.WriteLine("3) Wartość wielomianu jest równa {0} ", w);
            w = funckjaKwadratowaHorner(a2, a1, a0, 2);
            Console.WriteLine("4) Wartość wielomianu jest równa {0} ", w);

            int a = 2;
            int b = 4;
            int w1 = SumaOp1(a, b);
            Console.WriteLine("Przekazywnaie przez wartości: a={0}, b={1}, w1={2}", a, b, w1);

            int c = 2;
            int d = 4;
            int w2 = SumaOp2(ref c, ref d);
            Console.WriteLine("Przekazywnaie przez wartości: a={0}, b={1}, w2={2}", c, d, w2);

        }

        static double funckjaKwadratowa(double a, double b, double c, double x)
        {
            double wynik = a * x * x + b * x + c;
            return wynik;
        }
        static double funckjaKwadratowaHorner(double a, double b, double c, double x)
        {
            double wynik = (a * x + b) * x + c;
            return wynik;
        }

        static int SumaOp1(int x, int y)
        {
            x++;
            y++;
            return x + y;
        }
        static int SumaOp2(ref int x, ref int y)
        {
            x++;
            y++;
            return x + y;
        }
    }
}
