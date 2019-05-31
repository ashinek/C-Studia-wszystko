using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzi czy podana przez Ciebie liczba całkowita jest liczbą pierwszą");
            Console.Write("Podaj liczbę którą chcesz sprawdzić: ");
            string liczba = Console.ReadLine();
            int liczbalicz = int.Parse(liczba);
            int jest = 0;

            if (liczbalicz <= 2)
            {
                Console.WriteLine("liczba {0} nie jest liczbą pierwszą", liczba);
            }
            for (int i = 2; i * i <= liczbalicz; i++)
            {
                if (liczbalicz % i == 0)
                {
                    Console.WriteLine("liczba {0} nie jest liczbą pierwszą",liczba);
                    break;
                }
                else
                {
                    jest = 1;
                }
            }
            if (jest == 1)
            {
                Console.WriteLine("liczba {0} jest liczbą pierwszą", liczba);
            }
        }
    }
}
