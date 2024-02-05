using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1= new Customer();
            customer1.age = 55;
            customer1.name = "yakup";
            customer1.surname = "atalay";
            customer1.CustomerInfo();

        }
    }
}
