using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Bear : Animal, ICarnivore, IHerbivore
    {

        private string sound;
        private string colour;

        public string typeC { get { return "Хищник"; } }

        public string foodC { get { return "Мясо"; } }

        public string typeH { get { return "Травоядный"; } }

        public string foodH { get { return "Трава"; } }

        public Bear (string sound, string colour)
        {
            Console.WriteLine("Введите имя медведя:");
            this.name = Convert.ToString(Console.ReadLine());
            this.sound = sound;
            this.colour = colour;
            this.numOfLegs = 4;
        }

        public void displayEatH()
        {
            Console.Write(this.foodH);
        }
        public void displayEatC()
        {
            Console.Write(this.foodC);
        }
        public override void displayAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("МЕДВЕДЬ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" - ");
            Console.Write("Имя: " + getName());
            Console.Write(" | ");
            Console.Write("Тип: " + this.typeC);
            Console.Write(" | ");
            Console.Write("Чем питается: " + this.foodC);
            Console.Write(" | ");
            Console.Write("Цвет: " + this.colour);
            Console.Write(" | ");
            Console.Write("Издает звук: " + this.sound);
            Console.Write(" | ");
            Console.Write("Количество лап: " + getNumOfLegs());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
