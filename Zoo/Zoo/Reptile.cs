using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Reptile : Animal
    {
        #region variables
        bool swim;
        string habitat;

        #endregion

        public Reptile()
        {

        }

        #region properties
        public bool Swim
        {
            get
            {
                return swim;
            }

            set
            {
                swim = value;
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
