using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List collectionda sadece bizim belirlediğimiz tipte verilen collections'a eklenir.Mesela int,string gibi
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

        }
    }
}
