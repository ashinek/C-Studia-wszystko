using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello ");
            Console.WriteLine("to moj pierwszy program, narazie niewiele potrafi, ale moze sie z Toba przywitac");
            Console.Write("jak sie nazywasz: ");
            string imie = Console.ReadLine();
            Console.Write("ile masz lat {0}?: ", imie);
            string wiek = Console.ReadLine();
            Console.WriteLine("Czesc {0}, masz {1}lat. Milo Cie poznac. Poki co nie potrafie za wiele, ale mam nadzieje, ze z czasem naucze sie dodatkowych rzeczy", imie, wiek);
            Console.WriteLine("Do zobaczenia " + imie + "!");
        }
    }
}
