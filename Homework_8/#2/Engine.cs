namespace _Engine
{
    public class Engine 
    {
        private bool isStarted = false;
        public void SwitchEngine()
        {
            if (isStarted == false)
            {
                isStarted = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Двигатель транспорта запущен!");
                Console.ResetColor();
            }
            else
            {
                isStarted = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Двигатель транспорта остановлен!");
                Console.ResetColor();
            }
        }

    }
}
