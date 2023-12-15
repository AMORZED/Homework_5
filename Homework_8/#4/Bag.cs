using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _Item;

namespace _Bag
{
    public class Bag
    {
        Item item1 = new Item();

        private Item[] items = new Item[8];
        
        private bool BagIsOpen;

        public void OpenBag() //Открытие и закрытие сумки
        {
         if (BagIsOpen == false) 
            { 
                BagIsOpen = true;
                Console.WriteLine("Вы открыли сумку!");
            }
         else if (BagIsOpen == true) 
            { 
                BagIsOpen = false;
                Console.WriteLine("Вы закрыли сумку!");
            }
        }
        public void AddItemInBag() //Добавление объекта в сумку
        {
            if (BagIsOpen == false) 
            {
                Console.WriteLine("\nСумка закрыта, невозможно добавить объект!"); 
            }
            else if (BagIsFilled() == true)
            {
                Console.WriteLine("\nВ сумке нет места, невозможно добавить объект!");
            }
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == null)
                    {
                        items[i] = item1;
                        Console.WriteLine($"Вещь \"{item1.GetName()}\" положена в сумку!");
                        break;
                    }
                }
            }
        }
        public object GetItemFromBag(int index) //Получение объекта из сумки по индексу
        {
            object returnedItem = null;
            if (BagIsOpen == false)
            {
                Console.WriteLine("\nСумка закрыта!");
                return returnedItem;
            }
            else
            {
                returnedItem = items[index];
                items[index] = null;
                Console.WriteLine($"Вещь \"{items[index]}\" вынута из сумки!");
                return returnedItem;
            }
        }
            public bool BagIsFilled()  //Проверка сумки на наличие свободного места
        {
            bool isFilled = false;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null) isFilled = false;
                else isFilled = true;
            }
            return isFilled;
        }
        public void Show() //Отображение содержимого сумки
        {
            for(int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " | ");
            }
        }
    }
}
