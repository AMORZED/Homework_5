using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Water
    {
        internal enum temperature { Cool, Warm, Hot }
        internal temperature temp;
        internal int volume;

        public Water() 
        {
            SetRandomTemperature();
            SetRandomVolume();
        }

        public void SetRandomTemperature ()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 3);
            this.temp = (temperature)random;
        }
        public void SetRandomVolume ()
        {
            Random rnd = new Random();
            int random = rnd.Next(100, 301);
            this.volume = random;
        }
        public void Show()
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
