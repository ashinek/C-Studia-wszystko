using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą. Program poinformuje o parzystości liczby.");
            string liczbaUzytkownika = Console.ReadLine();
            int liczbaLiczenie = int.Parse(liczbaUzytkownika);
            if (liczbaLiczenie % 2 == 0)
            {
                Console.WriteLine("podana liczba to: {0} i jest przysta", liczbaUzytkownika);
                }
            else
            {
                Console.WriteLine("podana liczba to: {0} i jest nieparzysta", liczbaUzytkownika);
            }
           }
    }
}
