using System;
using task1.BL;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator Obj = null;

            int option = 0;
            while (option != 8)
            {
                Console.Clear();
                Console.WriteLine("-----Welcome to basic calculator-----");
                Console.WriteLine(".....Select any of the following options.....");
                Console.WriteLine("1. Create object of calculator");
                Console.WriteLine("2. Change values of attributes");
                Console.WriteLine("3. Add 2 numbers");
                Console.WriteLine("4. Subtract two numbers");
                Console.WriteLine("5. Multiply two numbers");
                Console.WriteLine("6. Divide two numbers");
                Console.WriteLine("7. Modulo of numbers");
                Console.WriteLine("8. Exit");

                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    Obj = new Calculator();
                    Console.WriteLine("Object of class calculator has been created");
                }
                else if (option == 2)
                {
                    if (Obj != null)
                    {
                        Console.Write("Enter new 1st value");
                        int newVal1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter new 2nd value");
                        int newVal2 = int.Parse(Console.ReadLine());

                        Obj.changeValues(newVal1, newVal2);
                        Console.WriteLine("Values changed successfully");
                    }
                    else
                    {
                        Console.WriteLine("Please create an object first");
                    }
                }
                else if (option == 3)
                {
                    if (Obj != null)
                    {
                        Console.WriteLine("Addition is: {0}", Obj.add());
                    }
                    else
                    {
                        Console.WriteLine("Please create an object first");
                    }
                }
                else if (option == 4)
                {
                    if (Obj != null)
                    {
                        Console.WriteLine("Subtraction is: {0}", Obj.subtract());
                    }
                    else
                    {
                        Console.WriteLine("Please create an object first");
                    }
                }
                else if (option == 5)
                {
                    if (Obj != null)
                    {
                        Console.WriteLine("Multiplication is: {0}", Obj.prod());
                    }
                    else
                    {
                        Console.WriteLine("Please create an object first");
                    }
                }
                else if (option == 6)
                {
                    if (Obj != null)
                    {
                        Console.WriteLine("Division is: {0}", Obj.division());
                    }
                    else
                    {
                        Console.WriteLine("Please create an object first");
                    }
                }
                else if (option == 7)
                {
                    if (Obj != null)
                    {
                        Console.WriteLine("Modulus is: {0}", Obj.modulo());
                    }
                    else
                    {
                        Console.WriteLine("Please create an object first");
                    }
                }
                else if (option == 8)
                {
                    Console.WriteLine("Exiting the program");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
