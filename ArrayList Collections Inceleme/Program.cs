using System.Collections;

namespace ArrayList_Collections_Inceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Collections Tanımlama

            int[] yaslar = new int[17];   // dizilerde başalngıçta eleman sayısı tanımlamak zorundayiz ama ArrayList'de mecbur değiliz.
            ArrayList _yaslar = new ArrayList(); // nesne olusturma kuralı NesneClassı yeninesneAdı = new NesneClass()  şeklindedir.

            #endregion
            #region Tanımlanmış Koleksiyona değer atama
            yaslar[5] = 12;
            _yaslar.Add(12);// _yaslar ArrayList'e 12 eklediğimizde int 12 degerine Boxing işlemi yapılarak object'e çevriliyor
                            // ve HEAP belleğe gönderiliyor

            for (int i = 0; i < 17; i++)
            {
                yaslar[i] = i + 10;
                _yaslar.Add(i + 10);
                
            }


            #endregion
            #region Tanımlanmış Koleksiyondan değer nasıl okunur
            //Dizler
            Console.WriteLine(yaslar[5]);

            //Koleksiyonlar
            Console.WriteLine(_yaslar[5]);

            #endregion
            #region ArrayList Kullanılırken Boxing ve Unboxing Durumları

            // ArrayList object olarak veri almaktadır.Object içinde her tür deger olabilir.Bunada Boxing işlemi diyorduk.Bunu HEAP bellekte tutar.
            // Object olan bir degerden içeriğindeki degerleri kendi türünde geri almak için Unboxing yapmak zorundayız.
            // ArrayList'de tutmuş olduğumuz boxing işlemi uygulanmış nensneleri kendi türlerinde geri almak için bunlara unboxing işlemi yapmalıyız.
            // ArrayList'deki eleman sayısını Count metodu kullanılır.

            int toplam = 0;
            for (int i = 0; i < _yaslar.Count; i++)
            {
                toplam += (int)_yaslar[i]; // Object olarak saklanan veriyi int'e casting yaptık. Cast operatörü () ile unboxing yaptık.
            }




            #endregion
            #region ArrayList Collections Initializers (Koleksiyon ilklendirici) ile deger ekleme
            
            ArrayList arrayList = new ArrayList() // bu degerler koleksiyonun içine direk eklenmiş
                                                  // olarak gelecektir.ArrayList'in içine atmış olduğumuz degerlerin kendi
                                                  // tiplerini bilerek işlem yapmalıyız.ArrayList dışına kendi türüne çevirerek
                                                  // çıkartmalıyız.Çünkü ArrayList tüm verileri Object türünde tutmaktadır.
            {
                "Ahmet",
                123,
                'a'
            };
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is int) // ArrayList dizinin elemanlarını 'is' operatörü ile int olup olmadığını kontrol ettim.
                {
                    arrayList[i] = 99;
                }
                Console.WriteLine(arrayList[i]);
            }



            #endregion
        }
    }
}
