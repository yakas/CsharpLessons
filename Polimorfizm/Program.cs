using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            // A a = new A();  A class'dan yeni bir a nesnesi olusturduk. A dan A ya

            A a = new B();  // A class tipinde B nesnesinden a objesini olusturduk  A dan B ye (Polimofizm).
                            // Bu ilk olarak B türü örtülü olarak A türüne dönüştürülemez hatası verir.Bunu
                            // önlemek için kalitim inheritence uygulamak gerekir.Bunun için B sınıfı A
                            // sınıfından kalıtım alacak şekilde ayarlarız.
            
        }
    class A
        {
        }
    //class B

    class B:A   // A a = new B() seklinde polimorfizm uygulamış olduk.
        {
        }
    }
}
