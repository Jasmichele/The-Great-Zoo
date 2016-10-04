using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Human : Mammals
    {
        #region variable
        double howTall;
        string boyOrGirl;

        

        #endregion

        public Human()
        {
            base.HowManylegs = 2;
        }

        #region properties
        public double HowTall
        {
            get
            {
                return howTall;
            }

            set
            {
                howTall = value;
            }
        }

        public string BoyOrGirl
        {
            get
            {
                return boyOrGirl;
            }

            set
            {
                boyOrGirl = value;
            }
        }
    }
    #endregion
}
