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
            string[] zapisane = new string[Int32.Parse(args[1])];
            int i = 0;
            bool czy;
            string LiniaTekstu = "";
            if (args[0] == "-nr")
            {
                Console.WriteLine(args[1]);
                czy = Int32.TryParse(args[1], out int a);
                if (czy)
                {
                    n = Int32.Parse(args[1]);
                    
                    while (LiniaTekstu != null)
                    {
                        LiniaTekstu = Console.ReadLine();
                        if (i < n)
                        {
                            zapisane[i] = LiniaTekstu;
                            i++;
                        }
                    }
                    i = 0;
                    Console.WriteLine("zapamiętane linie:");
                    for (int k=0; k < n; k++)
                    {
                        Console.WriteLine(zapisane[k]);
                    }
                }
                else Console.WriteLine("nie napisałeś ile linii chcesz zapamiętać!");
            }
            else Console.WriteLine("program należy uruchamiać z komendą '-nr n', gdzie za n wpisujesz liczbę wierszy którą chcesz zapamiętać!");
        }
    }
}
