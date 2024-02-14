namespace CokBoyutluDiziOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] aDizisi = new int[2, 2]; // burada 2 satır ve 2 sütünlu bir düzenli dizi oluşturduk.
                                            // Şuan elemanları default olarak sıfır atanmış durumdadır

            aDizisi[0, 0] = 1;
            aDizisi[1, 0] = 2;
            aDizisi[0, 1] = 3;
            aDizisi[1, 1] = 4;

            for (int i = 0; i < aDizisi.GetLength(0); i++)
            {
                for (int j = 0; j < aDizisi.GetLength(1); j++)
                {
                    Console.WriteLine(aDizisi[i, j] + " ");
                }
                Console.WriteLine();
            }

            //--------------------------------------------------
            
            int[,,] bDizisi = new int[2, 2, 2];//6 elemanlı 3D bir dizi olustu.İçeriği şuan boş hepsi 0 default degerde.
            while (true)
            {
                for (int i = 0; i < bDizisi.GetLength(0); i++)// 0. boyutun uzunlugunu aldık aldık
                {
                    for (int j = 0; j < bDizisi.GetLength(1); j++) // 1. boyutun eleman sayısını aldık
                    {
                        for (int k = 0; k < bDizisi.GetLength(2); k++)
                        {
                            Console.Write($"Dizinin {i}. {j}. {k}. elemanını giriniz :");
                            int eleman = int.Parse(Console.ReadLine());
                            bDizisi[i,j,k]= eleman;
                        }
                    }

                }
                break;
            }
            Console.WriteLine("------------------------------------------------------------------------");
            for (int i = 0; i < bDizisi.GetLength(0); i++)// 0. boyutun uzunlugunu aldık aldık
            {
                for (int j = 0; j < bDizisi.GetLength(1); j++) // 1. boyutun eleman sayısını aldık
                {
                    for (int k = 0; k < bDizisi.GetLength(2); k++)
                    {
                        Console.Write($"Dizinin {i}. {j}. {k}.  elemanı  {bDizisi[i,j,k]} ");
                        
                    }
                    Console.WriteLine();
                }

            }


           

        }

    }
}
