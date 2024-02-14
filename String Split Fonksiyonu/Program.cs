namespace String_Split_Fonksiyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mesaj="Hello, World!";
            //string[] dizi=mesaj.Split(' '); // split verilen bir string ifadeyi ' ' parametresine göre dizi olarak verir
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);

            //}

            ////soru: kullanıcıdan tek satırda ADI SOYADI YASINI VE DOGUM YERINI alarak bunları diziye aktaran bir app.

            //Console.WriteLine("Adınız Soyadınız yaşınız dogum yerinizi aralarında bir boşluk bırakarak giriniz");
            //string girisBilgileri=Console.ReadLine();
            //string[] bilgiler = girisBilgileri.Split(' ');
            //foreach (var item in bilgiler)
            //{
            //    Console.WriteLine(item);
            //}
            // Adımızın ilkten 3. Soyadımızın Sondan 5. karakterini getirelim.
            string ad = "Gençay Yıldız";
            //string uc=ad.Substring(3, 1);
            
            //string bes=ad.Substring(7,1);
            //Console.WriteLine($"adımızın 3. karakteri {ad[2]} Soyadımızın sondan 5. karakteri {bes}");

            string aralik = ad[2..^4]; // range fonksiyonu ile soldan 2 ile sağgdan 5. karakter arasını bir diziye ata.
                                       // ^ fonksiyonu dizinin sonundan başlatır.İstenilen karaktere gitmek
                                       // için 1 den başlar ve sağdan sola ilerler.
            Console.WriteLine(aralik[0]); 
            Console.WriteLine(aralik[aralik.Length-1]);

            // soru: Girilen Metnin İçerisinde Kaç Adet "n" Karakter geçtiğini Hesaplayın
            Console.Write("n karakteri sayılacak metni giriniz :");
            string metin=Console.ReadLine();
            // string degişkenler aslında bir dizi oldugundan dizi fonksiyonunu kullanacagım.
            int nKarekterSayisi = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != 'n')
                    continue;
                
                nKarekterSayisi++;
            }
            Console.WriteLine($"verilen mesajda gecen n karakter sayısı : {nKarekterSayisi}");

        }
    }
}
