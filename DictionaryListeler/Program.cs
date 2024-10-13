using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryListeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,char> liste = new Dictionary<int,char>
            {
                { 1,'A'},{ 2,'B'},{ 3,'C'}
            };
            liste.Add(4, 'D');

            for (int i = 0; i < liste.Keys.Count; i++) 
            {
                Console.WriteLine(liste[i]);
            
            }
        }
    }
}
