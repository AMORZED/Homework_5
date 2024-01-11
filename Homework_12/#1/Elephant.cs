using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1
{
    internal class Elephant : Animal, IHerbivore, IEquatable<Elephant>
    {
        private string sound;
        private string colour;
        private int size;

        public string typeH { get { return "Травоядный"; } }
        public string foodH { get { return "Трава"; } }

        public Elephant (string sound, string colour)
        {
            Console.WriteLine("Введите имя слона:");
            this.name = Convert.ToString(Console.ReadLine());
            this.sound = sound;
            this.colour = colour;
            this.numOfLegs = 4;
            SetRandomSize();
        }

        public void displayEatH()
        {
            Console.Write(this.foodH);
        }
        public void SetRandomSize()
        {
            Random rnd = new Random();
            this.size = (int)rnd.Next(1, 21);
        }
        public override void displayAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("СЛОН");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" - ");
            Console.Write("Имя: " + getName());
            Console.Write(" | ");
            Console.Write("Тип: " + this.typeH);
            Console.Write(" | ");
            Console.Write("Чем питается: " + this.foodH);
            Console.Write(" | ");
            Console.Write("Цвет: " + this.colour);
            Console.Write(" | ");
            Console.Write("Издает звук: " + this.sound);
            Console.Write(" | ");
            Console.Write("Количество лап: " + getNumOfLegs());
            Console.WriteLine();
            Console.Write("Размер: " + this.size);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public int GetSize()
        {
            return this.size;
        }

        public bool Equals(Elephant otherElephant)
        {
            if (otherElephant == null)
            {
                return false;
            }
            if (this.size == otherElephant.GetSize())
            {
                return true;
            }
            else return false;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Elephant elephantObj = obj as Elephant;
            
            if (elephantObj == null)
            {
                return false;
            }
            else return Equals(elephantObj);
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
