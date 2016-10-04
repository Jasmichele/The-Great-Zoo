using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Flamingo : Bird
    {
        #region variables
        string coloredBeak;
        string coloredLegs;

        #endregion

        public Flamingo()
        {

        }



        #region properties
        public string ColoredBeak
        {
            get
            {
                return coloredBeak;
            }

            set
            {
                coloredBeak = value;
            }
        }

        public string ColoredLegs
        {
            get
            {
                return coloredLegs;
            }

            set
            {
                coloredLegs = value;
            }
        }

        #endregion
    }
}
