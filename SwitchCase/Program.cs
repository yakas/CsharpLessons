using System.Security.Cryptography;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "İngilizce kursu var.",
                DayOfWeek.Tuesday => "Spora gidilecek",
                DayOfWeek.Wednesday =>"Visual studio list konusu çalışılacak",
                DayOfWeek.Thursday =>"Puffy ile ilgilenilecek",
                DayOfWeek.Friday =>"ingilizce çalış",
                DayOfWeek.Saturday =>"Visula studio da arrar list çalısılacak",


            };
            Console.WriteLine(day);
            Console.ReadLine();
            ///////////////////////////////////////////////////////////////////////////

            int i = 10;
            string isim = i switch
            {
                5 => "Hilmi",
                7 => "Rıfkı",
                10 => "Yakup"

            };
            Console.WriteLine(isim);
            

            #region When Şartı ile switch ifadelerinin kullanılması
           
            int k = 7;
            string durum = k switch
            {
                5 when 3==3 => "Hilmi", // k değişkeni 5 ve 3'3 e eşitse durum değişkenine "Hilmi" atanacaktır.

                var x when x ==7 && x %2 ==1 => "Rıfkı", // buradaki x aslinda k değişkenidir.İşleyisi ise
                                                         // x 7 ye eşitse ve x'in 2 ye bölümünden kalan 1 ise
                                                         // durum değişkenine "Rıfkı" değeri atanacaktır.

                10 => "Yakup",  // k değişkeni 10 'a eşitse durum değişkenine "Yakup" atanacaktır.

                var x=> "Hiçbiri"  // eğer x yani k değişkeni hiçbirseye eşit değilse durum="Hiçbiri" olacaktır. yani switch 'in default durumu

            };
            Console.WriteLine(durum);
            

            #endregion
            #region Tuple değişken yöntemi ile switch kullanımı

            (string adi,int yas) =("",0); // TUPLE olarak değişkenleri bu tanımlıyorduk


            string mesaj = (adi, yas) switch  // tek satırlık bir kontrol yapıyorsak aşağıdaki gibi yazabiliriz.
            {
                ("Hüseyin", 45) => "Hoşgeldin Hüseyin",
                ("Yakup", 30) => "Hoşgeldin Yakup",
                ("Yusuf", 50) => "Hoşgeldin Yusuf",
                (_,_)=> "Hoşgeldin Yabanci"     // eğer hiçbirine eşit değilde default olarak bu işlenir.

            };
            Console.WriteLine(mesaj);



            #endregion
            #region TUPLE Pattern da when şartı
            int degisken1 = 4, degisken2 = 100;

            string mesaj1 = (degisken1, degisken2) switch
            {
                (5, 10) when (true) => "5 ile 10 degerleri",
                var x when x.degisken1 % 2 == 1 || x.degisken2 == 10 => "5 ile 10 degerleri",
                (_,_) =>"Hata var"  // eğer hiç bir şeye eşit değilsede default olarakda bunu yapar.

            };
            Console.WriteLine(mesaj1 );


            #endregion


        }
    }
}
