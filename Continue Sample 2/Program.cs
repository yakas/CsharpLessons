namespace Continue_Sample_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazdıran program yazınız.

            for (int i = 1; i < 1001; i++)
            {
                if (i % 7 == 0)
                    continue;
                
                Console.WriteLine(i);

                
            }
            Console.ReadLine();
        }
    }
}
