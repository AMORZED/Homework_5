namespace _Stack
{
    public class Stack
    {
        public Stack(int length)
        {
            Random rnd = new Random();
            int[] newStack = new int[length];

            for (int i = 0; i < length; i++)
            {
                newStack[i] = rnd.Next(1, 101);
            }

            stack = newStack;
        }
        public void Show() // Отображение текущего содержимого стека
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Текущее содержимое стека:");
            Console.ResetColor();

            for (int i = 0; i < stack.Length; i++) 
            {
                Console.Write(stack[i] + " ");
            }

            Console.WriteLine();
        }

        public void IsEmpty() // Проверка стека на наличие элементов
        {
            if (stack.Length == 0 | stack == null)
            {
                Console.WriteLine("Стек пуст!");
            }
            else
            {
                Console.WriteLine("Стек не пуст!");
            }

            Console.WriteLine();
        }

        public void Push(int newMember) // Запись нового элемента в стек
        {
            Array.Resize(ref stack, stack.Length + 1);
            stack[stack.Length - 1] = newMember;

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"В стек записан элемент со значением '{newMember}'!");
            Console.ResetColor();
        }

        public int Pop() // Возврат верхнего элемента из стека
        {
            int lastRemovedMember;
            
            if (this.stack.Length == 0)
            {
                Console.WriteLine("Стек пуст!");
                return 0;
            }
            else
            {
                lastRemovedMember = stack[stack.Length - 1];
                Array.Resize(ref stack, stack.Length - 1);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Удален верхний элемент стека со значением '{lastRemovedMember}'!");
                Console.ResetColor();

                return lastRemovedMember;
            }
        }

        private int[] stack;
    }
}
