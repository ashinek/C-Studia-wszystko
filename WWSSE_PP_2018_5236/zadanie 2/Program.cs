using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczbaDane1;
            string liczbaDane2;
            Console.WriteLine("Program poprosi Cię o podanie dwóch liczb całkowitych i porówna je");
            Console.WriteLine("Podaj pierwszą liczbę całkowitą");
            liczbaDane1 = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę całkowitą");
            liczbaDane2 = Console.ReadLine();
            int liczbaOblicz1 = int.Parse(liczbaDane1);
            int liczbaOblicz2 = int.Parse(liczbaDane2);
            if (liczbaOblicz1 > liczbaOblicz2)
            {
                Console.WriteLine("Pierwsza liczba jest większa od drugiej: {0} > {1}, są one różne od siebie", liczbaDane1, liczbaDane2);
            }
            else
            {
                if (liczbaOblicz1 < liczbaOblicz2)
                {
                    Console.WriteLine("Pierwsza liczba jest mniejsza od drugiej: {0} < {1}, są one różne od siebie", liczbaDane1, liczbaDane2);
                }
                else
                {
                    if (liczbaOblicz1 == liczbaOblicz2)
                    {
                        Console.WriteLine("Obie liczby całkowite są sobie równe: {0} = {1}", liczbaDane1, liczbaDane2);
                    }
                }
            }
        }
    }
}
