using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] kisi = { "ali", "veli", "zafer", "tunc", "mete", "asli", "yakup" };
            Console.WriteLine("kisi array'in uzunlugu :"+kisi.Length);
            Console.ReadKey();

            if (kisi[0].Contains('b'))
            {
                Console.WriteLine("kisiler arrayin " + kisi[0]+" elemani 'b' iceriyormu :"+ kisi[0].Contains('b'));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("kisiler arrayin " + kisi[0] + " elemani 'b' iceriyormu :" + kisi[0].Contains('b'));
                Console.ReadKey();
            }

            if (kisi[0].EndsWith("a"))
            {
                Console.WriteLine("kisi array in 0. elemani a ile bitiyor mu? " + kisi[0].EndsWith("a"));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("kisi array in 0. elemani a ile bitiyor mu? " + kisi[0].EndsWith("a"));
                Console.ReadKey();
            }

            for (int i = 0; i < kisi.Length; i++)
            {
                Console.WriteLine(kisi[i]);
                Console.ReadKey();
            }
            ////////////////////////////////////////////////////////////////////////////
            Console.Write("Kac elemanlık bir dizi istiyorsun: ");
            int diziElemanSayisi = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[diziElemanSayisi];
            for (int i = 0; i < diziElemanSayisi; i++)
            {
                Console.Write("dizin "+i+". elemanini giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());



            }
            /////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < diziElemanSayisi; i++)
            {
                Console.Write(dizi[i]+"\t");
            }
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////////

            string[] city = new string[4];
            city[0] = "ANKARA";
            city[1] = "IZMIR";
            city[2] = "KIRKLARELI";
            city[3] = "EDIRNE";

            foreach (string sehir in city)
            {
                Console.WriteLine(sehir);
            }

            Console.ReadKey();

            /////////////////////////////////////////////////////////////////////////////////
            // kullanıcının girdiği sayi dizide varmı onu bulalım.
            
            int[] sayiDizisi = { 1, 1, 3, 2, 5, 6, 7, 11, 10, 10, 8, 9, 23, 24, 12, 56, 43, 44, 44, 2, 5, 7, 10, 10 };
            Console.Write("bir rakam giriniz :");
            int arananSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girmis oldugunuz "+arananSayi+" sayisi dizide aranmaktadir...");
            int arananSayiKacAdetVar = 0;
            foreach (int  a in sayiDizisi)
            {
                if (a.Equals(arananSayi))
                {

                    arananSayiKacAdetVar += 1;
                    
                    
                }
                
            }

            if (arananSayiKacAdetVar == 0)
            {
                Console.WriteLine("aranan " + arananSayi + " sayisi dizide bulunamamıstır...");
                Console.ReadKey();
            }
            Console.WriteLine("aranan " + arananSayi + " sayisi dizide " + arananSayiKacAdetVar + " adet var.");
            Console.ReadKey();
            
            ///////////////////////////////////////////////////////////////////////////////////////
            // bir string degiskenini diziye aktarmak

            string cumle = "bir devlet adami bu sekilde konusurmu?";
            string[] cumleDizisi = cumle.Split(new char[] { ' ' });
            
            foreach (string kelimeler in cumleDizisi)
            {
                Console.WriteLine(kelimeler);
            }
            Console.ReadKey();
            
            /////////////////////////////////////////////////////////////////////////////////////////
            // Kullanıcıdan 10 adet int deger alan ve asagıda verilenleri yapan bir program yazınız
            //1-Kaç adet tek,çift eleman olduğunu
            //2-Çift degerlerin toplamini,Tek degerlerin toplamini
            //3-Çift olanların toplami tek degerlerin toplamindan buyukse çift sayıların toplami büyüktür yoksa diğerini yazdırsın
            
            //Array sayiDizisi = new int[10];    //Array eşittir dizi.
            //Önemli Array de index operatörü kullanılamaz. sayidizisi[i] olmaz.
            int [] sayiDizisi = new int[10]; //Array eşittir dizi

            int cift = 0, ciftToplam = 0;
            int tek = 0, tekToplam = 0;

            Console.WriteLine("10 adet tam sayi giriniz:");
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write(i+" ci sayiyi giriniz:");
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    cift += 1;
                    ciftToplam += cift;
                }
                else
                {
                    tek += 1;
                    tekToplam += tek;
                }
            }
            Console.WriteLine("tek sayi adeti: "+tek);
            Console.WriteLine("çift sayi adeti: " + cift);

            Console.WriteLine("çift sayilarin toplami: "+ciftToplam);
            Console.WriteLine("tek sayilarin toplami: " + tekToplam);
            Console.WriteLine();
            if (ciftToplam>tekToplam)
            {
                Console.WriteLine("çift sayilarin toplami tek sayilardan büyük");
            }
            else
            {
                Console.WriteLine("tek sayilarrin toplami çift sayilardan büyük");
            }

            Console.ReadKey();
            */

            Array isimler = new string[6];
            isimler.SetValue("Yakup", 0);
            isimler.SetValue("Kazım", 1);
            isimler.SetValue("Şebnem", 2);
            isimler.SetValue("faruk", 3);
            isimler.SetValue("Nilay", 4);
            isimler.SetValue("Mahmut", 5);

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));

            }
            Console.ReadLine();

            int arananDegerVarmi=Array.IndexOf(isimler, "Şebnemm");
            if (arananDegerVarmi != -1)
            {
                Console.WriteLine("Aranan deger vardır");
            }
            else
            {
                Console.WriteLine("Aranan deger yoktur.");
            }

            Array.Reverse(isimler);
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
                
            }
            Array.Clear(isimler, 2, 2);
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
                
            }
            



        }

    }
}
