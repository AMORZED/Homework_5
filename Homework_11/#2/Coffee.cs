using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Coffee
    {
        internal enum strength { Low, Medium, High }
        internal enum temperature { Cool, Warm, Hot }
        private strength str;
        private int volume;
        private temperature temp;

        internal void SetVolume(int a) //Установка объема кофе
        { 
            this.volume = a;
        }

        internal void SetStrength (strength a) //Установка крепости кофе
        {
            this.str = a;
        }

        internal void SetTemperature(int a) //Установка температуры кофе
        {
            this.temp = (temperature)a;
        }
        public void Show () //Вывод характеристик на экран
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("КОФЕ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----");
            Console.WriteLine($"Крепость: {this.str}");
            Console.WriteLine($"Обьем: {this.volume} мл.");
            Console.WriteLine($"Температура: {this.temp}");
            Console.WriteLine();
        }
    }
}
