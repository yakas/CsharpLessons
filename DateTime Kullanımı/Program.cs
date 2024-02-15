namespace DateTime_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime struct'tır
            #region Now
            Console.WriteLine(DateTime.Now);// Now tetiklendiğindeki tarih ve zaman bilgisini getirir.
            #endregion
            #region Today
            Console.WriteLine(DateTime.Today);// Today ise tetiklendiğindeki tarih bilgisini getirir.
            #endregion
            #region Compare sonuç -1 0 1 döner. 
            DateTime tarih_1= new DateTime(2023,02,15);
            DateTime tarih_2= new DateTime(1971,12,28);
            int result =(DateTime.Compare(tarih_1, tarih_2));
            if (result > 0)
            {
                Console.WriteLine($"{tarih_1} büyüktür {tarih_2}");
            }
            else if (result ==0)
            {
                Console.WriteLine($"{tarih_1} eşittir {tarih_2}");
            }
            else
            {
                Console.WriteLine($"{tarih_1} küçüktür {tarih_2}");

            }

            #endregion
            #region Add fonksiyonu 

            Console.WriteLine(DateTime.Now.AddMonths(2));// ay ekle
            Console.WriteLine( DateTime.Now.AddDays(1));// gün ekle
            Console.WriteLine(DateTime.Now.AddHours(2));// saat ekle
            Console.WriteLine(DateTime.Now.AddMinutes(2));// dakika ekle
            Console.WriteLine(DateTime.Now.AddSeconds(30));// saniye ekle

            #endregion
            #region TimeSpan türü iki tarih arasındaki farkı TimeSpan türü olarak geri alabiliriz.

            DateTime t1= DateTime.Now;
            DateTime t2 = new DateTime(1971, 12, 28);

            TimeSpan tarihFarki= t1 - t2;
            
            Console.WriteLine($"iki tarih arasındaki gün farkı :{tarihFarki.Days}");
            

            #endregion

        }
    }
}
