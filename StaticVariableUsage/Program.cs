using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariableUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.employeeId = 1;            //static olarak tanımlanmadıgı icin referans nesne olusturup kullanabiliriz
            employee1.employeeName = "yakup";    //
            employee1.employeeSurname = "atalay";//
            Employee.salary = 5000;              // static olarak tanımlandığından refernas nesne olusturmadan kullandık.

            Console.WriteLine("Employee id:"+employee1.employeeId);
            Console.WriteLine("Employee name:"+employee1.employeeName);
            Console.WriteLine("Employee surname:"+employee1.employeeSurname);
            Console.WriteLine("Employee salary:"+Employee.salary);
            Console.ReadLine();

        }
    }
}
