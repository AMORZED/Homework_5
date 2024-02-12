namespace _Queue
{
    public class Queue
    {      
        
        public Queue(int length) 
        { 
            Random rnd = new Random();
            int[] newQueue = new int[length];

            for (int i = 0; i < length; i++)
            {
                newQueue[i] = rnd.Next(1, 101);
            }

            queue = newQueue;
        }

        public void Show() // Отображение текущего содержимого очереди
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Текущее содержимое очереди:");
            Console.ResetColor();

            for (int i = 0; i < queue.Length; i++)
            {
                Console.Write(queue[i] + " ");
            }

            Console.WriteLine();
        }

        public void IsEmpty() // Проверка очереди на наличие элементов
        {
            if (queue.Length == 0 | queue == null) Console.WriteLine("Очередь пуста!");
            else Console.WriteLine("Очередь не пуста!");
            Console.WriteLine();
        }

        public void Push(int newMember) // Запись нового элемента в очередь
        {
            Array.Resize(ref queue, queue.Length + 1);
            queue[queue.Length - 1] = newMember;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"В очередь добавлен элемент со значением '{newMember}'!");
            Console.ResetColor();
        }

        public int Pop() // Возврат первого элемента из очереди и удаление его из очереди
        {
            int lastRemovedMember;
            
            if (queue.Length == 0)
            {
                Console.WriteLine("Очередь пуста!");
                return 0;
            }
            else
            {
                lastRemovedMember = queue[0];
                for (int i = 0, j = 1; i < queue.Length & j < queue.Length; i++, j++)
                {
                    queue[i] = queue[j];
                }
                Array.Resize(ref queue, queue.Length - 1);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Из очереди удален элемент со значением '{lastRemovedMember}'!");
                Console.ResetColor();

                return lastRemovedMember;
            }
        }
        public void Size() // Отображение размера очереди
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Кол-во элементов в очереди: " + queue.Length);
            Console.ResetColor();
        }

        private int[] queue;
    }
}
