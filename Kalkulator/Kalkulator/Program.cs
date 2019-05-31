using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w pierwszym kalkulatorze. Proszę o wybranie zadania jakie chcesz wykonać");
            Console.WriteLine("Wpisz działanie jakie chcesz wykonać: Dodawanie(1), Odejmowanie(2), mnożenie(3), dzielenie(4)");
            string znak = Console.ReadLine();
            Console.WriteLine("wybierz pierwszą liczbę");
            string liczba = Console.ReadLine();
            int a = int.Parse(liczba);
            Console.WriteLine("wybierz drugą liczbę");
            liczba = Console.ReadLine();

            int b = int.Parse(liczba);
            int dzialanie = int.Parse(znak);
            Console.WriteLine(a + b);
            Console.WriteLine("ASD");
            if (dzialanie==1)
                {
                Console.Write("{0}{1}{2}"a , znak , b , a + b); 
                }
        }
    }
}