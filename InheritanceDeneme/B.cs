using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDeneme
{
    public class B:A
    {
        public int uzunluk;
        public string color;
        public B(string str):base(2)
        {
            uzunluk = 0;
            str = color;

        }
    }
}
