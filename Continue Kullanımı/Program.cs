using System.Diagnostics;

namespace Continue_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                    continue; // continue deyimi ile alt satıra geçmez for dongusune doner.
                Console.WriteLine(i);
                Console.ReadLine();
            }

            while (true)
            {
                if (true)
                {
                    switch (1)
                    {
                        case 5:
                            continue; // burada continue case 5 doldugunda while dongusune tekrar doner
                            break;
                    }
                }


            }
        }
    }
}
