//using System.Diagnostics;

///**namespace KullanicidanVeriAlmaUygulamasi
//{
//    internal class Program
//    {
//        enum Plaka { Ankara = 06, 
//                     Kirklareli =39,
//                     Istanbul=34,
//                     Trabzon=61,
//                     Izmir=35 }
//        *
//        static void Main(string[] args)
//        {
//            /*Console.Write("Bir plaka numarasi giriniz :");
//            int plakaDegeri = int.Parse(Console.ReadLine());
//            Plaka plaka = (Plaka)plakaDegeri;
//            Console.WriteLine($"Girilen plaka {plaka} iline aittir.");
//            for (int i = 0; i < 256; i++)
//            {


//                char character = (char)i;
//                Console.WriteLine($"character kodu:{ i}    character= {character}" );
//            }

//            int sayi = 11;
//            string cevap = (sayi == 10) ? "sayi 10'na eşit" : "sayi 10'dan farkli.";
//            Console.WriteLine(cevap);

//            string mesaj = null;
//            string yeniMesaj = mesaj ?? "mesaj yok";
//            Console.WriteLine(yeniMesaj);

//            string cevap = "YAKUP ATALAY";
//            char ilkKarakter = cevap[8];
//            char sonKarakter = cevap[cevap.Length - 1];
//            Console.WriteLine($"ilk karakter {ilkKarakter}");
//            Console.WriteLine($"Son karakter {sonKarakter}");
            
//            Console.Write("bolunecek sayıyı giriniz:");
//            int girilenSayi=int.Parse(Console.ReadLine());
//            Console.Write("bolecek sayiyi giriniz:");
//            int bolen=int.Parse(Console.ReadLine());

//            int bolumSonuc = girilenSayi % bolen;
//            String mesaj = bolumSonuc == 0 ? $"{girilenSayi} {bolen} sayisina tam bolunmustur ve bolumden kalan sonuc {bolumSonuc}" : $"{girilenSayi} {bolen} sayisina tam bolunememistir ve bolumden kalan sonuc {bolumSonuc}";
//            Console.WriteLine(mesaj);

//            Console.Write("bir sayi giriniz:");
//            int sayi = Convert.ToInt32(Console.ReadLine());
//            String mesaj = sayi % 2 == 0 ? $"Girilen {sayi} sayisi cift" : $"Girilen {sayi} sayisi tek";
//            Console.WriteLine(mesaj);
            

//            string mesaj = "Anacım ben iyiyim.";
            
//            int index = 0;
//            foreach (char siradakiHarf in mesaj)
//            {
                
//                if (siradakiHarf == 'y')
//                {
//                    Console.WriteLine($"----> y harfinin cümle icindeki indexi :{index}");
//                }
//                index += 1;
                
//            }
            
//            Console.Write("sayiyi giriniz:");
//            int sayi = Convert.ToInt32(Console.ReadLine());
//            int toplam = 0;
//            for(int i=0; i<=sayi; i++)
//            {
//                if (i%2 == 0)
//                {
//                    toplam+=i;
//                }
//                continue;
//            }
//            Console.WriteLine($"girilen rakama kadar sayilardan cift olanlarin toplami :{toplam}");
            
//            Console.Write("Tersten yazilacak sayiyi giriniz:");
//            string sayi = Console.ReadLine();
//            for (int i = sayi.Length-1; i >= 0 ; i--)
//            {
//                Console.Write(sayi[i]);
//            }
            
//            Console.Write("ASCII kodlari yazilacak metni giriniz:");
//            string metin = Console.ReadLine();

//            for (int i = 0; i < metin.Length; i++) 
//            {
//                int karakterKodu = (int)metin[i];
//                Console.Write($"{metin[i]} '{karakterKodu}'\t");


//            }
            
//            int a = 11;
            
//            Console.WriteLine(a == 10 ? $"a sayısı 10 eşit" : $"a sayısı 10'a eşit degil.");
//           ************************************************************************* 
//            Console.BackgroundColor = ConsoleColor.Green;
           
//            Console.WriteLine("**** SAYI TAHMIN OYUNU ****");

//            Random rnd = new Random();
//            int sayi = rnd.Next(1, 3);
//            int hak =1;
//            Console.WriteLine("Bilgisayar tahmin edeceginiz sayiyi belirledi!");
//            while (hak <4)
//            {
//                Console.Write("Tahmininizi Giriniz:");
//                int tahmin = int.Parse(Console.ReadLine());
//                if (tahmin == sayi)
//                {
//                    Console.BackgroundColor = ConsoleColor.White;
//                    Console.ForegroundColor = ConsoleColor.DarkBlue;
//                    Console.WriteLine($"Tebrikler {hak} denemede bildiniz");
//                    break;

