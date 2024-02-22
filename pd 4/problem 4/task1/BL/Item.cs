using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Item
    {
        public string itemName;
        public int quantity;
        public int price;
        public string expDate;
        public List<Item> itemList = new List<Item>();

        public void addStock()
        {
            Item item = input();
            itemList.Add(item);
        }
        public Item input()
        {
            Console.Clear();
            Item i = new Item();
            Console.Write("Enter Product (Medicine) name: ");
            i.itemName = Console.ReadLine();
            Console.Write("Enter product quantity: ");
            i.quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter price for one item: ");
            i.price = int.Parse(Console.ReadLine());
            return i;
        }
        public void removeStock(string name)
        {   
            bool result=false;
            for(int i=0;i<itemList.Count;i++)
            {
                if (itemList[i].itemName == name)
                {
                    itemList.RemoveAt(i);
                    Console.WriteLine("\nItem removed successfully");
                    result = true;
                }     
            }
            if(!result)
            {
                Console.WriteLine("\nItem not found");
            }
        }
        public void viewStock()
        {
            Console.Clear();
            Console.Write("\n     Product name\tQuantity\tPrice\n");
            for(int i=0;i<itemList.Count;i++)
            {
                Console.WriteLine(" "+i+1+"  "+itemList[i].itemName + "\t        " + itemList[i].quantity + "\t       " + itemList[i].price);
            }
        }
        public void updateStock(int sr,int newQuant, int newPrice)
        {
            itemList[sr - 1].quantity = newQuant;
            itemList[sr-1].price = newPrice;
      Console.WriteLine("Stock updated successfully");
            
        }
        public void searchStock(string pN)
        {
            bool chk = false;
            for(int i=0;i<itemList.Count;i++)
            {
                if (itemList[i].itemName == pN)
                {
                    int q = itemList[i].quantity;
                    int price = itemList[i].price;
                    Console.WriteLine("Yes! " + pN + " is in stock.\nQuantity is " + q + ".\nPrice is " + price);
                    chk = true;
                }
            }
            if(!chk)
            {
                Console.WriteLine("Sorry! Not available in stock");
            }
        }
    }
}
