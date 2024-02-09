using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerilenRakaminBasamaklariKüpüToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen 3 basamakli bir sayinin basamaklarin küplerinin toplami
            // sayinin kendisine eşit olup olmadigini bulan bir program yaziniz. 

            Console.Write("üc basamakli bir sayi giriniz:");
            string sayiText = Console.ReadLine();
            if (sayiText.Length != 3)
            {
                Console.WriteLine("girilen sayi 3 basamakli degildir..");
                Console.ReadLine();

            }
            else
            {
                int basamak = 0;
                int sayiInt=int.Parse(sayiText);
                int _sayi = sayiInt;
                int basamakKup=0;
                int basamakKupToplam = 0;
                for (int i = 1; i <= sayiText.Length; i++)
                {
                    basamak=_sayi % 10; // 123%10 = kalan 3 ve ilk basamak bulundu
                    _sayi /= 10;//sayiyi 10'a bölerek geri kalan kısmını yine kendine atiyoruz.
                                //ilk sayımız 123 iken 123/10=12 sayimiz 12 oldu
                    basamakKup =Convert.ToInt32(Math.Pow(basamak, 3));
                    basamakKupToplam += basamakKup;// basamaklarin küpleri toplami
                    
                }

                if (basamakKupToplam == sayiInt)
                {
                    Console.WriteLine("Sayinin basamaklarinin küpleri toplamı "+basamakKupToplam+" kendisine "+sayiInt+" esitdir.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sayinin basamaklarinin küpleri toplamı "+basamakKupToplam+" kendisine "+sayiInt+" esit degildir.");
                    Console.ReadLine();
                }
            }



        }
    }
}
