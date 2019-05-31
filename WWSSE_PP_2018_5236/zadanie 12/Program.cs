using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program pokaże kolejno liczby z ciągu Fibonacciego, do pozycji, która Cię interesuje");
            Console.WriteLine("Podaj proszę maksymalną pozycję ciągu jaka Cię interesuje");
            string liczba = Console.ReadLine();
            int liczbalicz = int.Parse(liczba);
            int pierwsza = 0;
            int druga = 1;
            int buf;
            int licznik = 2;
            //jeżeli interesuje nas tylko jedna liczba z ciągu
            if (liczbalicz == 1)
            {
                Console.WriteLine("Liczby w podanym przez Ciebie ciągu to: \n0");
            }
            else
                //Najwygodniej było wypisać ręcznie pierwsze dwie wartości, a później posługiwać  się zmiennymi
            {
                Console.WriteLine("Liczby w podanym przez Ciebie ciągu to: \n0 \n1");
                while (licznik < liczbalicz)
                {
                    buf = druga;
                    druga = druga + pierwsza;
                    pierwsza = buf;
                    Console.WriteLine(druga);
                    licznik++;
                }
            }
        }
    }
}
