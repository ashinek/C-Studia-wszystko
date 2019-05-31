using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSSESort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> LiniaTekstu = new List<string>();
            string LiniaTekstuInp = "";
            while (LiniaTekstuInp!=null)
            {
                LiniaTekstuInp = Console.ReadLine();
                //Console.WriteLine("jak to dziala");
                LiniaTekstu.Add(LiniaTekstuInp);
                //sprawdza jak pobierane sa dane do listy
                //Console.WriteLine(LiniaTekstu[0]);
            }
            //sprawdzało czy wychodzę z pętli:
            //Console.WriteLine("kuniec");
            LiniaTekstu.Sort();
            foreach(string a in LiniaTekstu)
            {
                Console.WriteLine(a);
            }
        }
    }
}
