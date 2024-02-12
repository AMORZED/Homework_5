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
            invertedArray = new int[originalArray.Length]; //Создание пустого инвертированного массива с длинной исходного
            for (int i = 0, j = (originalArray.Length - 1); i < originalArray.Length & j >= 0; i++, j--) //Внесение в созданный массив значений из оригинального массива в обратном порядке
            {
                invertedArray[i] = originalArray[j];
            }
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public static int[] CreateArrayWithRandomNumbers(int lengthOfArray)
        {
            int[] array = new int[lengthOfArray];
            Random rnd = new Random();

            for (int i = 0;i < array.Length;i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            return array;
        }
    }
}
