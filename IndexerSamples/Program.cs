using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[1] = "yakup";
            people[3] = "zehra";

            Console.WriteLine(people[1]);
            Console.WriteLine(people[3]);
            Console.Read();
        }

        class People
        {
            string[] names = new string[5];

            public string this[int x] // indexer this[] bu ifadeyle belirtilir.burada [] icine index vermek zorundayiz.
            {
                get
                {
                    if (!names[1].Equals("hasan"))
                    {
                        Console.WriteLine("names dizisinin ilk elemani hasan olmak zorunda.");
                        return names[x]="hasan";

                    }
                    else
                    {
                       return names[x];
                       ; 
                    }
                    
                }
                set
                {
                    names[x] = value;
                }

            }

        }
    }
}
