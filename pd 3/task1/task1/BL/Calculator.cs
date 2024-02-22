using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Calculator
    {
        int numb1 = 10;
        int numb2 = 10;
        public Calculator()
        {

        }
        
        public void changeValues(int newVal1,int newVal2)
        {
            this.numb1=newVal1;
            this.numb2=newVal2;
        }
        public int add()
        {
            return numb1 + numb2;
        }
        public int subtract()
        {
            return numb1-numb2;
        }
        public int prod()
        {
            return numb1 * numb2;
        }
        public int division()
        {
            return numb1 / numb2;
        }
        public int modulo()
        {
            if (numb2 != 0)
            {
                return numb1 % numb2;
            }
            else
            {
                Console.WriteLine("error");
                return 0;
            }
        }
    }
}
