using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE2018_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //obliczenie pierwiastka kwadratowego bez użycia unkcji sqr
            double a=2; //liczba, której pierwiastka szukamy
            double x1 = 0; //początek przedziału poszukiwań
            double x2 = a+1; //koniec przedziału poszukiwań
            double eps = 0.00001;

            if (funkcja(x1, a) * funkcja(x2, a) < 0)
            {
                int licznik = 0;
                while (Math.Abs(x1-x2) > eps)
                {
                    double x3 = (x1+x2)/2;
                    if (funkcja(x1, a) * funkcja(x3, a) < 0)
                    {
                        x2=x3;
                    }
                    else
                    {
                        x1=x3;
                    }
                    licznik++;
                    Console.WriteLine("Licznik = {3}, x1={0}, x2={1}, róźnica = {2}", x1, x2, Math.Abs(x1 - x2), licznik);
                }
            }
            else
            {
                Console.WriteLine(" w tym przedziale nie ma pewności istnienia pierwiastka - wybierz inny przedział");
            }

        }
        static Double funkcja(Double x, Double a)
        {
            Double wynik = x*x-a;

            return wynik;
        }
    }
}
