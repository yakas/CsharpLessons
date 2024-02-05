using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Ogrenci
    {
        private string ad;


        public void setAd(string _ad)
        {
            this.ad= _ad;
        }

        public string getAd()
        {
            return this.ad;
        }
    }
}
