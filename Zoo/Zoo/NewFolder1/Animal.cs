using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        #region variable
        string color;
        int howManylegs;
        bool hasTeeth;



        #endregion

        public Animal()
        {

        }

        #region properties

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int HowManylegs
        {
            get
            {
                return howManylegs;
            }

            set
            {
                howManylegs = value;
            }
        }

        public bool HasTeeth
        {
            get
            {
                return hasTeeth;
            }

            set
            {
                hasTeeth = value;
            }
        }

        #endregion
    }
}