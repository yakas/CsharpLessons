using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    public class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.OrnekMetod();
            Console.Read();

        }

        class A
        {
            //public void OrnekMetod()
            public virtual void OrnekMetod()  // virtual ibaresi eklenirse bu A sınıfı yani "base" alandaki 
                                              // metodlar veya property'ler child class olan B de
                                              // tekrardan düzenlenebilir.
            {
                Console.WriteLine("Bu bir örnek metotdur.");
            }
                          
            
        }

        class B:A  // B classda A sınıftan gelen metod veya property'ler tekrar duzenlemek
                   // icin child class olan B'de override ifadesi yazılıp bosluk tusuna basılırsa
                   // base class'daki metod veya property'ler listelenir.Buradan istenilen metod veya
                   // property secilir ve tab tusuna basılırsa otomatikmen override metod veya
                   // property olusturulur.
        {
            public override void OrnekMetod() // buradaki override edilen metod aslında base class'da
                                              // virtual olarak ayarlanmış metoddur.Buna ezilmiş metod
                                              // denir.Yeniden düzenlenebilir.
            {
                Console.WriteLine("Bu bir ezilmiş override edilmis metod olmuştur."); 
                
            }

        }
    }
}
