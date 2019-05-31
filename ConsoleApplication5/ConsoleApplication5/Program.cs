using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program obliczy sumę wszystkich liczb znajdujących się w podanym przez Ciebie przedziale");
            Console.WriteLine("Podaj pierwszą liczbę");
            string liczba1 = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę");
            string liczba2 = Console.ReadLine();
            int liczba1licz = int.Parse(liczba1);
            int liczba2licz = int.Parse(liczba2);
            int buf;
            int suma=0;
            while (liczba1licz < liczba2licz)
            {
                buf = liczba1licz;
                liczba1licz++;
                suma = buf + liczba1licz;
                buf = liczba1licz;
            }
            Console.WriteLine(suma);
        }
    }
}
