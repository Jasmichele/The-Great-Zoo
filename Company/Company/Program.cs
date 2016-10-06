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
            worker1.DOb = "01/15/1990";
            worker1.SSN = "9871542783";
            Department myDept = new Department("Mail Room");
            worker1.Dpt = myDept;
            worker1.PayRate = 15000;
            worker1.Raise();
            worker1.PayGrade = 3;
            worker1.HoursWorekd = 40;

            Employee worker2 = new Employee();
            worker2.F = "Jessica";
            worker2.L = "Smith";
            worker2.DOb = "02/14/1978";
            worker2.SSN = "6789543782";
            Department myDept2 = new Department("Legal");
            worker2.Dpt = myDept2;
            worker2.PayRate = 60000;
            worker2.Raise();
            worker2.PayGrade = 7;
            worker2.HoursWorekd = 40;

            Employee worker3 = new Employee();
            worker3.F = "John";
            worker3.L = "Doe";
            worker3.DOb = "01/22/1988";
            worker3.SSN = "4537894";
            Department myDept3 = new Department("Legal");
            worker3.Dpt = myDept3;
            worker3.PayRate = 60000;
            worker3.Raise();
            worker3.PayGrade = 7;
            worker3.HoursWorekd = 40;


            Employee worker4 = new Employee();
            worker4.F = "Jane";
            worker4.L = "Doe";
            worker4.DOb = "11/22/1968";
            worker4.SSN = "984567294";
            Department myDept4 = new Department("Legal");
            worker4.Dpt = myDept4;
            worker4.PayRate = 80000;
            worker4.Raise();
            worker4.PayGrade = 9;
            worker4.HoursWorekd = 40;

            Employee worker5 = new Employee();
            worker5.F = "Wilsom";
            worker5.L = "Parker";
            worker5.DOb = "05/02/1953";
            worker5.SSN = "783946530";
            Department myDept5 = new Department("Custodial");
            worker5.Dpt = myDept4;
            worker5.PayRate = 8000;
            worker5.Raise();
            worker5.PayGrade = 1;
            worker5.HoursWorekd = 40;

            Employee[] myArray = new Employee[5];

            myArray[0] = worker1;
            myArray[1] = worker2;
            myArray[2] = worker3;
            myArray[3] = worker4;
            myArray[4] = worker5;

            Utils.Pay(myArray);







            Console.ReadLine();

           
            



        }
    
    }
}
