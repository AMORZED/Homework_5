using _Item;

namespace _Bag
{
    public class Bag
    {
        public void OpenBag() // Открытие и закрытие сумки
        {
            if (isOpen == false) 
            {
                isOpen = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы открыли сумку!");
                Console.ResetColor();
            }
            else
            {
                isOpen = false;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы закрыли сумку!");
                Console.ResetColor();
            }
        }
        public void AddItemInBag(Item it) // Добавление объекта в сумку
        {
            if (isOpen == false) 
            {
                Console.WriteLine("Сумка закрыта, невозможно добавить объект!"); 
            }
            else if (isFilled == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В сумке нет места, невозможно добавить объект!");
                Console.ResetColor();
            }
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == null)
                    {
                        items[i] = it;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Вещь '{it.GetName()}' была положена в сумку!");
                        Console.ResetColor();
                        break;
                    }
                }
            }
        }
        public Item GetItem(int index) // Получение объекта из сумки по индексу
        {
            Item returnedItem;

            if (isOpen == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Сумка закрыта, нельзя достать вещь!");
                Console.ResetColor();
                return null;
            }
            else
            {
                returnedItem = items[index];
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вещь '{returnedItem.GetName()}' была вынута из сумки!");
                Console.ResetColor();
                items[index] = null;
                return returnedItem;
            }
        }
        public bool BagIsFilled()  // Проверка сумки на наличие свободного места
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    isFilled = false;
                }
                else
                {
                    isFilled = true;
                }
            }

            return isFilled;
        }
        public void Show() // Отображение содержимого сумки
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Содержимое сумки: ");
            Console.ResetColor();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    Console.Write(items[i].GetName() + " | ");
                }
                else
                {
                    Console.Write(" | ");
                }
            }

            Console.WriteLine();
        }

        private Item[] items = new Item[8];

        private bool isOpen;
        private bool isFilled;
    }
}
