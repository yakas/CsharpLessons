using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*public void method usage
            Personnel p1=new Personnel();
            p1.NameSurnameWrite();
            Console.ReadLine();


             Personnel. yazarak NameSurnameWrite() metoda erisemiyoruz.Ancak class'dan yeni bir nesne olusturarak erisiyoruz
             Cunku Personnel class'daki NameSurnameWrite() metod static degil
            #####################################################################################
            */
            //public static void method usage
             Personnel.NameSurnameWrite();
             Console.ReadLine();

        }
    }
}
