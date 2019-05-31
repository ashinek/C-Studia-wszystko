using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSECount
{
    class Program
    {
        static void Main(string[] args)
        {
            string liniaTekstu = "";
            string tekstBiezacy = "";
            int licznik = 0;

            while(liniaTekstu != null)
            {
                liniaTekstu = Console.ReadLine();
                if (licznik == 0)
                {
                    licznik++;
                    tekstBiezacy = liniaTekstu;
                }
                else if (liniaTekstu == tekstBiezacy)
                {
                    licznik++;
                }
                else
                {
                    Console.WriteLine("{0} : {1}", tekstBiezacy, licznik);
                    tekstBiezacy = liniaTekstu;
                    licznik = 1;
                }
            }
        }
    }
}
