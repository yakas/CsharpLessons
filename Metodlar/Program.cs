namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int returnDeger=Metod9(3, 15);
            if (returnDeger > 10)
            {
                Console.WriteLine($"Metodun geri dönüş {returnDeger} degeri 10 dan büyüktür.");
            }
            else
            {
                Console.WriteLine($"Metodun geri dönüş {returnDeger} degeri 10 dan küçüktür.");
            }
            x(4);


        }
        // Algoritmayı yazdıgmız yer genelde metoddur.Metodlar işi çağrıldıklarında tekrar tekrar yaparlar.
        // Constructorlar ,property'ler gibi şeylerde birer metoddur.

        #region Metodun imzası---> [erişimbelirleyicisi] [geridönüşdeğeri] [metodunadı] () { .burasıda metod gövdesi..}
        /*
         * erşimbelirleyicisi -- dışardan erişilsinmi erişilmesinmi
         * erişilsin istiyorsa public
         * erişilmesin istiyorsan private
         * Metodlar sınıf elemanlarıdır.Yani class içerisinde oluşturulacak...
         * Metodlar yaptıkları işlemler algoritmalr neticesinde geriye deger döndürebilirler.Geriye dönen değer kodun içinde farklı yerlerde kullanılabilir.Geri dönüş değeri ekrana yazı yazdırmak değildir.
         * metodun adı yanındaki () ne işe yarıyor.Metod dediğimiz bu yapılanmalar dış dünyadan parametreler alabilmekte ve bu paramaetreler üzerinde işlemler gerçekleştirebilmektedir.Bu parametreler ile metod içinde işlkemeler yapıp geri döndürmektedir.Parametreleri parantez içinde mutlaka tanımlamalıyız.Eğer parametre almayacaksa direk parantezleri aç ve kapat yani boş () şekilde bırak.
         * Yapacağımız işe göre 4 farklı şekilde metod oluşturulabilmektedir.
         * 1- Geriye değer döndürmeyen ve parametre almayan metodlar
         * 2- Geriye değer döndürmeyen ve parametre alan metodlar
         * 3- Geriye değer döndüren parametre almayan metodlar
         * 4- Geriye değer döndüren ve parametre alan metodlar
         * 
         */

        #endregion
        #region Geriye Deger Döndürmeyen ve Parametre Almayan Metodlar
        // [erişimBelirleyicisi] [geriDönüşDegerTipi][MetodAdı] ()
        // bir metod geriye değer döndürmüyorsa void ile bildirilmesi zorunludur..

        private void Metod1()
        {
            Console.WriteLine("Geriye değer döndürmeyen ve parametre almayan metodun çıktısıdır.");
        }
        #endregion
        #region Geriye Deger Döndürmeyen fakat Parametre alan Metodlar
        public void Metod2(int a)
        {
        
        }
        public void Metod3(int a,bool b)
        {

        }
        public void Metod4(int a, bool b,char c)
        {

        }
        public void Metod5(int a, bool b, char c,string d)
        {

        }
        #endregion
        #region Geriye Deger Döndüren fakat Parametre Almayan Metodlar
        /* Eger bir metod geri dondurmek üzere ayarlanmış ise mutlaka bir deger döndürmelidir.Geriye deger döndürmek içinde return keyword kullanılmaktadır.RETURN nerede tetiklenir işlenirse orada metodddan çıkılır.Metod içinde eğer bir kıyaslama yani if ifadesi geçiyorsa şartın gerçekleşme durumu ve gerçekleşmeme durumunun her ikisi için bir return döndürmelisin.Aşağıdaki örnek gibi 2 return komutu kullanmalısın.
         
        public int MetodAdi ()
        {
        if (a>3){return 5;}
        else {return 8;}
        }

         */

        private char Metod6()
        {
            return 'a';
        }
        #endregion
        #region Geriye Deger Döndüren ve Parametre Alan Metodlar
        public bool Metod7(int  a)
        {
            return true;
        }

        public int Metod8(int a)
        {
            return DateTime.Now.Year > 2000 ? 1 : 0; // tarih 2000'den büyükse ternary operatörüne göre 1 veya 0 döndürür yani dönüş değeri int tipindedir.
        }

        static public int Metod9(int a, int b)
        {
            int topla = a + b;
            return topla;
        }
        #endregion
        #region Metodlarda Optional Parameters 
        /* bir parametrenin optional olabilmesi icin default degeri olmalıdır.

        static public void x(int a, int b)
        {
        
        }
        */
        static public void x(int a, int b=5) // int b=5 diyerek b değişkenini optional parametre yapmış olduk.b değişkenine kullanıcı deger göndermek zorunda değil.
        {

        }

        #endregion
        #region Baska class'lardaki metodlara nasıl erişim sağlarız.
        /*
         baska class'lardaki metodlara ulaşmamız için o class 'dan baska bir nesne oluşturup bunu bir değişkene bağlamalıyız..
        class Ogrenci                                 burdaki Ögrenci classın verilerine ulaşmak için içinde bulunduğumuz class içinde öğrenci
        {                                             class'indan bir nesne oluşturmalıyız
          int yas;                                    Ögreci yeniÖgrenci = new Ögrenci(); şeklinde
          string adı;                                 daha sonra oluşturmuş olduğumuz bu yeni Ögrenci nesnesinden istediğimiz metod ve değişkenlere
          string soyadı;                              aşağıdaki şekilde ulaşa biliriz.
          public void clasMetodu()                    yeniÖgrenci.clasMetodu() ile metoda ulaştık.
          {                                           yeniÖgrenci.yas  ile Ögrencinin yaşına ulaştık mesela.. bunu gibi
            console.writeline(adı,soyadı);            burada yeniÖgrenci bir referans tır ve Ögrenci nesnesinin HEAP bellekteki adresini refere
            .....                                     ederek orayı gösterir.
          }                                           class nedir: yeryüzündeki herhangi bir olguyu modellediğimiz yapılanma.
                                                      nesne nedir: class'dan üretilen değer.
        }                                             referans nedir : class'tan üretilen değeri kullanmamızı sağlayan yapı
         
         
         
         
         
         
         */

        #endregion
    }
}
