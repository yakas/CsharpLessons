using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Liste = new ArrayList();
            Liste.Add(1);
            Liste.Add(2);
            Liste.Add("yakup");
            Liste.Add(3.6);//DOUBLE
            Liste.Add(2.5f);// FLOAT
            Liste.Add(2.5M);// DECIMAL
            Liste.Add(" mete");//STRING

            int sum = 0;
            string mtn = "";

            for (int i = 0; i < Liste.Count; i++)
            {
                //if (Liste[i] is int)
                if (Liste[i].GetType() == typeof(int))
                {
                    sum += (int)Liste[i];

                }
                else if (Liste[i] is string)
                {
                    mtn += (string)Liste[i];
                }

            }
            Console.WriteLine(sum);
            Console.WriteLine(mtn);
            Console.ReadLine();


        }
    }
}
