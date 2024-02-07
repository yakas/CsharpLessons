using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDeneme
{
    public class C:B
    {
        public string adres;
        public int pass;
        public C():base("kirmizi")
        {
            adres = "GAZİ";
        }

    }
}
