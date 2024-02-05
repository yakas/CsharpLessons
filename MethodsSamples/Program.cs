using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sonuc=KaresiniAl(2);// verilen sayinin karesini alan method
            Console.WriteLine("verilen sayinin karesi :"+sonuc);
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////
            string sonucTekmiCiftmi = TekmiCiftmi(4);// sayinin tekmi ciftmi oldugunu bulan method
            Console.WriteLine("verilen sayi :"+sonucTekmiCiftmi);
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////
            BuyukmuKucukmuBul(9846,345);

        }
        ////////////////////////////////////////////////////////////////////////
        static double KaresiniAl(double sayi1)
        {
            double sayininKaresi = Math.Pow(sayi1,sayi1);// verilen sayinin karesini al
            return sayininKaresi;
        }

        ////////////////////////////////////////////////////////////////////////
        static string TekmiCiftmi(int sayi)
        {
            string sonuc="";
            if (sayi % 2 == 0)
            {
                return sonuc = "sayi cift";
            }
            else
            {
                return sonuc = "sayi tek";
            }

        }
        ////////////////////////////////////////////////////////////////////////
        static void BuyukmuKucukmuBul(int sayi1, int sayi2)
        {
            if(sayi1>sayi2)
            {
                Console.WriteLine(sayi1+" "+sayi2+"'den buyuktur");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(sayi2+" "+sayi1+"'den buyuktur.");
                Console.ReadKey();
            }
        }
    }
}
