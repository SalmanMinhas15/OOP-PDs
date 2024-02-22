using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "data.txt";
            List<User> user = new List<User>();
            load(path, user);
            while (true)
            {
                
                Console.Clear();
                string op = Menu();

                if (op == "1")
                {
                    Console.Clear();
                    User u = SignUpInput();
                    if(u!=null)
                    {
                        SignUp(path, u,user);
                    }
                    else if(u==null)
                    {
                        Console.WriteLine("please fill the fields");
                    }
                }
                else if (op == "2")
                {
                    Console.Clear();
                    User u = SignInInput();
                    if(u!=null)
                    {
                       u = SignIn(u, user);
                        if(u.role=="Admin" || u.role=="admin")
                        {
                           string option= adminMenu();
                        }
                        else if(u.role=="Customer" || u.role=="customer")
                        {
                            string option = customerMenu();
                        }
                        else
                        {
                            Console.WriteLine("Not registered");
                        }
                    }
                    else if(u==null)
                    {
                        Console.WriteLine("please fill the fields");
                    }

                }
                else if (op == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option ....");
                }
                Console.ReadKey();
            }
        }
        static string Menu()
        {
            Console.WriteLine("======= Welcome to AR pharmacy ======\n\n");
            Console.WriteLine("\t\t1. Sign Up");
            Console.WriteLine("\t\t2. Sign In");
            Console.WriteLine("\t\t3. Exit\n");

            Console.Write("Your option   ");
            string op = Console.ReadLine();

            return op;
        }
        static void load(string path, List<User> user)
        {
            StreamReader file = new StreamReader(path);
            string data;
            while ((data = file.ReadLine()) != null)
            {
                string username = GetField(data, 1);
                string password = GetField(data, 2);
                string role = GetField(data, 3);
                User u = new User(username, password, role);
                user.Add(u);
            }
            file.Close();
        }
        static string GetField(string record, int field)
        {
            int commaCount = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    item += record[x];
                }
            }

            return item;
        }
        static User SignUpInput()
        {
            Console.WriteLine("======= Welcome to AR pharmacy ======\n\n");
            Console.Write("Enter username: ");
            string name = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your role: ");
            string role = Console.ReadLine();

            if (name != null && password != null && role != null)
            {
                User u = new User(name, password, role);
                return u;
            }
            else
            {
                return null;
            }
        }
        static void SignUp(string path,User u,List<User> user)
        {
            user.Add(u);
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(u.username+","+u.userpassword+","+u.role);
            file.Flush();      //  ensure that data is written on the disk
            file.Close();
        }
        static User SignInInput()
        {
            Console.WriteLine("======= Welcome to AR pharmacy ======\n\n");
            Console.Write("Enter username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            User u = new User(name, password);
            return u;
        }
        static User SignIn(User u,List<User> user)
        {
            foreach (User i in user)
            {
                
                if(u.username==i.username && u.userpassword==i.userpassword)
                {
                    return i;
                }
            }
            return null;
        }
        static string adminMenu()
        {
            Console.Clear();
            Console.WriteLine("========= Welcome to Admin Menu ========\n\n");
            Console.WriteLine("\t\t1. Stock data");
            Console.WriteLine("\t\t2. Employee data");
            Console.WriteLine("\t\t3. Check Feedback");
            string op= Console.ReadLine();
            return op;
        }
        static string customerMenu()
        {
            Console.Clear();
            Console.WriteLine("======== Welcome to Customer Menu =======\n\n");
            Console.WriteLine("\t\t1. Check Stock");
            Console.WriteLine("\t\t2. Buy medicine");
            Console.WriteLine("\t\t3. System recommended medicines");
            Console.WriteLine("\t\t4. Feedback");
            string op=Console.ReadLine();
            return op;
        }
    }
}
