using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wczyta wpisane przez Ciebie znaki i zmieni je na duże litery");
            string tekst = Console.ReadLine();
            Console.WriteLine(tekst.ToUpper());
        }
    }
}
