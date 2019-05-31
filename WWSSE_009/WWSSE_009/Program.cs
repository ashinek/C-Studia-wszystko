using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE_009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilość parametrów: {0}", args.Length);
            if (args.Length > 0)
            {
                Console.WriteLine(args);
            }
            int licznik=0;
            string s;
            do
            {
                s=Console.ReadLine();
                if (s != null)
                {
                    licznik++;
                }
            }
            while (s != null);
            Console.WriteLine(licznik.ToString());
        }
    }
}
