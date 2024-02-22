using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2_and_3.BL
{
    internal class Stats
    {
        public string skillName;
        public int damage;
        public string skillDesc;
        public float penetration;
        public float cost;  //    cost : energy points
        public int heal;

        public Stats() 
        { 
        
        }
        public Stats(string skillName,int damage,float penetration,int heal,float cost,string description)
        {
            this.skillName = skillName;
            this.damage = damage;
            this.penetration = penetration;
            this.cost = cost;
            this.heal = heal;
            this.skillDesc = description;
        }
        

    }
}
