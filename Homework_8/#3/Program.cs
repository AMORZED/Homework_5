using _IntExtension;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random rnd = new Random();

            Console.WriteLine("Имеющийся массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " | ");
            }
            Console.WriteLine();

            Console.WriteLine($"Наибольшее значение в массиве: \"{ array.BiggestValue()}\"");
        }
    }
}
