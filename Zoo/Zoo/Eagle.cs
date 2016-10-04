using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Eagle : Bird
    {
        #region variables
        string headColor;
        bool usaOnly;

        #endregion

        public Eagle()
        {

        }

        #region properties
        public string HeadColor
        {
            get
            {
                return headColor;
            }

            set
            {
                headColor = value;
            }
        }

        public bool UsaOnly
        {
            get
            {
                return usaOnly;
            }

            set
            {
                usaOnly = value;
            }
        }
        #endregion
    }
}
