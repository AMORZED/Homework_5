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
        private Item[] items = new Item[8];
        
        private bool IsOpen;

        public void OpenBag() //Открытие и закрытие сумки
        {
         if (IsOpen == false) 
            { 
                IsOpen = true;
                Console.WriteLine("Вы открыли сумку!");
            }
         else if (IsOpen == true) 
            { 
                IsOpen = false;
                Console.WriteLine("Вы закрыли сумку!");
            }
        }
        public void AddItemInBag(Item it) //Добавление объекта в сумку
        {
            if (IsOpen == false) 
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
                        items[i] = it;
                        Console.WriteLine($"Вещь \"{it.GetName()}\" положена в сумку!");
                        break;
                    }
                }
            }
        }
        public Item GetItem(int index) //Получение объекта из сумки по индексу
        {
            Item returnedItem = null;
            if (IsOpen == false)
            {
                Console.WriteLine("\nСумка закрыта!");
                return returnedItem;
            }
            else
            {
                returnedItem = items[index];
                Console.WriteLine($"\nВещь \"{returnedItem.GetName()}\" вынута из сумки!");
                items[index] = null;
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
            Console.Write("Содержимое сумки:   ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " | ");
            }
        }
    }
}
