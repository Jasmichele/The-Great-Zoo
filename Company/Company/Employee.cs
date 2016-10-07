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
        string hire;
        string terminateDate;
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

        public string Hire
        {
            get
            {
                return hire;
            }

            set
            {
                hire = value;
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

     
 






    }
}
