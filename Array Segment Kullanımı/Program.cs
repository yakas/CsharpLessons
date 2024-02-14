namespace Array_Segment_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArraySegment<T> dizi yahut string ifadelerdeki bir bölümü temsil etmemizi
            //sağlayan ve bütünsel açıdan ilgili veri kümesini parça parça birden fazla
            //referans eşliğinde yönetmemize imkan veren türlerdir

            //       index     0   1   2   3   4   5   6   7   8   9
            int[] sayilar1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] sayilar2 = sayilar1[2..5];// .. diziyi bu şekildede istediğimiz index arası ayırabiliriz.

            //foreach (var item in sayilar2)
            //{
            //    Console.Write(item + " ");

            //}

            //-----------------------------------------------------------------------------------------------
            ArraySegment<int> segment1 = new ArraySegment<int>(sayilar1, 2, 4); // ArraySegment<Type> nesnesinden yeni
                                                                                // bir ArraySegment oluşturuyoruz
                                                                                //sonra ArraySegment in istediği diziyi
                                                                                //veriyoruz.Dizinin istenilen index
                                                                                //nosundan itibaren kaç adet eleman istiyorsak
                                                                                //nuda belirtiyoruz.Bu örnekte sayilar1
                                                                                //dizisinin 2 nolu indexinden başalr ve
                                                                                //sonrasında 4 elemanını getirmesini söyledik
            segment1[0] *= 10;
            foreach (var item in segment1)
            {
                Console.Write(item + " "); // 300 40 50 60 70

            }

        }


            
            
        
    }
}
