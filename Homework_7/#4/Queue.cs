using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Queue
{
    public class Queue
    {
        private object[] queue = new object[5] { "String", 27015, 15.32D, 'A', default(bool) };
        public void Show() //Отображение текущего содержимого очереди
        {
            Console.WriteLine("Текущее содержимое очереди:");
            for (int i = 0; i < queue.Length; i++)
            {
                Console.Write(queue[i] + " | ");
            }
            Console.WriteLine("\n");
        }

        public void IsEmpty() //Проверка очереди на наличие элементов
        {
            if (queue.Length == 0 | queue == null) Console.WriteLine("Очередь пуста!");
            else Console.WriteLine("Очередь не пуста!");
            Console.WriteLine();
        }

        public void Push(object newMember) //Запись нового элемента в очередь
        {
            Array.Resize(ref queue, queue.Length + 1);
            queue[queue.Length - 1] = newMember;
        }

        public object Pop() //Возврат первого элемента из очереди и удаление его из очереди
        {
            object lastRemovedMember; //Переменная для записи удаленного элемента
            
            if (queue.Length == 0 | queue == null)
            {
                Console.WriteLine("Очередь пуста!");
                return lastRemovedMember = null;
            }
            else
            {
                lastRemovedMember = queue[0];
                for (int i = 0, j = 1; i < queue.Length & j < queue.Length; i++, j++) //Смещение элементов очереди на -1
                {
                    queue[i] = queue[j];
                }
                Array.Resize(ref queue, queue.Length - 1); //Удаление последнего элемнта очереди
                return lastRemovedMember;
            }
        }
        public void Size() //Отображение размера очереди
        {
            Console.WriteLine("Кол-во элементов в очереди: " + queue.Length);
        }
    }
}
