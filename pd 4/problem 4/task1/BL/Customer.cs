using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Customer
    {
        public string Cstname;
        public string Cstpassword;
        public string customerMenu()
        {
            Console.Clear();
            Console.WriteLine("======== Welcome to Customer Menu =======\n\n");
            Console.WriteLine("\t\t1. Check Stock");
            Console.WriteLine("\t\t2. Buy medicine");
            Console.WriteLine("\t\t3. System recommended medicines");
            Console.WriteLine("\t\t4. Feedback");
            string op = Console.ReadLine();
            return op;
        }
    }
}
