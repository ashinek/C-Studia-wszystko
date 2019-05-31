using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program policzy sumę kolejnych liczb nieparzystych");
            Console.WriteLine("Podaj najwyższą wartość z liczb dodatnich całkowitych, które chcesz dodać");
            string liczba = Console.ReadLine();
            int liczbalicz = int.Parse(liczba);
            int zmienna = 1;
            int suma=0;

            //rozpoczęcie pętli, która będzie sprawdzać wszysktie liczby począwszy od 1
            while (zmienna <= liczbalicz )
            {
                if (zmienna % 2 == 0)
                {
                    zmienna++;
                }
                else
                {
                    suma = suma + zmienna;
                    zmienna++;
                }
            }
            Console.Write("suma wszystkich kolejnych liczb nieparzystych, aż do liczby: {0} wynosi: ",liczba);
            Console.WriteLine(suma);
        }
    }
}
