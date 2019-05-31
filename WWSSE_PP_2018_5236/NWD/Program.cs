using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 0;
            int liczba2 = 0;
            int buff = 0;

            Console.WriteLine("Program obliczy największy wspólny dzielnik dwóch podanych przez Ciebie liczb całkowitych.");
            Console.WriteLine("Podaj pierwszą liczbę");
            while (Int32.TryParse(Console.ReadLine(), out liczba1) == false)
            {
                Console.WriteLine("Nie podałeś liczby całkowitej! Spróbuj ponownie");
            }
            Console.WriteLine("Podaj drugą liczbę:");
            while (Int32.TryParse(Console.ReadLine(), out liczba2) == false)
            {
                Console.WriteLine("Nie podałeś liczby całkowitej! Spróbuj ponownie");
            }

            if (liczba1 >= liczba2)
            {
                if (liczba1%liczba2==0)
                {
                    Console.WriteLine("Największym wspólnym dzielnikiem liczby {0} i {1}, jest: {1}",liczba1,liczba2);
                }
                else if (liczba2%liczba2!=0)
                {
                    while (liczba1%liczba2!=0)
                    {
                        buff = liczba1 % liczba2;
                        liczba1 = liczba2;
                        liczba2 = buff;
                    }
                    Console.WriteLine("Największym wspólnym dzielnikiem liczb {0} i {1}, jest {2}",liczba1, liczba2, buff);
                }
            }
            if (liczba1<liczba2)
            {
                if (liczba2 % liczba1 == 0)
                {
                    Console.WriteLine("Największym wspólnym dzielnikiem liczby {0} i {1}, jest: {0}", liczba1, liczba2);
                }
                else if (liczba2 % liczba1 != 0)
                {
                    while (liczba2 % liczba1 != 0)
                    {
                        buff = liczba2 % liczba1;
                        liczba2 = liczba1;
                        liczba1 = buff;
                    }
                    Console.WriteLine("Największym wspólnym dzielnikiem liczb {0} i {1}, jest {2}", liczba1, liczba2, buff);
                }
            }
        }
    }
}
