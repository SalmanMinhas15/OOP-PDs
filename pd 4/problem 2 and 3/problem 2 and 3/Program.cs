using problem_2_and_3.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem_2_and_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Player> Plist = new List<Player>();
            List<Stats> Slist = new List<Stats>();
            while (true)
            {
                Console.Clear();
                int op = menu();
                if (op == 1)
                {
                    addPlayer(Plist);
                }
                else if (op == 2)
                {
                    addStats(Slist);
                }
                else if (op == 3)
                {
                    dispPinfo(Plist);
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Console.Write("Enter name of player to which you want to add skill: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter skill: ");
                    string sN = Console.ReadLine();
                    learnSkill(name, sN, Slist, Plist);
                }
                else if (op == 5)
                {
                    Console.Clear();
                    Console.Write("Enter name of attacker player: ");
                    string a = Console.ReadLine();
                    Console.Write("Enter name of target player: ");
                    string t = Console.ReadLine();
                    Console.Write("Enter skill of attacker: ");
                    string skill = Console.ReadLine();
                     attack( Plist,a, t, skill);
                }
                else if (op == 6)
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
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add player");
            Console.WriteLine("2. Add skill statistics");
            Console.WriteLine("3. Display player info");
            Console.WriteLine("4. Learn a skill");
            Console.WriteLine("5. Attack");
            Console.WriteLine("6. Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void addPlayer(List<Player> Plist)
        {
            Console.Clear();
            Console.WriteLine("\n---- Enter details of player  ----\n");
            Console.Write("Enter name of player: ");
            string pN = Console.ReadLine();
            Console.Write("Player health: ");
            int pH = int.Parse(Console.ReadLine());
            Console.Write("Player max health: ");
            int maxPH = int.Parse(Console.ReadLine());
            Console.Write("player energy: ");
            float pE = float.Parse(Console.ReadLine());
            Console.Write("Player max energy: ");
            int maxPE = int.Parse(Console.ReadLine());
            Console.Write("Player Armour: ");
            int armour = int.Parse(Console.ReadLine());
            Player p = new Player(pN, pH, maxPH, pE, maxPE, armour);
            Plist.Add(p);
        }
        static void addStats(List<Stats> Slist)
        {
            Console.Clear();
            Console.WriteLine("Enter skill statistics of player 1");
            Console.Write("\nEnter skill name: ");
            string skillName = Console.ReadLine();
            Console.Write("Damage: ");
            int damage = int.Parse(Console.ReadLine());
            Console.Write("Penetration: ");
            float penetration = float.Parse(Console.ReadLine());
            Console.Write("Heal: ");
            int heal = int.Parse(Console.ReadLine());
            Console.Write("Cost: ");
            float cost = float.Parse(Console.ReadLine());            
            Console.Write("Description: ");
            string skillDesc = Console.ReadLine();
            Stats S = new Stats(skillName, damage, penetration, heal,cost, skillDesc);
            Slist.Add(S);
        }

        static void dispPinfo(List<Player> Plist)
        {
            Console.Clear();
            Console.Write("Enter name of player of which you want to see Info: ");
            string name = Console.ReadLine();
            for (int i = 0; i < Plist.Count; i++)
            {
                if (Plist[i].pN == name)
                {
                    Console.WriteLine("\nInfo of player  \n");
                    Console.Write("Health: " + Plist[i].pH + "\nPlayer max health: " + Plist[i].maxPH + "\nPlayer energy: "
                      + Plist[i].pE + "\nPlayer maximum energy: " + Plist[i].maxPE + "\nPlayer Armour is: " + Plist[i].armour);
                }
            }
        }
        static void learnSkill(string name, string skillName, List<Stats> Slist, List<Player> Plist)
        {

      
            Player p = Plist.Find(P => P.pN == name);
            Stats s = Slist.Find(S => S.skillName == skillName);
            if (p != null && s != null)
            {
                p.addSkill(s);
                Console.WriteLine("\nSkill added successfully .");
            }
            else
            {
                Console.WriteLine("\nPlayer or Skill not found");
            }
        }

    static void attack(List<Player> Plist, string attackerN, string targetN, string skill)
    {
           Player a=Plist.Find(p=> p.pN== attackerN);
           Player t = Plist.Find(p => p.pN == targetN);
           Stats inputSkill=a.playerSkillStatistics.Find(s=> s.skillName == skill);
            if (a!= null && t!= null && inputSkill != null)
            {
               string result= a.Attacker(a,t,inputSkill);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Attacker,Attacker skill or target player not found");
            }
        

    }
}
}
