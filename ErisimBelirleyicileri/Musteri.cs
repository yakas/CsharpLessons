using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri
{
    internal class Musteri
    {
        public string musteriAdi;
        public string cinsiyet;
        public int yas;
        private int maas;

        public Musteri(string musteriAdi, string cinsiyet, int yas, int maas) // Constructor metodu olusturduk.
        {
            this.musteriAdi = musteriAdi;
            this.cinsiyet = cinsiyet;
            this.yas = yas;
            this.maas = maas;
        }

        public void MusteriBilgileriYaz()
        {
            Console.WriteLine("Musteri adi:" + musteriAdi);
            Console.WriteLine("musteri cinsiyet:" + cinsiyet);
            Console.WriteLine("musteri yasi:" + yas);
            Console.WriteLine("musteri maasi:" + maas);

        }
    }
}
