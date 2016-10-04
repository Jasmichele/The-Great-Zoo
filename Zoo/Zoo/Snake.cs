using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Snake : Reptile
    {
        #region variables
        bool rattler;
        bool poisiness;

      

        #endregion

        public Snake()
        {

        }

        #region properties
        public bool Rattler
        {
            get
            {
                return rattler;
            }

            set
            {
                rattler = value;
            }
        }

        public bool Poisiness
        {
            get
            {
                return poisiness;
            }

            set
            {
                poisiness = value;
            }
        }
        #endregion
    }
}
