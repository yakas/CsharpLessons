using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor_Kurucu_Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ev1 = new Ev();
            Ev ev2 = new Ev(-1,125,"  lale ",4);
            Console.WriteLine(ev1.EvBilgileriniGetir());
            Console.WriteLine(ev2.EvBilgileriniGetir());
            Console.ReadKey();

        }
    }
}
