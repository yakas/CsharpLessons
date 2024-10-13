using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing_Kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing : Bir deger tipinin ortulu olarak referans tipi ile ifade edilmesidir.
            int sayi = 5;// int deger tipi oldugundan bellegin STACK kisminda saklanir.
            object obj = sayi; // burada sayi bir obje olarak HEAP bellekte tutulur..

            int a = (int)obj;// buradada Unboxing islemi yapilmistir. Casting () operatoru ile yapilir. Objeyi casting ile unboxing yapip icerigine ulasip int deger tipini elde ediyoruz.


        }
    }
}
