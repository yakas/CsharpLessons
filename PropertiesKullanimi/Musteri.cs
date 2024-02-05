using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesKullanimiGetAndSetMethods
{
    public class Musteri
    {
        private int kilo; // buradaki kilo degiskeni Main metodda public olsa ise field olarak gozukur.Yalnız private oldugundan Main'de erisilemez.
                          // Buna erismek icin get ve set metodlarini kullanacagiz.

        /* burada property olusturmak icin "prop" yazıp iki kere tab tusuna basılır.asagidaki sekilde get;set parametreleri otomatik eklenir
        
        public int kilo1 { get; set; } // buradaki kilo1 degiskeni ise Main metodda property olarak gozukur ve simgeside  ingiliz anahtar aleti seklindedir.
                                      //eger get;set bloklari acilmaz ise yukaridaki kilo degiskeninden bir farki olmayacaktir.


        */

        public int kilo1
        {
            get
            {
                return this.kilo;// Main metod'da "musteri1.kilo1 = 100;" seklinde almis oldugumuz kilo1 degerini Musteri class'daki kilo degiskenine dondur.
            }

            set
            {
                this.kilo= value;//Main metod'da "musteri1.kilo1 = 100;" seklinde almis oldugumuz kilo1 degerini bu class'daki kilo degiskenine atayacagiz.
            }
        }  

         
    }
}
