using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 adet erisim belirleyici vardır.  Bunlar public---private---protected---internal
            // metodlara degiskenlere veririlirler.
            Musteri musteri1 = new Musteri("ali", "e", 51, 30000);
            musteri1.MusteriBilgileriYaz();
            //musteri1.maas bilgisine bu class tan ulasamiyorum.Cunku maas degiskeni private erisim belirleyicisiolarak  ayarlandi.

        }
    }
}
