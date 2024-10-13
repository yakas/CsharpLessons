using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ortalama());
        }
        static int ortalama(params int[] x)
        {
            int result;
            List<int> liste = new List<int>();
            foreach (int i in x)
            {
                liste.Add(i);
            }
            result = (liste.Sum()) / (x.Length);
            return result;
        }
    }
}
