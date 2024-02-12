namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "İngilizce kursu var.",
                DayOfWeek.Tuesday => "Spora gidilecek",
                DayOfWeek.Wednesday =>"Visual studio list konusu çalışılacak",
                DayOfWeek.Thursday =>"Puffy ile ilgilenilecek",
                DayOfWeek.Friday =>"ingilizce çalış",
                DayOfWeek.Saturday =>"Visula studio da arrar list çalısılacak",


            };
            Console.WriteLine(day);
            Console.ReadLine();

        }
    }
}
