using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using InheritanceSample;

namespace InheritanceSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cat cat1 = new Cat();
            cat1.animalColor = "siyah";
            cat1.animalName = "lazy";
            cat1.animalType = "siyam";
            cat1._animalAge = 3;
            cat1.animalInfo();
            Console.WriteLine(cat1._animalAge);
            Console.ReadLine();
                                 
                       
        }

    }
}
