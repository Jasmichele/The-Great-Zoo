using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public abstract class Person
    {
        #region variables

        string f, l;
        string dOb;
        string sSN;

        #endregion


        #region Properties
        public string F
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        public string L
        {
            get
            {
                return l;
            }

            set
            {
                l = value;
            }
        }

        public string DOb
        {
            get
            {
                return dOb;
            }

            set
            {
                dOb = value;
            }
        }

        public string SSN
        {
            get
            {
                return sSN;
            }

            set
            {
                sSN = value;
            }

            #endregion
        }
    }



}
