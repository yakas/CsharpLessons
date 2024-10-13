using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersVeDuzKontrolPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelimeyi Giniz:");
            string msg=Console.ReadLine();
            Console.WriteLine("---------------------");
            string tersten=new string (msg.Reverse().ToArray());
            
            
            
            Console.WriteLine(tersten);
            if(tersten.Equals(msg))
            {
                Console.WriteLine("girmis oldugun metin PALINDROM dur.");
            }
            else
            {
                Console.WriteLine("girmis oldugun metin PALINDROM degildir.");
            }
            Console.ReadKey();
        }
    }
}
