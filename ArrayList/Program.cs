using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // koleksiyon
            // dizilerde önceden eleman sayisi belirtilirken ArrayList'de belirtmemiz gerekmiyor.
            /*ArrayList bizim istediğimiz tipteki degerlerimizi tutan içinde yardımcı metodlar bulunduran bir classtır.

            string[] isimler = { "ali", "veli", "cemil", "yusuf" };// ilkel (primitive) diziyi bu şekilde tanımlıyorduk.
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Console.ReadLine();
            
            System.Collections.ArrayList collection = new System.Collections.ArrayList();
            //collection. yazarsak  bu sekilde ArrayList class'ın icindeki bütün metodlara ulaşabiliriz.
            collection.Add("yakup");
            collection.Add("mehmet");
            collection.Add("tugba");
            collection.Add("sevda");

            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            */
            System.Collections.ArrayList list = new  System.Collections.ArrayList();
            list.Add("selma");
            list.Add(12);
            list.Add("serap");
            list.Add("yakup");
            list.Add(false);
            

            foreach (var eleman in list) // eleman object türü cinsinden bir degiskendir.
            {
                if (eleman is int)  // is operatörü object veri tipi kontrolü yapar.Burada veri tipi "int" ise anlamında
                {
                    Console.WriteLine((int)eleman + 100);
                }

            }
            /*
            Console.ReadLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int dizininElemanSayisi = collection.Count;// ArrayList Count metodu ---arraylistin eleman sayısını int olarak verir.

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //collection.Clear();// ArrayList Clear metodu-- olusturulan arraylistdeki tüm elemanlari silir.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            bool varMi=collection.Contains("yakup");// ArrayListe Contains metodu arraylist icinde verilen item i arar bulursa true deger dondurur.
            Console.WriteLine("ArrayList'de \"yakup\" adli bir item varmı :"+varMi);
            Console.ReadLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int itemIndex=collection.IndexOf("mehmet"); // IndexOf metodu verilen item'in index nosunu verir.
            Console.WriteLine("mehmet 'in arraylist icindeki index numarasi:"+itemIndex);
            Console.ReadLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            collection.Insert(2,"yesim"); // Insert metodu verilen index nosuna verilen value'ı araya ekler.
            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            collection.Reverse();// Reverse metodu arraylist'i ters cevirir.
            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            collection.Remove("yakup");// Remove metodu verilen item'i arraylistten siler.
            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            collection.Sort(); // Sort metodu arrayList icerisindeki degerleri siralar. a'dan z' ye gore
            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
            */

        }
    }
}
