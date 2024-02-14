namespace Array_Silece_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArraySegment Silicing(Dilimleme) kullanımı ile bir dizi üzerinde birden fazla parça ile çalışabiliriz.
            //Bir diziyi tek bir aaraysegment ile referans edip ilgili parçaları o segment üzerinden talep edebilirz.
            //Yani ilgili diziyi tek bir segment üzerinden daha rahat bir şekilde parçalayabiliriz.Bu durumda bize
            //yazılımsal açıdan efektiflik kazandırılmış olacaktır.
            
            int [] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //ArraySegment<int> segment = new ArraySegment<int>();
            ArraySegment<int> segment = new ArraySegment<int>(sayilar);// sayilar dizisini verdik.
            ArraySegment<int> segment1 = segment.Slice(0, 3);     // 0. index ile 3. index arasını diziye aktar
            ArraySegment<int> segment2 = segment.Slice(2, 4);
            ArraySegment<int> segment3 = segment.Slice(5, 5);

            foreach (var item in segment1)
            {
                Console.WriteLine(item + " "); // 10 20 30
            }
            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in segment2)
            {
                Console.WriteLine(item + " "); // 30 40 50 60
            }
            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in segment3)
            {
                Console.WriteLine(item + " "); // 60 70 80 90 100
            }



        }
    }
}
