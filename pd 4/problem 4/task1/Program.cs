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
            Admin admin = new Admin();
            Customer customer = new Customer();
            Item item= new Item();  
            Employee employee = new Employee();
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
                            while (true)
                            {
                                string option = admin.adminMenu();
                                if (option == "1")
                                {
                                    while (true)
                                    {
                                        string stockOp = admin.stock();
                                        if(stockOp=="1")
                                        {
                                            item.addStock();
                                        }
                                        else if(stockOp=="2")
                                        {
                                            Console.Clear();
                                            Console.Write("Enter product name which you want to remove: ");
                                            string name = Console.ReadLine();
                                            item.removeStock(name);
                                        }
                                        else if(stockOp=="3")
                                        {
                                            Console.Clear();
                                            item.viewStock();
                                            Console.WriteLine("Enter serial number of product which you want to update");
                                            int sr=int.Parse(Console.ReadLine());
                                            if(sr>0 && sr<=item.itemList.Count)
                                            {
                                                Console.Write("Enter New Quantity: ");
                                                int q=int.Parse(Console.ReadLine());
                                                Console.Write("Enter new price: ");
                                                int p=int.Parse(Console.ReadLine());
                                                item.updateStock(sr,q,p);
                                            }
                                            else
                                            {
                                                Console.WriteLine("choose valid serial number");
                                            }
                                            
                                        }
                                        else if(stockOp == "4")
                                        {
                                            Console.Clear();
                                            Console.Write("Enter product name which you want to search: ");
                                            string pN=Console.ReadLine();
                                            item.searchStock(pN);
                                        }
                                        else if(stockOp=="5")
                                        {
                                            item.viewStock();
                                        }
                                        else if(stockOp=="6")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid choice");
                                        }
                                        Console.ReadKey();
                                    }
                                }
                                else if (option == "2")
                                {
                                    while (true)
                                    {
                                        string empOp = admin.employee();
                                        if (empOp == "1")
                                        {
                                            
                                            Console.Write("\nEnter employee name: ");
                                            string name=Console.ReadLine();
                                            Console.Write("Enter age of employee: ");
                                            int age=int.Parse(Console.ReadLine());
                                            Console.Write("Enter salary of employee: ");
                                            int salary=int.Parse(Console.ReadLine());
                                            Employee emp = new Employee(name,age,salary);
                                            emp.addEmp(emp);
                                        }
                                        else if(empOp=="2")
                                        {
                                            Console.Clear();
                                            employee.viewList();
                                            
                                            Console.Write("\n\nEnter Employee name which you want to remove: ");
                                            string name = Console.ReadLine();
                                            employee.removeEmp(name);
                                        }
                                        else if(empOp=="3")
                                        {
                                            Console.Clear();
                                            employee.viewList();
                                        }
                                        else if(empOp=="4")
                                        {

                                        }
                                        else if(empOp=="5")
                                        {
                                            break;
                                        }
                                        else if(empOp=="6")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid choice");
                                        }
                                        Console.ReadKey();
                                    }
                                }
                                else if (option == "3")
                                {

                                }
                                else if (option == "8")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option");
                                }
                                Console.ReadKey();
                            }
                        }
                        else if(u.role=="Customer" || u.role=="customer")
                        {
                            while (true)
                            {
                                string option = customer.customerMenu();
                                if (option == "1")
                                {
                                    
                                }
                                else if (option == "2")
                                {

                                }
                                else if (option == "3")
                                {

                                }
                                else if (option == "8")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option");
                                }
                            }
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
        
        
    }
}
