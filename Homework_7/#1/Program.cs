using _ArrayWorker;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.WriteLine("Исходный массив со случайными числами:"); //Создание исходного массива
            int[] originalArray = new int[5];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = rnd.Next(1, 11);
                Console.Write(originalArray[i] + " ");
            }
            ArrayWorker.ArrayInverter(originalArray, out int[] invertedArray); //Вызов метода инвертирования массива в классе ArrayWorker

            Console.WriteLine("\nИнвертированный массив:"); //Отображение инвертированного массива
            for (int i = 0; i < invertedArray.Length; i++)
            {
                Console.Write(invertedArray[i] + " ");
            }
        }
    }
}
