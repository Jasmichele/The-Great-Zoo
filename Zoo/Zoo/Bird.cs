using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Bird :Animal
    {
        #region variables
        bool fly;
        string nestType;

        #endregion

        public Bird()
        {

        }


        #region properties

        public bool Fly
        {
            get
            {
                return fly;
            }

            set
            {
                fly = value;
            }
        }

        public string NestType
        {
            get
            {
                return nestType;
            }

            set
            {
                nestType = value;
            }
        }

        #endregion
    }
}
