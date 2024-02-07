using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C cNesne = new C();

            //---------------------------------------
            cNesne.id = 1;
            cNesne.name = "test";
            cNesne.description = "daire temiz";
            //---------------------------------------
            cNesne.color = "mavi";
            cNesne.uzunluk = 45;
            //---------------------------------------
            cNesne.pass = 11111;       
            cNesne.adres = "Kocasinan";
            //---------------------------------------

        }
    }
}
