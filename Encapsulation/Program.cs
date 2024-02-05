using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation neden kullanılır.Bazı durumlarda metod icindeki degiskelere kimse erisemesin fakat ben erisebileyim.Bunu encapsulation ile yaparız.
            // Ecapsulation iki sekilde yapılablir.Bunlar Getter -Setter metodlar veya properties ile yapılabilir.


            Ogrenci ogr1 = new Ogrenci();
            /*
            Console.WriteLine("Ogrencinin adi :"+ogr1.ad);     // Ogrenci class'inda "ad" degiskeni public oldugu icin kolaylıkla erisebildim.
            Console.WriteLine("Ogrencinin adi :" + ogr1.ad);  eger "ad" degiskenini private yaparsam buradan ogrenci class'daki "ad" degiskenine ulasamam.
            Main metod'dan Ogrenci class'daki private ad degiskenine ulasmak icin Ogrenci class'da iki adet metod tanimlariz.Bunlar getter ve setter metodlari
            olarak bilinirler.Bu Set ve get metodlarinin olusturduktan sonra Main metod'da iki adet metodu cagirabiliriz.

            */

            ogr1.setAd("yakup");// bu sekilde private ad degiskenine deger atamasi yapabildim.

            string ogrenciAd=ogr1.getAd(); //Ogrenci class'daki get metodu ilede ad degiskenine atadigimiz bilgiyi alip kullanabildik.
            Console.WriteLine("ogrenci adı:"+ogrenciAd);
            Console.ReadLine();


        }
    }
}
