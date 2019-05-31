using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę binarną którą chcesz przekonwertować");
            string liczba = Console.ReadLine();
            double a10 = StrBin2Dec(liczba);
            Console.WriteLine("Dla liczby binarnej {1}, jej reprezentacja dziesiętna to: {0}", a10, liczba);
        }
        static int[] Str2Int(string s)
        {
            int[] wynik;

            char[] temp = s.ToCharArray();
            int dl = temp.Length;
            wynik = new int[dl];

            for (int k = 0; k < dl; k++)
            {
                if (temp[dl-1-k] == '1')
                {
                    wynik[k] = 1;
                }
                else
                {
                    wynik[k] = 0;
                }
            }

            return wynik;
        }

        static double Horner(int[] a, double x)
        {
            int n = a.Length - 1;
            double w = a[n];
            for (int k = n - 1; k >= 0; k--)
            {
                w = w * x + a[k];
            }
            return w;
        }
        static double Bin2Dec(int[] a)
        {
            return Horner(a, 2);
        }
        static double StrBin2Dec(string s)
        {
            return Bin2Dec(Str2Int(s));
        }
    }
}
