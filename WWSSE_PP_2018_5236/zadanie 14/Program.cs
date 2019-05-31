using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczy sumę podanych przez Ciebie liczb całkowitych, oraz poda ich średnią arytmetyczną");
            Console.WriteLine("Proszę podać interesujące Cię liczby. Każdą liczbę oddziel spacją(przerwą), po wpisaniu interesujących Cię liczb naciśnij enter.");
            //szczytujemy liczby
            string liczby = Console.ReadLine();
            //dzielimy podany ciąg na mniejsze kawałki, a w następnej linii konwertujemy tekst na liczby
            string[] arrLiczby = liczby.Split(' ');
            int[] liczbylicz = Array.ConvertAll(arrLiczby, int.Parse);
            //ustalamy licznik pamiętając, że tablica jest numerowana od zera i dowiadujemy się ile liczb podał użytkownik
            int licznik = 0;
            int iloscLiczb = liczbylicz.Length;
            int suma = 0;
            //dzięki temu, że tablice wywołujemy od 0 warunek jest prosty
            while (licznik < iloscLiczb)
            {
                suma = suma + liczbylicz[licznik];
                licznik++;
            }
            Console.WriteLine("Suma podanych przez Ciebie liczb wynosi {0}", suma);
            double srednia = suma/iloscLiczb;
            Console.WriteLine("Średnia arytmetyczna podanych przez Ciebie liczb wynosi: {0}", srednia);
        }
    }
}
