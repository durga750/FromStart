using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int ESal { get; set; }

        public void Setvalues(int EId,string EName,int ESal)
        {
            this.EId = EId;
            this.EName = EName;
            this.ESal = ESal;
        }

        public void Getvalues()
        {
            Console.WriteLine(EId);
            Console.WriteLine(EName);
            Console.WriteLine(ESal);
        }


        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Setvalues(123, "durga", 35000);
            emp.Getvalues();
            Console.WriteLine("=============");
           Employee emp1 = new Employee() { EId = 345, EName = "mule", ESal = 445000 };
            emp1.Getvalues();
        }
    }
}
