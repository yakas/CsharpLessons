using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorMethodUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Users user1 = new Users(1,"yakup","atalay");
             user1.InfoUser();
             user1.PromotionAdd(240);

        }
    }
}
