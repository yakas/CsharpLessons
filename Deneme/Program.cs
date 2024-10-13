using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ortalama(1,2,4));
    }
    static int ortalama(params int[] x)
    {
        int result = 0;
        result = x.Sum() / x.Length;
        return result;
    }
}