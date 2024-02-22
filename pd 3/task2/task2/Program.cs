using System;
using task2.BL;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int option = 0;
            while (option != 7)
            {
                Console.Clear();    
                Console.WriteLine("-----Welcome to basic calculator-----");
                Console.WriteLine(".....Select any of the following options.....");
                Console.WriteLine("1. Square root of a number");
                Console.WriteLine("2. Exponential");
                Console.WriteLine("3. logarithm of number");
                Console.WriteLine("4. sin of number");
                Console.WriteLine("5. cosine of numbers");
                Console.WriteLine("6. tangent of numbers");
                Console.WriteLine("7. Exit");

                option = int.Parse(Console.ReadLine());
                Console.Clear();
                
                if (option == 1)
                {
                        Console.Write("Enter number: ");
                        int number = int.Parse(Console.ReadLine());
                        Calculator Obj = new Calculator(number);
                    Console.WriteLine("Square root of number is: " + Obj.sqr(number));
                }
                else if (option == 2)
                {
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    Calculator Obj = new Calculator(number);
                    Console.WriteLine("Exponent of number is: " + Obj.exponent(number));
                }
                else if (option == 3)
                {
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    Calculator Obj = new Calculator(number);
                    Console.WriteLine("Logarithm of number is: " + Obj.log(number));
                }
                else if (option == 4)
                {
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    Calculator Obj = new Calculator(number);
                    Console.WriteLine("Sin of number is: " + Obj.sin(number));
                }
                else if (option == 5)
                {
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    Calculator Obj = new Calculator(number);
                    Console.WriteLine("cos of number is: " + Obj.cos(number));
                }
                else if (option == 6)
                {
                    Console.Write("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    Calculator Obj = new Calculator(number);
                    Console.WriteLine("Tan of number is: " + Obj.tan(number));
                }
                else if (option == 7)
                {
                    Console.WriteLine("Exiting the program");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.ReadKey ();
            }

            Console.ReadKey();
        }
    }
}
