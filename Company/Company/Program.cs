using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee worker1 = new Employee();

            worker1.F = "Sarah";
            worker1.L = "Chapman";
            Department myDept = new Department("Mail Room");
            worker1.Dpt = myDept;

            Console.WriteLine(string.Format("started job {0}", worker1.HireDate));
            Console.WriteLine(string.Format("{0} {1} works for this Company", worker1.F, worker1.L));
            Console.WriteLine(string.Format("{0} works in the {1}.", worker1.F, worker1.Dpt.P));

            Console.ReadLine();

           
            



        }
    
    }
}
