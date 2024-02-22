using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Admin
    {
        public string adminMenu()
        {
            Console.Clear();
            Console.WriteLine("========= Welcome to Admin Menu =======\n\n");
            Console.WriteLine("\t\t1. Stock data");
            Console.WriteLine("\t\t2. Employee data");
            Console.WriteLine("\t\t3. Place Customer order");
            Console.WriteLine("\t\t4. Check Feedback");
            Console.WriteLine("\t\t5. View Sale");
            Console.WriteLine("\t\t6. View Profile");
            Console.WriteLine("\t\t7. Change Password");
            Console.WriteLine("\t\t8. Logout");
            Console.Write("\n\t\t  Option     ");
            string op = Console.ReadLine();
            return op;
        }
        public string stock()
        {
            Console.Clear();
            Console.WriteLine("1. Add stock (Medicine)");
            Console.WriteLine("2. Remove Stock");
            Console.WriteLine("3. Update stock");
            Console.WriteLine("4. Search Stock");
            Console.WriteLine("5. View Stock");
            Console.WriteLine("6. Back to main menu");
            Console.Write(" option:    ");
            string option=Console.ReadLine();
            return option;
        }
       public string employee()
        {
            Console.Clear();
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Remove employee");
            Console.WriteLine("3. View Employee List");
            Console.WriteLine("4. Update Employee record");
            Console.WriteLine("5. Back to main menu");
            Console.WriteLine("6. Exit");
            string op=Console.ReadLine();
            return op;
        }
    }
}
