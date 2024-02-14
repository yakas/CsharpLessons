using Microsoft.Extensions.Primitives;

namespace String_Segment_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringSegment ile bir dizinin belirli bir alanını referans etmek.StringSegment türünü kullanabilmek
            //için uygulamaya Microsoft Extensions Primitive paketinin yüklenmesi gerekmektedir.
            // StringSegment direk string'e donusebiliyor.Dolayısı ile direk Console.writeline ile yazdırabiliyoruz.

            string text = "ben bir yazılımcı olmak için çok ama çok çalışıyorum kardeşşş";

            StringSegment segment = new StringSegment(text);
            StringSegment segment1= new StringSegment(text,2,5); // "n bir" çıktısı verir
            Console.WriteLine(segment1);

            // burada text ile segment HEAP bellekte ayni yeri refere etmekte.Dolayısı ile birinde yaptıgım
            // değişiklik diğerinide değiştirecektir.



        }
    }
}
