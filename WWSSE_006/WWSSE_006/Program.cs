using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWSSE_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] a = new Double[100];
            
            int n;
            
            //5x^5+2x^4-x^3+10x^2-2x+6
            //W=an
            //W=Xn+ak
            //k-n-1,...,0
            
            double x;
            
            n = 9;

            a[9] = 1;
            a[8] = 1;
            a[7] = 1;
            a[6] = 1;
            a[5] = 0;
            a[4] = 0;
            a[3] = 1;
            a[2] = 1;
            a[1] = 0;
            a[0] = 1;
            
            x = 2;

            double w;
            w = a[9];

            for (int k = n - 1; k >= 0; k--)
            {
                w = w * x + a[k];
            }
            Console.WriteLine("wartość wielomianu w punkcie {0} jest równa {1}", x, w);
        }
    }
}
