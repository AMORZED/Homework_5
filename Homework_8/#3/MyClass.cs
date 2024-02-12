namespace _MyClass
{
    internal class MyClass
    {
        public static int[] CreateArray(int length)
        {
            Random rnd = new Random();
            int[] newArray = new int[length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = rnd.Next(1, 101);
            }

            return newArray;
        }

        public static void ShowArray(int[] array)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("МАССИВ:");
            Console.ResetColor();

            for (int i = 0;i < array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
