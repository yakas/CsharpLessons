using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List collectionda sadece bizim belirlediğimiz tipte verilen collections'a eklenir.Mesela int,string gibi
            //ArrayList'de ise her türlü veri tutulmaktadir.Bunlar Object,int,bool gibi degerler olabiliyordu.
            
            List<int> liste = new List<int>(); // int tipinde liste adinda bir List collection olusturduk.

            //ArrayList'deki tüm metodlar buradada gecerlidir.
            liste.Add(1);
            liste.Add(2);
            liste.Add(55);
            liste.Add(33);

            foreach (int i in liste)
            {
                if (i == 55)
                {
                    Console.WriteLine(i+4);
                }
                
            }   
            Console.ReadKey();
            

            List<int> sayilar1 = new List<int>();
            sayilar1.Add(1);
            sayilar1.Add(2);
            sayilar1.Add(3);
            foreach(int item in sayilar1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
            List<int> sayilar2 = new List<int>();
            sayilar2.Add(4);
            sayilar1.AddRange(sayilar2);

            foreach(int item in sayilar1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
            }
            Console.ReadKey();
            sayilar1.Reverse();
            foreach(int item in sayilar1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
            }
            Console.ReadKey();
            */

            List<string> iller = new List<string>();
            {
                iller.Add("Ankara");
                iller.Add("Istanbul");
                iller.Add("Kayseri");
                iller.Add("Kirikkale");
            }
            string ters="";

            foreach (string s in iller)
            {
                if(s == "Kirikkale")
                {
                    for (int i = s.Length-1; i >= 0; i--)
                    {
                        ters += s[i];
                    }
                }
            }
            iller.Add(ters);
            iller.Remove("Kirikkale");
            foreach (string x in iller)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
