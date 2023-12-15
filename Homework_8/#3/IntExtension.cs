using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _IntExtension
{
    public static class IntExtension
    {
        public static int BiggestValue(this int[] array)
        {
            int BiggestValue = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (BiggestValue < array[i]) BiggestValue = array[i];
            }
            return BiggestValue;
        }
    }
}
