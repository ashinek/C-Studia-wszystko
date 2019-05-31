using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwsese2018_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //pierwsze zmienne
            string nazwiskoNauczyciela = "Nowak";
            string nazwiskoUcznia = "Kowalski";
            int numer = 0;
            int n, m;

            n = 2;
            m = 3;
            numer = 2 * n + m;
            Console.WriteLine("wynik wyrażenia 2*n+m dlan = {0} oraz m = {1} jest równy {2}", n, m, numer);
            
            Console.WriteLine("Długość nazwiska {0} jest równa {1}",nazwiskoNauczyciela,nazwiskoNauczyciela.Length);
            Console.WriteLine("Długość nazwiska {0} jest równa {1}", nazwiskoUcznia,nazwiskoUcznia.Length);
            
            Console.WriteLine(nazwiskoNauczyciela.ToUpper());
            Console.WriteLine(nazwiskoUcznia.ToLower());


        }
    }
}
