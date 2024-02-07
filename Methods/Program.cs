using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //**************************************************************************************************************
            //  METODLARIN GENEL YAPISI ASAGIDAKI GIBIDIR.
            //
            //  erisim belirleyicisi + geri dönüş tipi + metod adı ()
            //  {
            //    işlemler
            //  }
            
            
            Hello();// deger dondurmeyen method

            int carpiSonucu=VerilenIkiSayiyiCarp(3, 2); // deger donduren method
            carpiSonucu = (carpiSonucu * 100) / 2;
            Console.WriteLine(carpiSonucu);
            Console.ReadKey();

        }
        
        ///////////////////////////////////////////////////////////////////////////
        
        static void Hello()
        {
            Console.Write("Hello everone");
            Console.ReadKey();
        }
        
        ///////////////////////////////////////////////////////////////////////////
        

        static int VerilenIkiSayiyiCarp(int sayi1,int sayi2)
        {
            int carpim=sayi1*sayi2;
            Console.WriteLine("iki sayinin carpimi: "+carpim);
            Console.ReadKey();
            return carpim;
        }
    }

}
