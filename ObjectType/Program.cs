using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            PrintObject(123);        // int
            PrintObject("Hello");    // string
            PrintObject(3.14);       // double
            Console.ReadKey();
        }

        static void PrintObject(params object[] obj)
        {
            foreach (var item in obj)
            {
                Console.WriteLine(item);

                Console.WriteLine(item.GetType().ToString());
            }
            //Console.WriteLine(obj.ToString());
            
        }
    }
}
