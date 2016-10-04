using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Turtle : Reptile
    {
        #region variables
        bool snapping;
        string speed;

        #endregion

        public Turtle()
        {
            base.HowManylegs = 4;
        }

        #region propertie

        public bool Snapping
        {
            get
            {
                return snapping;
            }

            set
            {
                snapping = value;
            }
        }

        public string Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        #endregion
    }
}
