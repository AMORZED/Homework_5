using System.Threading.Channels;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mass = new string[5] {"One", "Two", "Three", "Four", "Five"};
           
            Console.WriteLine("Массив до изменений:");
            for (int i = 0; i < mass.Length; i++)
            {             
                Console.Write(mass[i] + " | ");
            }

            Console.WriteLine("\n\nВведите значение строки:");
            string word = Convert.ToString(Console.ReadLine());

            Operate(ref word, ref mass);

            Console.WriteLine("\nМассив после изменений:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " | ");
            }
            
        }
        static object Operate(ref string word, ref string[] mass)
        {
            if (mass == null | mass.Length == 0)
            {
                Console.WriteLine("\nМассив невалиден(пуст)!");
                return null;
            }
            else if (word == null | string.IsNullOrEmpty(word) == true)
            {
                Console.WriteLine("\nСтрока невалидна(пуста)!");
                return null;
            }
            else
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == word)
                    {
                        Console.WriteLine("\nМассив уже содержит этот элемент, изменений не произошло!");
                        return mass;
                    }
                    
                                       
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == null | string.IsNullOrEmpty(mass[i]) == true)
                    {
                        Console.WriteLine($"\nЭлемент в массиве с индексом '{i}' оказался пустым, поэтому ему присвоено значение '{word}'!");
                        mass[i] = word;
                        return mass;
                    }
                }

                Console.WriteLine("\nВ массиве нет места для нового элемента, поэтому он будет расширен на один элемент!");
                Array.Resize(ref mass, mass.Length + 1);
                mass[mass.Length - 1] = word;
                return mass;
            }
        }
    }
}
