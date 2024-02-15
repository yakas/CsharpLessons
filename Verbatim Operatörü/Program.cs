namespace Verbatim_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Verbatim operatörü   @
            /*
             String ifadelerde kullanılır.@ verbatim operatörü aşağıdaki durumlarda kullanılır.
            
            1- Keyword ifadeleri ezmek için kullanılır .Keywordler metod isimleri, class isimleri erişim belirleyicileri gibi.
             örnek @static static keywordunu degisken olarak kullanmamızı sağladı.
                   @public  public ifadesini değişken olarak kullanabiliriz.  int @public a=45;
           
            2- @ operatörü string ifadelerdeki özel karakterleri ezmek için.
                 @"mesela \t örnek verelim \n"   ifadesinde normalde \t ve \n ifadeleri ezilmiş normal string gibi kullanılmıştır.


             
             
             
             
             
             
             */
            #endregion

            string @public = "ali veli";
            Console.WriteLine(@" yeni satıra geç \n ezilmiş durumda yani yeni satıta geçmez.."+@public);
            

        }
    }
}
