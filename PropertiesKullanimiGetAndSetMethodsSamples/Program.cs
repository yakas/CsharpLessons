using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesKullanimiGetAndSetMethodsSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.name = "Yakup";
            ogr1.department = "Chemistry";
            ogr1.OgrenciBilgileriYazdir();

            ogr1._tckimlikno = "90945678908";
            Console.WriteLine("Ogrenci TC numarasi:"+ogr1._tckimlikno);
            Console.ReadLine();
        }
    }
}
