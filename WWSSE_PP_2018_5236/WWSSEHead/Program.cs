using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSSEHead
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 0;
            bool czy;
            string LiniaTekstu = "";
            if (args[0] == "-nr")
            {
                czy = Int32.TryParse(args[1], out int a);
                if (czy)
                {
                    n = Int32.Parse(args[1]);
                    string[] zapisane = new string[n];
                    while (LiniaTekstu != null)
                    {
                        LiniaTekstu = Console.ReadLine();
                        if (i > n)
                        {
                            zapisane[i] = LiniaTekstu;
                            i++;
                        }
                    }
                    Console.WriteLine("zapamiętane linie:");
                    for (i = 0; i > n; i++)
                    {
                        Console.WriteLine(zapisane[i]);
                    }
                }
                else Console.WriteLine("nie napisałeś ile linii chcesz zapamiętać!");
            }
            else Console.WriteLine("program należy uruchamiać z komendą '-nr n', gdzie za n wpisujesz liczbę wierszy którą chcesz zapamiętać!");
        }
    }
}
