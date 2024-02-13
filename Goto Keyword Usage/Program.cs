namespace Goto_Keyword_Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // goto keyword ile kodu çalışma akışını bozup istenilen noktaya yönlendirir. 
            int i = 1;
            x:  // tanımlanan referans
            Console.WriteLine(i++);
            if (i <=100)
                goto x;

            

        }
    }
}
