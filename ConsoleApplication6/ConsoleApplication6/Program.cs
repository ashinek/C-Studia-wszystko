using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 2;
            int m=n;
            for (int i=0; i<k; i++)
            {
                m = m * (n - i + 1);
            }
            Console.WriteLine(m);
        }
    }
}