//                }
//                else if (tahmin > sayi)
//                {
//                    Console.WriteLine("Daha kucuk bir rakam giriniz!");

//                }
//                else
//                {
//                    Console.WriteLine("Daha buyuk bir rakam giriniz!");
//                }
//                hak++;
//                if (hak>4)
//                {
//                    Console.WriteLine("3 deneme hakkiniz bitti! Üzgünüm...");
//                }
//                Console.BackgroundColor = ConsoleColor.Red;
//                Console.ForegroundColor = ConsoleColor.Black;

//            }
//            ***********************************************************************
//            int[] sayilar = new int[10];
//            for (int i = 0; i < 10; i++)
            
//            {
//                Console.Write($"{i} ci sayiyi giriniz:");
//                int sayi = int.Parse(Console.ReadLine());
//                Console.WriteLine();
//                sayilar[i] = sayi;
//            }
//            for (int i = 0; i < 10; i++)
//            {
//                Console.Write(sayilar[i]);
//            }
            
//            Array.Sort(sayilar);
//            Array.Reverse(sayilar);
//            Console.WriteLine();
//            for (int i = 0;i < sayilar.Length; i++)
//            {
//                Console.Write(sayilar[i]);  
//            }
            
//            ***********************************************************************
            
            
//            Process[] process = Process.GetProcesses();

//            foreach (Process processItem in process)
//            {
//                Console.WriteLine($"proces item:{processItem.Id}");
//                Console.WriteLine($"proces memory usage:{processItem.PagedSystemMemorySize64}");

//                if(processItem.ProcessName.Contains("wps"))
//                {
//                    processItem.Kill();
//                }

//            }
//            ****************************************************************************************
            
//            Console.Write("kac adetlik bir dizi olusturmak istersin:");
            
//            int i=int.Parse(Console.ReadLine());
//            int[] sayiDizisi = new int[i];
            
//            for (int j = 0; j < sayiDizisi.Length; j++)
//            {
//                Console.Write($"{j}. sayiyi giriniz:");
//                int sayi = int.Parse(Console.ReadLine());
//                sayiDizisi[j] = sayi;
//            }
//            Console.WriteLine("girmis oldugunuz sayilar kucukten buyuge siralaniyor!");
//            Console.WriteLine("-----------------------------------------------------");
//            for (int j = 0; j < sayiDizisi.Length; j++)
//            {
//                for (int k = 0; k < sayiDizisi.Length; k++)
//                {
//                    if (sayiDizisi[j] < sayiDizisi[k])
//                    {
//                        var bellek=sayiDizisi[j];
//                        sayiDizisi[j] = sayiDizisi[k];
//                        sayiDizisi[k] = bellek;
//                    }
//                }
//            }
//            for (int j = 0;j < i; j++)
//            {
//                Console.Write($"{sayiDizisi[j]} - ");
//            }
//            *******************************************************************************
//            Recuirsive Metod   ---  özyinelemeli metod --- kendi kendi cagiran metod 
            
             
//            Console.WriteLine(usAl(2, 3));

//            Console.ReadKey();*/
//            //***********************************************************************************
            
//                        Console.WriteLine(usAl(2,4));
//                    }
//                    static int usAl(int x, int y)
//                    {
//                        int[,] usAlma = new int[x, y];
//                        int result = 1;
//                        for (int i = 1; i <= usAlma.GetLength(1); i++)
//                        {
//                            result *= x;
//                        }
//                        return result;
//                    }



                    
//                    static int usAl(int taban, int us)
//                    {
//                        if (us == 0)
//                        {
//                            return 1;
//                        }
//                        return taban * usAl(taban, us - 1);
            
//            Console.WriteLine("Kac karakterlik guvenlik resmi olusturulsun:");
//            int guvenlikKarakterSayisi = int.Parse(Console.ReadLine());
//            char[] guvenlikKrakterleri = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'a', 'Q', 'X', 'c', '*', 'G', 'e', 'M', 'f' };
//            Console.WriteLine(guvenlikResmiOlustur(guvenlikKarakterSayisi, guvenlikKrakterleri));
            


//        }
//        static string guvenlikResmiOlustur(int karakterSayisi, char[] guvenlikKarakterListesi)
//        {
//            int uretilenKarakterSayisi = 0;
//            string üretilenGuvenlikResmi = "";
//            for (int i = 0; i < karakterSayisi; i++)
//            {
//                Random c = new Random();
//                int index=c.Next(guvenlikKarakterListesi.Length-1);
                
//                üretilenGuvenlikResmi += guvenlikKarakterListesi[index].ToString(); 
//            }
//            return üretilenGuvenlikResmi;
//        }

//   }
//}
//*/
