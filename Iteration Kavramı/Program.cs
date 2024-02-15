using System.Collections;
using System.Reflection.PortableExecutable;

namespace Iteration_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Iterasyon Kavramı
            /* 1 3 5 7 9 11 ... dediğimizde bunun devamını getirebiliriz buna iterasyon mantıgı denilir.
            f(5)=10 f(10)=20 f(15)=30 .. gerisini biz tahmin edebiliriz değilmi..
            mermer  baba gibi kelimeler iterasyon kelimelerdir..
            ilk girilen verilere göre diğerlerini tahmin etme üzerine geliştirilmiş..

            birden fazla verinin bir sepette olduğunu düşünün.Bu ya dizidir ya da Koleksiyondur.
            veri kaynağı üzerinde işlem yaparken iterasyon mantığı kullanılır.Veri varmı var gönder sonra tekrar sonra tekrar taki veri kalmayıncaya kadar.
            veri kümelerinde iterasyon ile çalışacaksak bu kümenin içerisindeki degerleri tek tek elde etmek zorundayız.İterasyon her veriyi tektek  alır.
            Eğer biz bu veriler üzerinde işlem yapacak isek iterasyonda çekilen nesnenin kendi tipinde işlem yapmak zorundayız.

            foreach(iterasyon) özünde bir döngü değildir.Sadece operasyonel diğer döngülerle birbirlerine benzerler.
            */
            #endregion
            #region İterasyon vs Döngü
            // foreach de bir dizi,bir veri kaynagı olmalı. ama döngülerde buna gerek yoktur.
            // döngüler sonsuz sayıda deger döndürüken foreach veri dizisindeki eleman sayısı kadar object'leri teker teker alır.
            // foreach kullanırken kaynagın veri yapısı değişecekse foreach kullanma.Hata verir!!!!

            int[] sayilar = { 3, 213, 423, 42, 34, 234, 45, 67, 89 };
            foreach (int  sayi in sayilar) // foreach 'in veri kaynagı bir int dizisi olduğundan herbir elemanı int olarak çekecek.
            {
                Console.Write(sayi+" ");
            
            }
            Console.WriteLine();

            ArrayList sayilar1 = new ArrayList {123,123,456,67,45,3,90,77,"ali","veli",12};
            foreach (object sayi in sayilar1) // foreach 'in veri kaynagı bir ArrayList olduğundan herbir elemanı object olarak çekecek.
            {
                Console.Write(sayi+" ");

            }


            #endregion
        }
    }
}
