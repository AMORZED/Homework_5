namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое надо умножать:");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число, до которого будет выполняться умножение:");
            int maxNum = int.Parse(Console.ReadLine());
            Console.WriteLine(); //Просто пустая строка

            for (int i = 1; i <= maxNum; i++)
            {
                int result = baseNum * i;
                Console.WriteLine($"{baseNum}x{i}={result}");
            }
        }
    }
}
