using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Employee
    {
        public string empName;
        public int empAge;
      
        public int empSalary;
        public List<Employee> empList=new List<Employee>();
        public Employee()
        {

        }
        public Employee(string empName, int empAge, int empSalary)
        {
            this.empName = empName;
            this.empAge = empAge;
            this.empSalary = empSalary;
        }
        public void addEmp(Employee emp)
        {
            empList.Add(emp);
            Console.WriteLine("\nEmployee added successfully");
        }
        public void viewList()
        {
            Console.Write("\n     Employee name\tAge\tSalary\n");
            for (int i = 0; i < empList.Count; i++)
            {
                Console.WriteLine(" " + i + 1 + " " + empList[i].empName
                + "\t        " + empList[i].empAge + "\t          " + empList[i].empSalary);
            }
        }
        public void removeEmp(string name)
        {
            bool result = false;
            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].empName == name)
                {
                    empList.RemoveAt(i);
                    Console.WriteLine("\nItem removed successfully");
                    result = true;
                }
            }
            if (!result)
            {
                Console.WriteLine("\nInvalid");
            }
        }
    }
}
