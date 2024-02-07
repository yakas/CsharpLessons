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
            // Property dedigimiz kavram olusturmus oldugumuz class'larda belirledigimiz fieldlara
            // dısardan direk olarak deger atama ve goruntuleme yapılmasını ıstemedigimiz durumlarda kullanılır.
            // Bir programcı olusturmus oldugu class icinde tanımlamıs oldugu field'lara dısardan müdehale edilmesini istemez.
            // Bu fieldlara dolaylı yoldan ulaşılmasını ayarlayabilir.Bunun icin property get ve set metodları kullanılır.
            Musteri musteri1=new Musteri();
            musteri1.kilo1 = 100;// eger buradaki gibi deger atamasi yaparsak set bloklari calisir.
            int musterininKilosu = musteri1.kilo1; // burdaki gibi deger atamasi yapilmaz sadece degiskendeki deger cekilirse get bloklari calisir.
        }
    }
}
