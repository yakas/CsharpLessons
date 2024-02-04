using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public void MotoruCalistir()
        {
            Console.WriteLine("motor calistirildi..");
            Console.ReadLine();
        }

        public void KapilariKapat()
        {
            Console.WriteLine("kapilar kapatildi..");
            Console.ReadLine();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*public Araba() // bu bir yapici yani constructor method'dur.  "ctor"  --> yazarak Constructor metodu kisa yoldan olusturabiliriz.
                        // ilk olarak bu metod calistirilir..
        {

        }
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         Constructor method olusturalim.
         ctor yaziyoruz..
        public Araba()// contructor metod bos olarak geliyor.
        {
            
        }
        bunu main metodtan parametre alacak sekilde ayarlayalim
        */
        public Araba(string _arabaModel,string _arabaRengi,int _kapiSayisi)
        {
            arabaModel = _arabaModel; // alinan parametreleri Araba class'daki degiskenlere atiyoruz.
            arabaRengi= _arabaRengi;
            kapiSayisi=_kapiSayisi;
        }
        
        
    }
}
