using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Department
    {
        #region varibles

        string p;

        #endregion

        public Department(string spot)
        {
            p = spot;
        }

        public void Place(string managerf, string mangerl, string location)
        {
            P = location;
        }

        #region Properties
        public string P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }

        #endregion




    }
}
