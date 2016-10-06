using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public static class Utils
    {
        public static void Pay(Employee[] array)
        {
            for (int i = 0; i < array.Length; i++)

                Console.WriteLine(array[i].F + " got paid");
        }

    }
}
