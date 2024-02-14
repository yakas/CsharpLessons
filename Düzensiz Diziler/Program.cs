namespace Düzensiz_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // herbir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
            // dizi içerisinde dizi tanımlamada yani düzensiz dizilerde her bir elemanının sütün sayısı farklı olabilir.
            // type[][] diziAdi = new type[][]

            int[][] sayilar = new int[3][];// 3 elamanlı bir düzensiz dizi oluştu.Burada sütün sabit değildir.
            sayilar[0] = new int [3] { 3, 5, 7 };
            sayilar[1] = new int [1] { 1 };
            sayilar[2] = new int [6] { 1,2,3,4,5,6 };

            sayilar[0][0] = 9; // 0'ıncı dizinin {3,5,7} 0. indeksindeki elemanı 9 yaptık.

            int sayilarDizisininElemanSayisi = sayilar[0].Length + sayilar[1].Length + sayilar[2].Length;
            Console.WriteLine($"düzensiz dizisinin eleman sayısı :{ sayilarDizisininElemanSayisi}");


            for(int i=0;i<sayilar.Length;i++) // düzensiz dizilerde direk dizinin eleman sayısını döngü ile alıyoruz
            {
                for (int j = 0; j < sayilar[i].Length; j++) // sonrasında dizinin i. dizisinin içine giriyoruz.
                {
                    Console.Write(sayilar[i][j] + " "); // dizinin yazdırılışı
                }
                Console.WriteLine();

            }


        }
    }
}
