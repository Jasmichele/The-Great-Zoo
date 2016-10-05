using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public class Employee : Person
    {
        #region variables
        DateTime hireDate;
        DateTime terminateDate; 
        double payGrade;
        double hoursWorekd;
        double payRate;
        Department dpt;
       
        
        
        
 
        #endregion

        public Employee() 
        {
            
        }

        #region Proerties
        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
       }

        public DateTime TerminateDate
        {
            get
            {
                return terminateDate;
            }
        }

        public double PayGrade
        {
            get
            {
                return payGrade;
            }

            set
            {
                payGrade = value;
            }
        }

        public double HoursWorekd
        {
            get
            {
                return hoursWorekd;
            }

            set
            {
                hoursWorekd = value;
            }
        }

        public double PayRate
        {
            get
            {
                return payRate;
            }

        }

        public Department Dpt
        {
            get
            {
                return dpt;
            }

            set
            {
                dpt = value;
            }
        }
        #endregion
        public virtual void ChangeName(string first, string last)
        {
            F = first;
            L = last;
        }

        public void Start(DateTime y)
        {
            hireDate = y;
            y = DateTime.Today.AddYears(-1);
        }

        //public void Raise(double more)
        //{
        //    payRate * 1.04 = more;
        //}



    }
}
