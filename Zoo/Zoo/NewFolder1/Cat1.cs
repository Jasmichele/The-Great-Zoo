using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Cat1 : Mammals
    {
        #region variables
        bool wild;
        string femaleMale;

       

        #endregion

        public Cat1()
        {
            base.HowManylegs = 4;
        }

        #region properties
        public bool Wild
        {
            get
            {
                return wild;
            }

            set
            {
                wild = value;
            }
        }

        public string FemaleMale
        {
            get
            {
                return femaleMale;
            }

            set
            {
                femaleMale = value;
            }
        }
        #endregion
    }
}
