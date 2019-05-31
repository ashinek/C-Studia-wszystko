using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwsse2018_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //program służy do rozwiązywania równań kwadratowych w ciele liczb rzeczywistych
            double a, b, c;
            double delta;
            double x1, x2;

            a = 1;
            b = -6;
            c = 9;

            delta = b*b - 4 * a * c;

            if (delta < 0)
            {
                //brak rozwiązań rzeczywistych 
                Console.WriteLine("Brak rozwiązań rzeczywistych");
            }
            else
            {

            }
            // (1)dwa lub jedno podójne rozwiązanie rzeczywiste
            if (delta > 0)
            {
                //(2)dwa rozwiązania rzeczywiste
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("dwa rozwiązania rzeczywiste {0}, {1}", x1, x2);
            }
            else
            {

            }
            if (delta == 0)
            {
                //(3)jedno podwójne rozwiązanie rzewczywiste
                x1 = -b / (2 * a);
                Console.WriteLine("Jedno rozwiązanie rzeczywiste {0}", x1);
            }
            else
            {
            }
        }
    }
}
