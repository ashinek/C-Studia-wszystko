using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rozpoczęcie programu
            Console.WriteLine("Program przekonwertuje liczbę dodatnią całkowitą na postać szesnastkową.\n");
            Console.WriteLine("Podaj liczbę: ");
            long liczbabin = long.Parse(Console.ReadLine());

            string liczbaHex = "";

            //pętla
            while (liczbabin != 0)
            {
                long remain = liczbabin % 16;

                //przypisanie wartości literowej dla liczby
                switch (remain)
                {
                    case 10:
                        liczbaHex = "A" + liczbaHex;
                        break;
                    case 11:
                        liczbaHex = "B" + liczbaHex;
                        break;
                    case 12:
                        liczbaHex = "C" + liczbaHex;
                        break;
                    case 13:
                        liczbaHex = "D" + liczbaHex;
                        break;
                    case 14:
                        liczbaHex = "E" + liczbaHex;
                        break;
                    case 15:
                        liczbaHex = "F" + liczbaHex;
                        break;
                    default:
                        liczbaHex = remain + liczbaHex;
                        break;
                }
                liczbabin /= 16;
            }

            //wynik
            Console.WriteLine("Wynik = " + liczbaHex);
        }
    }
}