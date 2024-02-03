using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteredNumberSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This console application adds from 1 to the entered number.\n");
            Console.Write("please enter the last number :");
            int number = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= number; i++)//
            {
                total += i;
            }
            Console.WriteLine("1-"+number+" numbers total sum: "+total);
            Console.ReadKey();

        }
    }
}
