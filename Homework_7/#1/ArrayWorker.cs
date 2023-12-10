using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ArrayWorker
{
    public class ArrayWorker
    {
        public static void ArrayInverter(int[] originalArray, out int[] invertedArray)
        {
            invertedArray = new int[originalArray.Length]; //Создание инвертированного массива с длинной исходного
            for (int i = 0, j = (originalArray.Length - 1); i < originalArray.Length & j >= 0; i++, j--)
            {
                invertedArray[i] = originalArray[j];
            }
        }
    }
}
