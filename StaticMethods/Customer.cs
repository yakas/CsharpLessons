using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public class Customer
    {
        public string name;
        public string surname;
        public int age;

        public void CustomerInfo()
        {
            Console.WriteLine("Customer name:"+name);
            Console.WriteLine("Customer surname:" + surname);
            Console.WriteLine("Customer age:"+age);
        }

        

    }
    
}
