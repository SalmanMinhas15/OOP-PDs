using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Calculator
    {
        int numb1 = 10;
        int numb2 = 20;
        public Calculator()
        {

        }
        public Calculator(int num)
        {
            this.numb1 = num;
        }
        public double sqr(int num)
        {
            return Math.Sqrt(num);
        }
        public double exponent(int num)
        {
            return Math.Pow(num,num);
        }
        public double log(int num)
        {
            return Math.Log(num);
        }
        public double sin(int num)
        {
            return Math.Sin(num);
        }
        public double cos(int num)
        {
            return Math.Cos(num);
        }
        public double tan(int num)
        {
            return Math.Tan(num);
        }
    }  
}
