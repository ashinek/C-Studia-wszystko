using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //wyświetlamy ilość cyfr
            string liczba = "";
            int iloscznakow = 0;
            Console.WriteLine("Podaj liczbę całkowitą, program poda ilość cyfr jakie posiada");
            liczba = Console.ReadLine();
            int liczbalicz = int.Parse(liczba);
            //Próbowałem zrobić to z pętlą, ale przy liczbach zakończonych zerem pokazywał jedną cyfrę mniej i
            //znalazłem komendę do liczenia znaków w stringu co uznałem za dużo łatwiejsze rozwiązanie i szybsze
            if (liczbalicz >= 0)
            {
                iloscznakow = liczba.Length;
            }
                //jeżeli liczba jest ujemna kod policzyłby minus jako znak, tak więc musimy pomniejszyć ilość cyfr o 1
            else
            {
                iloscznakow = liczba.Length-1;
            }
            // zapis taki bo program się wykrzacza jeżeli używam zmiennych liczbowych w jednej komendzie, pewnie da się to ominąć
            //łatwiej mi jednak rozbić na kilka komend
            Console.Write("liczba, którą podałeś ({0}) posiada ",liczba);
            Console.Write(iloscznakow);
            Console.WriteLine(" cyfry");
        }
    }
}
