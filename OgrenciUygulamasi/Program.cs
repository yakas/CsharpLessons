using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(23, "yakup", "atalay", 55, 78, 65, "Karadeniz Teknik Universitesi");
            
            bool kontrol = true;
            
            
                

                while (kontrol)
                {
                Console.WriteLine("Uygulamaya Hos Geldiniz");
                Console.WriteLine("Yapmak istediginiz islemi seciniz");
                
                Islemler();

                int secim = int.Parse(Console.ReadLine());
               

                switch (secim)
                    {
                        case 1:
                            Console.WriteLine();
                            ogr1.OgrenciBilgileriGoster();
                            Console.WriteLine("----------------------------------------------------------");
                        break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Ogrencinin not ortalaması:"+ogr1.OgrenciOrtalamasiBul());
                            Console.WriteLine("----------------------------------------------------------");
                        break;
                        case 3:
                            Console.WriteLine();
                            ogr1.OgrenciOkulAd();
                            Console.WriteLine("----------------------------------------------------------");
                        break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Uygulamadan cikiliyor.");
                            Console.WriteLine("----------------------------------------------------------");
                        kontrol = false;
                            break;
                        default:
                            Console.WriteLine("Hatalı secim yaptınız:");
                            Console.WriteLine("----------------------------------------------------------");

                        break;
                    }
                }






        }

        static void Islemler()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1- Ogrenci Bilgilerini Goster");
            Console.WriteLine("2- Ogrenci Ortalamasini Goster");
            Console.WriteLine("3- Ogrenci Okulunu Goster");
            Console.WriteLine("4- Uygulamadan Cıkıs");
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
