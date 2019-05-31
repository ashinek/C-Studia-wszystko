using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //liczymy równanie kwadratowe, akurat przyda się na matematykę...
            string a;
            string b;
            string c;
            Console.WriteLine("Program obliczy równanie kwadratowe z podanych przez Ciebie zmiennych");
            Console.WriteLine("Równanie będie wyglądać tak: ax^2+bx+c=0");
            Console.WriteLine("z podanych przez Ciebie zmiennych obliczymy Deltę i jeżeli będzie nie ujemna podamy pierwiastki");
            Console.WriteLine("Podaj proszę wartość dla zmiennej 'a'");
            a = Console.ReadLine();
            Console.WriteLine("Podaj proszę wartość dla zmiennej 'b'");
            b = Console.ReadLine();
            Console.WriteLine("Podaj proszę wartość dla zmiennej 'c'");
            c = Console.ReadLine();
            Console.Write("Twoje równanie kwadratowe wygląda następujaco: ");
            Console.Write(a);
            Console.Write("x^2+");
            Console.Write(b);
            Console.Write("x+");
            Console.Write(c);
            Console.WriteLine("=0");
            //konwertuję tekst do wartości liczbowych sprecyzuję je dodając do zmiennej fraz licz będą typu double
            double alicz = double.Parse(a);
            double blicz = double.Parse(b);
            double clicz = double.Parse(c);
            double delta;
            delta = (blicz * blicz) - (4 * alicz * clicz);
            Console.Write("Delta z Twojego równania wynosi: ");
            Console.WriteLine(delta);
            //zadeklarowanie pierwiastków
            double x1;
            double x2;
            if (delta > 0)
            {
                //testowane na a=1 b=-4 c=-5
                x1 = (-blicz - Math.Sqrt(blicz * blicz - 4 * alicz * clicz)) / (2 * alicz);
                x2 = (-blicz + Math.Sqrt(blicz * blicz - 4 * alicz * clicz)) / (2 * alicz);
                Console.Write("pierwiastki dla Twojego równania kwadratowego to: x1=");
                Console.Write(x1);
                Console.Write(" x2=");
                Console.WriteLine(x2);
            }
                            //lecimy grubo zagnieżdżamy pętle
            else
            {
                if (delta == 0)
                {
                    //testowanie na a=1 b=6 c=9
                    x1 = -blicz / (2 * alicz);
                    Console.Write("Delta wynosiła zero, więc twoje równanie posiada jedno rozwiązanie: x=");
                    Console.WriteLine(x1);
                }
                else
                {
                    //testowane na a=1 b=2 c=5
                    Console.WriteLine("Twoje równanie posiada deltę mniejszą od zera, więc nie posiada pierwiastków");
                }
            }
        }
    }
}
