using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Ogrenci
    {
        private int ogrNo;
        private string ogrAd;
        private string ogrSoyad;
        private int vize1;
        private int vize2;
        private int final;
        private string okulAd;

        public Ogrenci(int _ogrNo,string _ogrAd,string _ogrSoyad,int _vize1,int _vize2,int _final,string _okulAd)
        {
            this.ogrNo= _ogrNo;
            this.ogrAd= _ogrAd;
            this.ogrSoyad= _ogrSoyad;
            this.vize1= _vize1;
            this.vize2= _vize2;
            this.final= _final;
            this.okulAd=_okulAd;
            
        }
        
        
        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Ogrenci Numarasi :"+ogrNo);
            Console.WriteLine("Ogrenci adi:"+ogrAd);
            Console.WriteLine("Ogrenci soyad:"+ogrSoyad);
            Console.WriteLine("vize 1:"+vize1);
            Console.WriteLine("vize 2:"+vize2);
            Console.WriteLine("final :"+final);
            Console.WriteLine("okul adi :"+okulAd);
            Console.WriteLine();

        }

        public double  OgrenciOrtalamasiBul()
        {
            double ortalama=vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void OgrenciOkulAd()
        {
            Console.WriteLine("Ogrenci Okul Adi :"+okulAd);
            Console.WriteLine();

        }

    }
    

    
}
