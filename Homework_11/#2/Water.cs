using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Water
    {
        Random rnd = new Random();
        internal enum temperature { Cool, Warm, Hot }
        internal temperature temp;
        internal int volume;

        public Water() 
        {
            SetTemperature();
            SetVolume();
        }

        public void SetTemperature () //Случайная температура
        {
            int random = rnd.Next(0, 3);
            this.temp = (temperature)random;
        }
        public void SetVolume () //Случайный объем
        {
            int random = rnd.Next(100, 301);
            this.volume = random;
        }
        public void Show() //Вывод характеристик на экран
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ВОДА");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----");
            Console.WriteLine($"Температура: {this.temp}");
            Console.WriteLine($"Обьем: {this.volume} мл.");
            Console.WriteLine();
        }
    }
}
