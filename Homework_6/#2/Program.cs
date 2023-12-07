namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Введите количество строк в матрицах:");
            int AmmountOfStrokes = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в матрицах:");
            int AmmountOfColumns = int.Parse(Console.ReadLine());

            Console.WriteLine("Массив А:");
            int[,] mass_A = new int[AmmountOfStrokes, AmmountOfColumns];

            for (int i = 0; i < mass_A.GetLength(0); i++) //Заполнение массива А случайными цифрами
            {
             for (int j = 0; j < mass_A.GetLength(1); j++)
                {
                    mass_A[i, j] = rnd.Next(1, 11);
                    Console.Write($"{mass_A[i,j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМассив B:"); //Заполнение массива B случайными цифрами
            int[,] mass_B = new int[AmmountOfStrokes, AmmountOfColumns];
            for (int i = 0; i < mass_A.GetLength(0); i++)
            {
                for (int j = 0; j < mass_B.GetLength(1); j++)
                {
                    mass_B[i, j] = rnd.Next(1, 11);
                    Console.Write($"{mass_B[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nРезультат:");
            int[,] mass_C = new int[AmmountOfStrokes, AmmountOfColumns];

            for(int i = 0;i < mass_C.GetLength(0);i++) //Заполнение массива C суммой сложенных чисел из массивов A и B
            {
                for(int j = 0;j < mass_C.GetLength(1); j++)
                {
                    mass_C[i,j] = mass_A[i,j] + mass_B[i,j];
                    Console.Write($"{mass_C[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
