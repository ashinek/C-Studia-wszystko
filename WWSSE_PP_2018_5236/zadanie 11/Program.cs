using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program pokaże kolejno liczby z ciągu Fibonacciego, mniejsze od podanej przez Ciebie wartości");
            Console.WriteLine("Podaj proszę maksymalną pozycję ciągu jaka Cię interesuje");
            string liczba = Console.ReadLine();
            int liczbalicz = int.Parse(liczba);
            int pierwsza = 0;
            int druga = 1;
            int buf;
            Console.WriteLine("Liczby w podanym przez Ciebie ciągu to: \n0 ");
            while (druga < liczbalicz)
            {
                Console.WriteLine(druga);
                buf = druga;
                druga = druga + pierwsza;
                pierwsza = buf;
            }
            Console.WriteLine("");
        }
    }
}
