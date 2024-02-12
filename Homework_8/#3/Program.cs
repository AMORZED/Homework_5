using _IntExtension;
using _MyClass;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = MyClass.CreateArray(10);
            MyClass.ShowArray(array);

            Console.WriteLine($"Наибольшее значение в массиве: '{array.BiggestValue()}'");
        }
    }
}
