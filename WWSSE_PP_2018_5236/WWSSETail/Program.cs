using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSSETail
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("nie podałeś argumentu przy uruchamianiu programu! Pamiętaj, żeby rozpocząć program musisz wpisać -nr, oraz podać ilość linii jakie chcesz zapisać i wyświetlić ponownie!!");
            }
            else
            {
                bool czy;
                czy = Int32.TryParse(args[1], out int a);
                if (czy)
                {

                    int n;
                    string[] zapisane = new string[Int32.Parse(args[1])];
                    int i = 0;

                    string LiniaTekstu = "";
                    if (args[0] == "-nr")
                    {
                        czy = Int32.TryParse(args[1], out int b);
                        if (czy)
                        {
                            //wczytanie ilości linii
                            n = Int32.Parse(args[1]);

                            while (LiniaTekstu != null)
                            {
                                LiniaTekstu = Console.ReadLine();
                                //w innym wypadku zapisywało pustą linię
                                if (LiniaTekstu != null)
                                {
                                    zapisane[i] = LiniaTekstu;
                                }
                                //resetowanie licznika
                                if (i == n - 1)
                                {
                                    i = 0;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                            i = 0;
                            Console.WriteLine("zapamiętane linie:");
                            for (int k = 0; k < n; k++)
                            {
                                Console.WriteLine(zapisane[k]);
                            }
                        }
                        else Console.WriteLine("nie napisałeś ile linii chcesz zapamiętać!");
                    }
                }
                else Console.WriteLine("program należy uruchamiać z komendą '-nr n', gdzie za n wpisujesz liczbę wierszy którą chcesz zapamiętać!");
            }
            }
    }
}
