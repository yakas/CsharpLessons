using System.Text.RegularExpressions;

namespace Regular_Expressions_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ^ Operatörü--> Satır başının istenilen ifadeyle başlamasını sağlayan operatördür.
            // örnek 1: ^9  metisel değer 9 ile başlamalıdır.

            string text = "9123 kütüphaden aradım bulamadım.";
            Regex regex = new Regex("^9");   // Burada Regex Class'ından yeni bir regex nesnesi oluşturduk ve pattern'ini ^9 olarak verdik.
            Match match = regex.Match(text); // Match Classından yeni match nesnesi oluşturup regex.Match(text) ile text içinde arattırdık.
            Console.WriteLine("^9  9123 kütüphaden aradım bulamadım. --->SONUCU :" + match.Success);// eger match doğruysa true dönecek değilse false dönecek.
                                             // burada örneğimizde Regex regex = new Regex("^9") ile regex nesnesini tanımladık.
                                             // Sonsasında Match clasından yeni bir nesne olusturduk ve input olarak regex'i Match de
                                             // -->Match match = regex.Match(text) olarak tanımladık.
                                             // sonuç True

            // örnek 2 : Mete ile başlıyormu kontrolu

            string text1 = "Metehan bugün yazılım çalıştı.";
            Regex regex1 = new Regex("^Yak"); // burada string cinsinden pattern belirledik.
            Match match1 = regex1.Match(text1);
            Console.WriteLine("^Yak   Metehan bugün yazılım çalıştı.   ----->SONUCU :" + match1.Success);// sonuç doğrumu yanlışmı?  False


            #endregion
            #region \ Operatörü  --> Belirli karakter gruplarını içermesini istiyorsak kullanırız.
            /*
             
            \D --> metinsel degerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiğini belirtir.
            \d --> metinsel değerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir.

            \W --> metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiği belirtilir.Alfanümerik karakterler: a-z A-Z 0-9
            \w --> metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir.

            \S --> metinsel degerin ilgili yerinde boşluk karakterleri(tab/space) dışında herhangi bir karakterin olabileceği belirtilir.
            \s --> metinsel degerin ilgili yerinde boşluk karakterlerinin (tab/space) olabileceği belirtilir.

            Örnek: M ile baslayan,ikinci karakteri herhangi bir sayi olan ve son karakteride boşluk olmayan bir düzenli ifade oluştur.

            ^M\d\S --> bu şekilde bir regex oluşturabiliriz.

            */
            string text2 = "Metehan bugün yazılım çalıştı.";
            Regex regex2 = new Regex("^M\\d\\S");// ilk har M true, ikinci harf rakam olacak demişiz fakat rakam yok false,son karakter
                                                 // space/tab dışında bir karakter olabilir demişiz true
                                                 // @"^M\d\S" şeklidede yazabiliriz.Baştaki @ ezme yaparak bu şekilde kullanabilirsin diyor
                                                 // normalde '\' ters slaş ifadesini '\\' olarak kullanmak zorundaydık.Ama @ işareti ile ezdik.
                                                 
            Match match2 = regex2.Match(text2);

            Console.WriteLine(@"^M\d\S Metehan bugün yazılım çalıştı.    --->SONUCU :" + match2.Success);// sonuç burada ikinci karakter rakam içermediğinde false verir..

            #endregion
            #region + Operatörü --> Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanıyoruz.
            /*
             * 
            

            Örnek : M ile başlayan ,arada herhangi bir sayisal degerleri olan ve son karakteri de boşluk olmayan bir regular expresions regex oluşturalım.
            ^M\d+\S
            */
            string text3 = "Maliye Bakanlığı";
            Regex regex3 = new Regex(@"^M\d+\S");
            Match match3 = regex3.Match(text3);
            Console.WriteLine(@"^M\d+\S   Maliye Bakanlığı   --->SONUCU :" + match3.Success);

            #endregion
            #region | veya operatörü  --> Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek istiyorsak mantıksa veya operatörü kullanırız.
            /*
             
            Örnek : Baş harfi a ya da b ya da c olan metinsel bir ifade girelim.

            a|b|c
             
             */

            string text4 = "Ahmet";
            Regex regex4 = new Regex(@"a|A|b|c");
            Match match4 = regex4.Match(text4);
            Console.WriteLine(@"a|b|c  Ahmet  ---> SONUCU :" + match4.Success);

            #endregion
            #region {n} Operatörü  --> Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmelidir.
            /*
             Örnek : 0537-5969346 telefon numarasının doğru şekilde girilmesini sağlamak için bir regex oluştur.
                      0 5 3 7- 5 9 6 9 3 4 6
                     \d\d\d\d-\d\d\d\d\d\d\d
            veya

            \d{4}-\d{7}

             */
            string text5 = "0537-5969346";
            Regex regex5 = new Regex(@"\d{4}-\d{7}");
            Match match5 = regex5.Match(text5);
            Console.WriteLine(@"\d{4}-\d{7} 0537-5969346  ---> SONUCU :" + match5.Success);
            #endregion
            #region ? Operatörü   ---> Bu operatörü önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.

            /*
             Soru işareti hangi karakterin önüne gelirse o karakter enfazla 1 enaz 0 olacaktır..  n? gibi
               
             \d{3}B?A  --> ilk olarak ilk karakter rakam olacak sonrasında B karakterinden en fazla bir tane olabilir ve sonundada A olsun diyoruz..
              234BA,  543BA,   543A,   123BBA
               TRUE   TRUE     TRUE    FALSE
            */
            string text6 = "123BBA";
            Regex regex6 = new Regex(@"\d{3}B?A");
            Match match6 = regex6.Match(text6);
            Console.WriteLine(match6.Success);

            #endregion
            #region . Operatörü --> Kullanılıdığı yerde \n karakteri dışında her karakter olabilir.
            /*
               \d{3}.A     123zA   567BA  999ÇA   563vA   234\nA 
                            TRUE    TRUE   TRUE    TRUE    FALSE
            */

            string text7 = "234\nA";
            Regex regex7 = new Regex(@"\d{3}.A");
            Match match7=regex7.Match(text7);
            Console.WriteLine(match7.Success);

            #endregion
            #region \B  \b  operatöleri
            /*
                  \b bu operatör ile kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar.
                  \B  bu operatör ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir

                  \d{3}dır\B      123dır     dır123     123dır
                                  FALSE      FALSE       TRUE
             */
            string text8 = "123dır";
            Regex regex8 = new Regex(@"\d{3}dır\B");
            Match match8 = regex8.Match(text8);
            Console.WriteLine(match8.Success);

            #endregion
            #region [n] Operatörü --> karakter aralıgı belirtilir.Ayrıca özel karakterlerin yerinde yazılmasınıda ifade eder.

            //  \d{3}[A-E]   123A   435B   567C  145D  999E  909F
            //               TRUE   TRUE   TRUE  TRUE  TRUE  FALSE

            // özellikle telefon numarası yazdırırken

            // [(]\d{4}[)]\s\d{3}\s\d{2}\s\d{2}        (0530) 593 93 48        0543 56 78 90
            //                                           TRUE                  FALSE
            string text9 = "999E";
            Regex regex9 = new Regex(@"\d{3}[A-E]");
            Match match9 = regex9.Match(text9);
            Console.WriteLine(match9.Success);


            string text10 = "(0530) 593 53 48";
            Regex regex10 = new Regex(@"[(]\d{4}[)]\s\d{3}\s\d{2}\s\d{2}");
            Match match10 = regex10.Match(text10);
            Console.WriteLine($"Success:{match10.Success}");
            Console.WriteLine($"Value:{match10.Value}");
            Console.WriteLine($"Index:{match10.Index}");
            Console.WriteLine($"Length:{match10.Length}");

            #endregion
            #region Regular Expressions Metodları
            /*
            match.Success
            match.Value
            match.Index
            match.Length


            */
            #endregion



        }
    }
}
