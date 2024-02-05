using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodUsage
{
    internal class Personnel
    {
        /*public void NameSurnameWrite()   static olmayan metodlarda ancak yeni bir nesne olusturup erisim yapabiliriz.
        {
            Console.WriteLine("Yakup Atalay");
        }*/

        public static void NameSurnameWrite() // ayni metodu sadece static yaptık.Bu sekilde Main metod'dan
                                              // Personnel class'daki NameSurnameWrite() metoduna direk
                                              // Personnel.NameSurnameWrite() yazarak erisebiliriz.
                                              // static ifadesi eklendiginde degiskenler ve metodlar direk class üzerinden
                                              //erisilebilir duruma gelir.
        {
            Console.WriteLine("Yakup Atalay");
        }
    }
}
