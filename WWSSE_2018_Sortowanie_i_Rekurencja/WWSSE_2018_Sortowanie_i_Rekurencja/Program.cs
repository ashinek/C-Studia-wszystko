using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE_2018_Sortowanie_i_Rekurencja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[16]{2,1,8,10,15,12,3,15,8,6,10,3,11,14,1,9};
            TablicaPokaz(tablica, 16);
            Console.WriteLine("++++++++++++");
            Soruj(tablica, 16);
            TablicaPokaz(tablica, 16);
        }

        static int[] Soruj(int[] sortT, int ilosc)
        {
            if (ilosc > 2)
            {
                int[] lewy = kopiuj(sortT,0, ilosc / 2-1);
                int[] prawy = kopiuj(sortT,0, ilosc / 2-1);
                lewy = Soruj(lewy, ilosc / 2);
                prawy = Soruj(prawy, ilosc / 2);
                sortT = scal(lewy, prawy, ilosc / 2);
            }
            else
            {
                if (sortT[1] < sortT[0])
                { 
                    int temp = sortT[0];
                    sortT[0] = sortT[1];
                    sortT[1] = temp;
                }
            }
            return sortT;
        }
        static int[] kopiuj(int[] s, int pierwszy, int ostatni)
        {
            int[] wynik = new int[ostatni - pierwszy + 1];
            for (int k = pierwszy; k <= ostatni; k++)
            {
                wynik[k - pierwszy] = s[k];
            }
            return wynik;
        }
        
        static void TablicaPokaz(int[] tablica, int iloscElementow)
        {
            for (int i=0;i<iloscElementow;i++)
            {
                Console.Write("{0}, ",tablica[i]);
            }
            Console.WriteLine();
        }
        static int[] scal(int[] lewy, int[] prawy, int ilosc)
        {
            int[] wynik = new int[ilosc * 2];
            int pWynik = 0;
            int lWynik = 0;
            int pPrawy = 0;
            int pLewy = 0;
            for (pLewy = 0; pLewy < ilosc; pLewy++)
            {
                if (lewy[pLewy] <= prawy[pPrawy])
                {
                    wynik[pWynik] = lewy[lWynik];
                    pLewy++;
                }
                else
                {
                    wynik[pWynik] = prawy[pPrawy];
                    pPrawy++;
                }
            }
            return wynik;

        }
    }



}
