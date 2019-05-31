using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSESort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,int> lista = new SortedList<string,int>();
            int pozycja = 0;
            string liniaTekstu = "";
            while (liniaTekstu != null)
            {
                liniaTekstu = Console.ReadLine();
                if (liniaTekstu != null)
                {
                    if (lista.ContainsKey(liniaTekstu))
                    {
                        pozycja = lista.IndexOfKey(liniaTekstu);
                        lista[liniaTekstu]++;
                    }
                    else
                    {
                        lista.Add(liniaTekstu, 1);
                    }
                }
            }

            for (int k = 0; k < lista.Count; k++)
            {
                for (int j = 0; j < lista.Values[k]; j++)
                {
                    Console.WriteLine(lista.Keys[k]);
                }
            }
        }
    }
}
