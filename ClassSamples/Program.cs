using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Araba araba1 = new Araba();      // araba class'dan yeni bir araba objesi olusturdum.Burada Araba() metodunu calistirir.Derleyici sagdan calisir.
                                             // ilk olarak Araba() metodu calistirilir.
            

            araba1.arabaModel = "Renault";
            araba1.arabaRengi = "Beyaz";
            araba1.kapiSayisi = 4;
            araba1.KapilariKapat();
            araba1.MotoruCalistir();
            */

            Araba araba2 = new Araba("Renault", "beyaz", 4);// bu sekilde Contructor metoda parametre gonderiyoruz.
            Console.WriteLine(araba2.arabaModel);
            Console.WriteLine(araba2.arabaRengi);
            Console.WriteLine(araba2.kapiSayisi);



        }
    }
}
