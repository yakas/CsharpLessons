using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorMethodUsage
{
    public class Users
    {
        private int userId{ get; set; }      // burada belirlediğim değişkenleri aşağıdaki Constructor metodla toplayacağız.
        private string name { get; set; }
        private string surname { get; set; }
        private static int salary { get; set; }

        public Users(int userId,string name,string surname)    // static olmayan Constructor metod
        {
            this.userId= userId;
            this.name= name;
            this.surname= surname;
            
        }

        static Users()  // static Constructor metod.         İLK OLARAK STATIC METOD ÇALIŞIR!!!!
                        // static yapici metodlar erişim belirleyicisi(access modifiers) kullanamaz.
                        // static yapıcı metod parametre alamaz.
                        // static yapıcı metod sınıfa ait yapıcılardan önce çalışır.
                        // static yapıcı metod kaç kaç nesne örneği oluşturulursa oluşturulsun sadece bir kere çalışır.
                        // bir sınıf sadece bir adet static metod içerebilir.
                        // static yapı metod ilk nesne örneği oluşturulduğunda yada
                        // ilk static sınıf üyesi çağrılmadan hemen önce yürütülür.



        {
            salary = 2500;
        }

        public void InfoUser()
        {
            Console.WriteLine("User id:"+userId);
            Console.WriteLine("User name:"+name);
            Console.WriteLine("User surname:"+surname);
            Console.WriteLine("User salary:"+salary);
            Console.ReadLine();

        }

        public void PromotionAdd(int promotionAmount)
        {
            Console.WriteLine("Current salary:"+(salary+promotionAmount));
            Console.ReadLine();

        }
    }

    
}
