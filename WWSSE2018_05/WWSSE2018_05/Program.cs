using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE2018_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //pętle
            string znak = "x";
            int iloscWierszy = 15;
            string napis = "";


            for (int k = 0; k < iloscWierszy; k++)
            {
                napis = napis + znak;
                Console.WriteLine(napis);
            }
            Console.WriteLine("8======================)");

            int j = 0;
            napis = "";

            while (j < iloscWierszy)
            {
                napis = napis + znak;
                Console.WriteLine(napis);
                j++;
            }
            double x = 0.1;
            int licznik = 1;
            double eps = 0.00000000001;
            while (Math.Abs(x-2.0)>eps)
            {
                x = x + 0.1;
                Console.WriteLine("licznik = {0}, x = {1}",licznik,x);
                licznik++;
            }

        }
    }
}
