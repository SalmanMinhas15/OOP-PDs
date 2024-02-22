using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2_and_3.BL
{
    internal class Player
    {
        public string pN;
        public int pH;
        public int maxPH;
        public float pE;
        public int maxPE;
        public int armour;
        public List<Stats> playerSkillStatistics=new List<Stats>(); // skillStatistics

        public Player()
        {

        }
        public Player(string pN, int pH, int maxPH, float pE, int maxPE, int armour)
        {
            this.pN = pN;
            this.pH = pH;
            this.maxPH = maxPH;
            this.pE = pE;
            this.maxPE = maxPE;
            this.armour = armour;
            
        }
        

        public void addSkill(Stats s)
        {
            playerSkillStatistics.Add(s);
        }
        public string Attacker(Player a,Player t,Stats s)
        {
            string result = "";
            if(s.cost>a.pE)
            {
                result = a.pN + " attempted to attack using " + s.skillName + " skill but not have enough energy";
            }
            else
            {
                a.pE-=s.cost;
            }
            float effectArmour = t.armour - s.penetration;
            if(effectArmour < 0)
            {
                effectArmour = 0;
            }
            float damageResult = s.damage * ((100 - effectArmour) / 100);
             result = a.pN + " used " + s.skillName + " , " + s.skillDesc + " against "
                + t.pN + " doing "+damageResult+" damage !\n";
            t.pH = t.pH-(int)damageResult;
            if(s.heal!=0 && s.heal>0)
            {
                a.pH += s.heal;
                result += a.pN + " healed for " + s.heal + " health ! ";
            }
            if(t.pH<=0)
            {
                result += t.pN + " died";
            }
            else
            {
                float tPercent = ((float)t.pH / t.maxPH) * 100;
                result += t.pN + " is at " + tPercent + " % health";
            }
            return result;
        }

    }
}
