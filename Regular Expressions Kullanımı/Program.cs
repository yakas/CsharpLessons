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
            #region
            #endregion

        }
    }
}
