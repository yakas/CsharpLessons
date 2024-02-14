namespace String_Split_Fonksiyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mesaj="Hello, World!";
            string[] dizi=mesaj.Split(' '); // split verilen bir string ifadeyi ' ' parametresine göre dizi olarak verir
            foreach (var item in dizi)
            {
                Console.WriteLine(item);

            }

            //soru: kullanıcıdan tek satırda ADI SOYADI YASINI VE DOGUM YERINI alarak bunları diziye aktaran bir app.

            Console.WriteLine("Adınız Soyadınız yaşınız dogum yerinizi aralarında bir boşluk bırakarak giriniz");
            string girisBilgileri=Console.ReadLine();
            string[] bilgiler = girisBilgileri.Split(' ');
            foreach (var item in bilgiler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
