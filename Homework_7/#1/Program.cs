using _ArrayWorker;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = ArrayWorker.CreateArrayWithRandomNumbers(10);

            Console.WriteLine("Исходный массив со случайными числами:"); //Создание исходного массива
            ArrayWorker.ShowArray(originalArray);
            Console.WriteLine();

            ArrayWorker.ArrayInverter(originalArray, out int[] invertedArray);

            Console.WriteLine("Инвертированный массив:");
            ArrayWorker.ShowArray(invertedArray);
        }
    }
}
