using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            string b = a.ToString();// a sayisini string'e cevirdim.

            string c = "12345678";
            int d = Convert.ToInt32(c); // c string degiskenini int 'e cevirdim.

            byte e = 240;
            short f = Convert.ToInt16(e);

            f = 1500;
            e = Convert.ToByte(f);



        }
    }
}
