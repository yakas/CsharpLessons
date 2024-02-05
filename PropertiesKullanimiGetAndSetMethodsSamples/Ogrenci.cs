using System;

namespace PropertiesKullanimiGetAndSetMethodsSamples
{
    internal class Ogrenci
    {
        public string name;
        public string department;
        private string tckimlikno;
        public string _tckimlikno
        {
            get
            {
                return tckimlikno.Substring(0, 5);
            }
            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);
                        if (sayimi)
                        {
                            // rakamsa herhangi bir islem yapmiyoruz..
                        }
                        else
                        {
                            //rakam degilse donguden cik.
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("TC kimlik numaranizda gecersiz karakter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }

            }
        }

        public void OgrenciBilgileriYazdir()
        {
            Console.WriteLine("Ogrenci adi:" + name);
            Console.WriteLine("Ogrencinin Bolumu:" + department);
            Console.ReadKey();
        }
    }
}
