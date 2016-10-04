using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mammals : Animal
    {
        #region variables
        bool impossibeThumb;
        string habitat;

        #endregion

        public Mammals()
        {

        }

        #region Properties

        public bool ImpossibeThumb
        {
            get
            {
                return impossibeThumb;
            }

            set
            {
                impossibeThumb = value;
            }
        }

        public string Habitat
        {
            get
            {
                return habitat;
            }

            set
            {
                habitat = value;
            }
        }


        #endregion
    }
}
