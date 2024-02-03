using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine();
            Console.Write("Yapmak istediginiz islem nedir :");
            int secim = Convert.ToInt16(Console.ReadLine());
            Console.Write("İlk sayiyi giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("ikinci sayiyi giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (secim)
            {
                case 1:Console.WriteLine("sayilarin toplami :"+(sayi1+sayi2));
                    Console.ReadLine();
                    break;
                case 2: Console.WriteLine("iki sayinin farki :" + (sayi1 - sayi2));
                    Console.ReadLine();
                    break;
                case 3: Console.WriteLine("iki sayinin carpimi :" + (sayi1 * sayi2));
                    Console.ReadLine();
                    break;
                case 4: Console.WriteLine("iki sayinin bolumu :" + (sayi1 / sayi2));
                    Console.ReadLine();
                    break;
                default: Console.WriteLine("Hatalı secim");

                    Console.ReadLine();
                    break;
            }


        }
    }
}
