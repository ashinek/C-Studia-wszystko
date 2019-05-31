using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSENWW
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            if (args.Length > 2)
            {
                Console.WriteLine("podałeś więcej niż dwie wartości! Podaj maksymalnie dwie liczby całkowite!");
            }
            else
            {
                if (Int32.TryParse(args[0], out a) == true && Int32.TryParse(args[1], out b) == true)
                {
                    int c = NWD(a, b);
                    int NWW = (a * b) / c;
                    Console.WriteLine("NWW podanych liczb: a={0} i b={1} jest równe {2}", a, b, NWW);
                }
                else
                {
                    Console.WriteLine("nie podałeś liczb! Nie można obliczyć NWW. Proszę podać dwie liczby całkowite!");
                }
            }
        }
        static int NWD(int a, int b)
        {
            #region normalizacja par sposób 1
            if (a < 0)
            {
                a = -a;
            }
            if (b < 0)
            {
                b = -b;
            }
            #endregion
            #region normalizacja par sposób 2
            a = Math.Abs(a);
            b = Math.Abs(b);
            #endregion
            #region Algorytm Euklidesa
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            #endregion
            return a;
        }
    }
}
