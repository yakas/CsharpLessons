using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList liste = new SortedList();
            liste.Add(1, "yakup");
            liste.Add(2, "kagan");
            liste.Add(3, "asli");
            liste.Add(4, "mete");
            liste.Add(5, "zehra");

            liste.Remove(5);

            /* foreach(var eleman in liste) // bu sekiilde Castin islemini foreach dongusune biraktigimizde Console.WriteLine(eleman) ciktisi System.Collections.DictionaryEntry olarak vermekte.Biz bu hatayi foreach dongusunda tipi DictionaryEntry yaparsak cozeriz.Ayrica elemanin key ve value degerinede console.writeline da ulaşılır.
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
            */
            foreach (DictionaryEntry eleman in liste) 
            {
                Console.WriteLine(eleman.Value);
            }
            Console.ReadKey();

        }
    }
}
