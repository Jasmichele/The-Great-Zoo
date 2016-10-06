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
        bool isHired;





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

        public double PayRate
        {
            get
            {
                return payRate;
            }

            set
            {
                payRate = value;
            }
        }

        public bool IsHired
        {
            get
            {
                return isHired;
            }

        }

        public bool PayEmployee
        {
            set
            {
                if (isHired)
                {
                    isHired = true;
                }
                else if (!isHired)
                {
                    isHired = false;
                }

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

        public double Raise()
        {
           
            return payRate * 1.04;
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
         public void Fire(DateTime y)
        {
            terminateDate = y;
            y = DateTime.Today;
        }






    }
}
