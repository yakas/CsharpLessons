namespace Span_Class_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Span bellek üzerinde belirli bir alanı (yani ardışıl olarak sıralanmış dizi diyebiliriz)temsil ederek işlemler
            //gerçekleştirmemizi sağlayan bir struct 'tır.
            //ArraySegment dizideki belli bir alanı temsil ederken span<> ise bellekteki bir alanı temsil etmektedir.
            //arraysegment heap bellegi referans ederken span heap veya stack bellekteki bir alanı referans gösterebilir.

            //Span 'ı ne için kullacağaız.Span, dizi ve string gibi maliyetli veriler üzerinde yapılacak operasyonlarda
            //performans açısından yüksek getiriyle birlikte maliyeti olabildiğince düşürmekle ve ekstrada değer kopyalamaya
            //gerek kalmadan tüm faaliyetleri gerçekleştirmemizi sağlar.arraysegment ile stringsegment ile aynı görevde.


            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Span<int> span = new Span<int>(sayilar); // veya aşağıdaki şekildede ifade edilebilir.
            Span<int> span1 = sayilar;
            Span<int> span2 = new Span<int>(sayilar, 3, 5);// dizinin belirli bir alanını gösterdik.(dizi,start,uzunluk)
            
            Span<int> span4 = sayilar.AsSpan();// diziden AsSpan() metodu ile span türünde bir nesne YANİ span4 'ü döndurecektir..
            
            Span<int> span5 = sayilar.AsSpan(3, 5);// 40 50 60 70 80 çıktısını verir.
            span5[3] = 41; // dizinin fonksiyonları ile istenilen degere atama yapabiliyoruz.Dizinin tüm metodlarını kullanabilriz.
                           // Burada 3 nolu indexte olan degeri 41 yaptık.
            foreach (var item in span5)
            {
                Console.Write(item + " ");// 40 50 60 41 80 çıktısını verir.
            }
            //-------------------------------------------------------------------------------------------------------------------------------
            string soz = "ben genellikle yaz aylarında balık tutmaktan hoşlanırım.";// metinsel ifadelerde span cinsinde değilde
                                                                                    // ReadOnlySpan olarak erişebiliriz.
            ReadOnlySpan<char> readonlyspan = soz.AsSpan(); // char olarak deger dondurur.
            Console.Write(readonlyspan.Contains('a'));// oluşturulan readonlyspan nesnesi a char içeriyormu cevap true donecektir.
            
            
            

        }
    }
}
