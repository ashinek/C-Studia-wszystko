using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE_2018_Funkcje_i_Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; //ilość wierszy`
            int m = 3; //ilość kolumn
            double[,] t = new double[5, 3] { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 }, { 4, 4, 4 }, { 5, 5, 5 } };
            double[,] w = new double[n, m];
            //macierzWczytaj(t, n, m);
            w = macierzTrojkatnaGorna(t,n,m);
            macierzPokaz(t, n, m);
            macierzPokaz(w, n, m);
            Console.WriteLine("+++++++++++++++++++++");
            macierzTrojkatnaGorna2(t, 5, 3);
            macierzPokaz(t, n, m);
        }
        static double[,] macierzTrojkatnaGorna(double[,] m, int iloscWierszy, int iloscKolumn)
        {
            double[,] wynik = new double[iloscWierszy, iloscKolumn];
            for (int k = 0; k<iloscWierszy;k++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    if(k>j)
                    {
                        wynik[k,j]=0;
                    }
                    else
                    {
                        wynik[k, j] = m[k, j];
                    }
                }
            }
            return wynik;
        }
        static void macierzTrojkatnaGorna2(double[,] m, int iloscWierszy, int iloscKolumn)
        {
            double[,] wynik = new double[iloscWierszy, iloscKolumn];
            for (int k = 1; k < iloscWierszy; k++)
            {
                for (int j = Math.Max(0,iloscKolumn-k); j < iloscKolumn; j++)
                {
                        m[k, j] = 0;
                }
            }
        }
        static void macierzPokaz(double[,] m, int iloscWierszy, int iloscKolumn)
        {
            for (int k = 0; k < iloscWierszy; k++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    Console.Write("{0}, ", m[k, j]);
                }
                Console.WriteLine();
            }
        }
        static void macierzWczytaj(double[,] m, int iloscWierszy, int iloscKolumn)
        {
            for (int k = 0; k < iloscWierszy; k++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    Console.Write("A[{0}],[{1}] = ",k,j);
                    m[k,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
