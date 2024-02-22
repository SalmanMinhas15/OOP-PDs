using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problem1.BL;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List <Ship> shipList = new List<Ship>();
            Ship s = new Ship();
            List <Angle>   angleList = new List<Angle>();
            Angle latitude = new Angle();
            Angle longitude = new Angle();
            while (true)
            {
                Console.Clear();
                int option = menu();
                if(option == 1)
                {
                    addShip(s,shipList,angleList,latitude,longitude);
                }
                else if(option==2)
                {
                    viewShipPosition(shipList,angleList);
                }
                else if(option==3)
                {
                    findSrNo(angleList, shipList);
                }
                else if(option==4)
                {
                    changePosition(shipList,angleList);
                }
                else if(option==5)
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
        static int menu()
        {
            Console.WriteLine("-------- Ship management --------");
            Console.WriteLine("\n\t1. Add ship");
            Console.WriteLine("\t2. View Ship position");
            Console.WriteLine("\t3. View Ship Serial number");
            Console.WriteLine("\t4. Change ship position");
            Console.WriteLine("\t5. Exit");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
        static void addShip(Ship s,List<Ship> shipList,List<Angle> angleList,Angle latitude,Angle longitude)
        {
            Console.Write("Enter ship serial number: ");
            s.SrNo=Console.ReadLine();
            shipList.Add(s);
            Console.WriteLine("\nEnter Ship Latitude");
            Console.Write("Latitudes degree: ");
            latitude.degree = int.Parse(Console.ReadLine());
            Console.Write("Latitudes minutes: ");
            latitude.minute = int.Parse(Console.ReadLine());
            Console.Write("Latitude direction: ");
            latitude.direction=char.Parse(Console.ReadLine());
            angleList.Add(latitude);
            Console.WriteLine("\nEnter Ship Longitude ");
            Console.Write("Latitude degree");
            longitude.degree=int.Parse(Console.ReadLine());
            Console.Write("Latitude minutes");
            longitude.minute=int.Parse(Console.ReadLine());
            Console.Write("Latitude direction");
            longitude.direction=char.Parse(Console.ReadLine());
            angleList.Add(longitude);
        }
        static void viewShipPosition(List<Ship> shipList,List<Angle> angleList)
        {
            Console.Clear();
            Console.Write("Enter serial number of ship: ");
            string sr=Console.ReadLine();
            for(int i=0;i<shipList.Count;i++)
            {
                if (sr == shipList[i].SrNo)
                {
                    Console.WriteLine("Your ship is at position: " + angleList[i].degree + "\u00b0" + angleList[i].minute + "'" + angleList[i].direction
                        +" and " + angleList[i+1].degree + "\u00b0" + angleList[i+1].minute 
                        + "'" + angleList[i + 1].direction);
                }
            }
        }
        static void findSrNo(List<Angle> angleList,List<Ship> shipList)
        {
            Console.Clear();
            Console.WriteLine("Enter ship latitude ");
            Console.Write("Degree: ");
            int d1=int.Parse(Console.ReadLine());
            Console.Write("minutes: ");
            int m1=int.Parse(Console.ReadLine());
            Console.Write("Direction: ");
            char dir1 = char.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter ship longitude ");
            Console.Write("Degree: ");
            int d2 = int.Parse(Console.ReadLine());
            Console.Write("minutes: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Direction: ");
            char dir2 = char.Parse(Console.ReadLine());
            for(int i=0;i<angleList.Count;i++)
            {
                if (d1 == angleList[i].degree && m1 == angleList[i].minute && dir1 == angleList[i].direction
                    && d2 == angleList[i+1].degree && m2 == angleList[i+1].minute && dir2 == angleList[i+1].direction)
                {
                    Console.WriteLine("Your Ship Serial number is: "+ shipList[i].SrNo);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            
        }
        static void changePosition(List<Ship> shipList,List<Angle> angleList)
        {
            Console.Clear();
            Console.Write("Enter the serial number of ship whose position you want to change");
            string shipNo = Console.ReadLine();
            for (int i = 0; i < shipList.Count; i++)
            {
                if (shipNo == shipList[i].SrNo)
                {
                    Console.WriteLine("Enter Ship Latitude");
                    Console.Write("\nDegree: ");
                    angleList[i].degree = int.Parse(Console.ReadLine());
                    Console.Write("Minutes: ");
                    angleList[i].minute=int.Parse(Console.ReadLine());
                    Console.Write("Direction: ");
                    angleList[i].direction=char.Parse(Console.ReadLine()) ;

                    Console.WriteLine("\nEnter ship Longitude");
                    Console.Write("Degree: ");
                    angleList[i+1].degree = int.Parse(Console.ReadLine());
                    Console.Write("Minutes: ");
                    angleList[i+1].minute = int.Parse(Console.ReadLine());
                    Console.Write("Direction: ");
                    angleList[i + 1].direction = char.Parse(Console.ReadLine());

                    Console.WriteLine("\nPosition of ship has been updated");
                }
                else
                {
                    Console.WriteLine("Record not found");
                }
            } 
        }
    }
    
}
