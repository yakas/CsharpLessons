using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesKullanimiGetAndSetMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1=new Musteri();
            musteri1.kilo1 = 100;// eger buradaki gibi deger atamasi yaparsak set bloklari calisir.
            int musterininKilosu = musteri1.kilo1; // burdaki gibi deger atamasi yapilmaz sadece degiskendeki deger cekilirse get bloklari calisir.
        }
    }
}
