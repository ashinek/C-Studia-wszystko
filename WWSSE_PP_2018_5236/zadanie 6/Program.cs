using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = "";
            Console.WriteLine("Program pokaże dla podanej przez Ciebie liczby całkowitej dodatniej reprezentację binarną");
            string liczba = Console.ReadLine();
            int liczbalicz = int.Parse(liczba);
            int reszta;
            while (liczbalicz > 0)
            {
                reszta = liczbalicz % 2;
                liczbalicz /= 2;
                bin = reszta.ToString() + bin;
            }
            Console.WriteLine(bin);
        }
    }
}
