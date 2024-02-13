namespace Return_Keyword_Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return iki işlevi görmektedir.
            // 1- nerede çağrılıyorsa çağrılsın bulundugu metodtan çıkıs yapar.Yani metodu sonlandırır.
            // 2- metodlardan geriye deger dondurma işlemi yapar.

            /*
            while (true)
            {
                switch(10)
                    case 10:
                    return; // direkt olarak main metoddan çıkış yapar.
                            // return'dan sonra ne gelirse gelsin işlenmez..
                    break;
            }
            */

            // Kullanıcı c tuşuna basana kadar sonsuz döngüde dönen uygulamayı yazınız.

            while (true)
            {
                if (Console.ReadKey().KeyChar == 'c')
                {
                    Console.WriteLine("Uygulama sona erdirilmiştir..");
                    Console.ReadLine();

                    return; // direk main metoddan çıkış yapar program sonlanır..
                }
                Console.WriteLine("Uygulama Çalışıyor...");
            }
        }
    }
}
