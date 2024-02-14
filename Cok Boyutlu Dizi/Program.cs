namespace Cok_Boyutlu_Dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // type[] -->  tek boyutlu bir dizi tanımlaması
            // type[,] --> iki boyutlu bir dizi tanımlaması
            // type[,,]--->üç boyutlu bir dizi tanımlamasıdır.
            //int[,] sayilar = new int[2, 3];// x ekseninde 1----2   y ekseninde  1---2---3 olur.
            #region tek boyutlu dizi tanımlama örnekleri
            int[] dizi1 = new int[2];
            int[] dizi2 = new int[] { 1, 2, 3 };
            int[] dizi3 = { 1, 2, 3 };
            #endregion
            #region cok boyutlu DÜZENLİ dizi tanımlama örnekleri
            int[,] dizi4 = new int[2, 2]; // iki boyutlu dizi
            int[,] dizi5 = { { 1, 2 }, { 1, 2 } }; // iki boyutlu dizi
            
            int[,] dizi6 = // new int[2,5]  iki satırlı 5 sütünlu bir dizi oluştur..
            
            { //0.sutun   1.sutun     2.sutun     3.sutun     4.sutun
                {1,         2,          3,          4,          5 },   // 0. satır
                {1,         2,          3,          4,          5 },   // 1. satır
            };
            
            for (int i = 0; i < dizi6.GetLength(0); i++) // 2 boyutlu bir dizi oldugundan GetLength(0) ile ilk
                                                         // boyutun uzunlugunu alıyoruz.
                                                         
            {
                for (int j = 0; j<dizi6.GetLength(1); j++) // 1.nolu endekse sahip boyutun uzunlugunu alıyoruz.
                {
                    Console.Write(dizi6[i, j]+" ");
                }
                Console.WriteLine();
            }
            
            
            
                      

            #endregion
        }








    }
}