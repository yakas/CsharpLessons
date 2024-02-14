using System.Text;

namespace StringBuilder_SInıf_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder ile string birleştirme daha az maliyetli olarak yapılır.Bellek tüketimi azdır.
            //StringBuilder arka planda StringSegment'i kullanır.

            string name = "Yakup";
            string surname = "Atalay";

            StringBuilder birlestir = new StringBuilder(); // StringBuilder sınıfından "birlestir" nesnesini olusturduk.
            birlestir.Append(name);
            birlestir.Append(' ');
            birlestir.Append(surname);
            Console.Write(birlestir); // Yakup Atalay
        }
    }
}
