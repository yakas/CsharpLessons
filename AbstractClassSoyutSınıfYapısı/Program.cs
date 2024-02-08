using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSoyutSınıfYapısı
{
    class Program
    {
        static void Main(string[] args)

        {
            //Abstract class denince aklimiza kalitim gelmeli.Base class'daki metod yada property'lerin
            //kalitim alan siniflardabihtiyaca göre degistirilerek kullanilmasi icin olusturulan
            //yapıya abstract class yapısı diyoruz.Bir base class'da herhangi bir metod "virtual" olarak
            //belirtilmiş ise biz bu metodu yada property'i derived yani kalitim alan child class'da
            //override ederek kullanabiliyorduk.Aslinda abstract class bu işlemi yapan sınıftır.
            //Abstrac class bu virtual ve override işlemini zorunlu kılmaktadır
        }

    }

    /*
    class Myclass ---> burası classın imzası..

    {---------------> burasi ise class in gövdesidir.
    }
    

    abstract class Myclass // abstrac ibaresi ile olusturulan sınıfın abstract class oldugunu belirtiriz.
                           // Abstract class icerisinde kullanılan asbtract olarak isaretlenen her metod
                           // ve property'ler bu abstract class tan kalitim alan her class da uygulanmak
                           // zorundadir.Bir abstract class icerisnde abstract elemanlar varken abstract 
                           //olmayan elemanlarda olabilir.Abstract classda elemanlar private olamazlar.
                           
                            //Abstract classlardan nesne yaratilmaz ancak referansı alınabilir.

    {
        /* asagidakiler abstract olmayan metod ve property örnekleri
        public void x()
        {
        }
        public int MyProperty { get; set; }
        
        public int MyProperty2
        {
        
            get
            {
            return MyProperty;
            }
            set
            {
                MyProperty = value;
            }

        }
        
        string name;

        // abstract string name; abstract classlarda abstract field tanımlayamayız.
        public abstract void X();  // bunlarda abstract metod ve property örnekleri.
                                   // Abstract metod ve property'lerin Bunların gövdeleri olamaz.Sadece imzalari var
        abstract public int Myproperty3
        {
            get;set;
        }
        */

    abstract class Ornek
    {
        abstract public void X();
        abstract public int Y {get; set;}
        abstract public bool Z();

        public void W() // Abstract class icinde abstract olmayan metodlarda olabilir demistik
        {
        }
        
        
    }
    class Calisma:Ornek // hata verdi.Cunku Calisma class'ı Ornek abstract class'dan miras aldı.
                        // Kurala gore abstract class'dan devir alınan property ve metodlar aynen
                        // yeni class'da uygulanmalıdır.Hatayı gidermek icin olusturmus oldugumuz
                        // Calisma class'ın imza kısmına imleci getirip Ctrl+. basarsak abstract
                        // class'ın metod ve propertyleri olusturmus oldugumuz Calisma classına
                        // otomatikmen asagidaki gibi eklenecektir.
    {
        public override void X()   // burada metod ve property'ler override olarak uygulandı.
                                   // Yani metod ve property'ler ezildi.İstedigimiz gibi ayar cekebiliriz demektir.
                                   // Abstract class yani base class'da sanki metod ve property'ler virtual
                                   // olarak tanımlanmış gibi davrandılar.
        {
            throw new NotImplementedException();
        }

        public override int Y { get; set; }

        // istersek bu alanda override yazıp bir bosluk bırakırsa yukarda abstract classda tanımlanan
        // metodlar virtual metodmus gibi listelenir buradan secerekde ekleyebilirdik.
        public override bool Z()
        {
            throw new NotImplementedException();
        }
        
    }

    
}
