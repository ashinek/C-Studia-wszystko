
using System;

namespace Euklides
//Program oblicza największą wspólną wielokrotność dla przekazanych parametrów w linii polecenia (dwie liczby całkowite)//
{

    class Euklides
    {

        int a, b, nw, nd;

        Euklides(int _a, int _b)
        {

            a = _a;
            b = _b;
        }

        int nwd()
        {

            int x = a, y = b;

            while (x != y)
            {

                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            nd = x;
            return nd;
        }

        int nww()
        {

            nw = Math.Abs(a * b) / nd;
            return nw;
        }

        public static void Main(string[] args)
        {

            int a, b;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Euklides wynik = new Euklides(a, b);

            Console.WriteLine("Program oblicza największa wspólna wielokrotność dla przekazanych parametrów w linii polecenia (dwie liczby całkowite)");
            Console.WriteLine();
            Console.WriteLine("NWD = " + wynik.nwd());
            Console.WriteLine("NWW = " + wynik.nww());


        }

    }
}