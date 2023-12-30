﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class GroundGrains
    {
        Random rnd = new Random();
        internal enum strength { Low, Medium, High }
        internal strength str;
        internal int volume;
        public GroundGrains()
        {
            SetStrength();
            SetVolume();
        }

        internal void SetStrength()
        {
            int random = rnd.Next(0, 3);
            this.str = (strength)random;
        }
        public void SetVolume()
        {
            int random = rnd.Next(20, 41);
            this.volume = random;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("МОЛОТЫЕ ЗЕРНА");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----");
            Console.WriteLine($"Крепость: {this.str}");
            Console.WriteLine($"Обьем: {this.volume} мл.");
            Console.WriteLine();
        }
        public static Coffee operator+ ( Water w, GroundGrains g )
        {
            Coffee coffee = new Coffee();

            int coffeeVolume = w.volume + g.volume; 
            coffee.SetVolume(coffeeVolume); //Конечный объем кофе

            coffee.SetTemperature((int)w.temp); //Конечная температура кофе (зависит напрямую от температуры воды)

            int coffeeRating = 6; //Оценка кофе при горячей воде, крепких зернах и объеме меньше 200 мл. (снижается в зависимости от характеристик ингредиентов)

            if (w.temp == Water.temperature.Warm) { coffeeRating -= 1; }
            else if (w.temp == Water.temperature.Cool) { coffeeRating -= 2; }

            if (coffeeVolume >= 200 & coffeeVolume < 300) { coffeeRating -= 1; }
            else if (coffeeVolume >= 300) { coffeeRating -= 2; }

            if (g.str == GroundGrains.strength.Medium) { coffeeRating -= 1; }
            else if (g.str == GroundGrains.strength.Low) { coffeeRating -= 2; }

            if (coffeeRating >= 5) coffee.SetStrength(Coffee.strength.High);
            else if (coffeeRating >= 3) coffee.SetStrength(Coffee.strength.Medium);
            else if (coffeeRating <= 2) coffee.SetStrength(Coffee.strength.Low);

            return coffee;
        }
    }
}
