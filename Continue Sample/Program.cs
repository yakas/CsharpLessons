namespace Continue_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcın girdiği sonsuz sayıdan pozitif olanları çarpan ve  t   enter
            //yapıldıgında sonucu ekrana yazdıracak bir program yazınız.
            int carpim = 1;
            string cikis = "t";

            while (true)
            {
                Console.Write("sayıyı giriniz: ");
                string sayi=( Console.ReadLine() );
                if (sayi.ToString().Equals(cikis))
                    break;
                int _sayi=int.Parse(sayi);
                if (_sayi < 0) continue;
                carpim *=_sayi;
                
                
            }
            Console.WriteLine($"Pozitif sayıların çarpımı : {carpim}");
            Console.ReadLine(); 

        }
    }
}
