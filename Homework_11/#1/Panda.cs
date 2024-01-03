using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    internal class Panda
    {
        enum Gender { Male = 1, Femail = 2 };
        enum Color { WhiteBlack = 1, Black = 2, White = 3 };
        
        private Gender gender = 0;        
        private Color color = 0;
        private int hp { get; set; }
        private int attack { get; set; }
        private int defence { get; set; }
        private string name;

        public Panda ()
        {
            SetName();
            SetRandomGender();
            SetRandomColor();
            SetRandomHP();
            SetRandomAttack();
            SetRandomDefence();
        }
        public Panda(string name)
        {
            this.name = name;
            SetRandomGender();
            SetRandomColor();
            SetRandomHP();
            SetRandomAttack();
            SetRandomDefence();
        }

        public void SetName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите имя новой панды:");
            Console.ForegroundColor = ConsoleColor.Gray;
            this.name = Convert.ToString(Console.ReadLine());
        }
        public void SetRandomGender()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 3);
            this.gender = (Gender)random;
        }
        public void SetRandomColor()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 4);
            this.color = (Color)random;
        }

        public void SetRandomHP()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 101);
            this.hp = random;
        }
        public void SetRandomAttack()
        {
            Random rnd = new Random();
            int random = rnd.Next(5, 11);
            this.attack = random;
        }
        public void SetRandomDefence()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 6);
            this.defence = random;
        }
        public void ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Характеристики панды \"{this.name}\":");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine($"Пол: {this.gender}");
            Console.WriteLine($"Цвет: {this.color}");
            Console.WriteLine($"Здоровье: {this.hp} оз.");
            Console.WriteLine($"Атака: {this.attack} ур/с.");
            Console.WriteLine($"Защита: {this.defence} оз.");
            Console.WriteLine();
        }

        public static Panda operator+ ( Panda first, Panda second ) //Переопределение оператора "+"
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 3);            
            if (random == 1 & first.gender != second.gender)
            {
                Panda third = new Panda();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"У ПАНД \"{first.name}\" И \"{second.name}\" РОДИЛАСЬ МАЛЕНЬКАЯ ПАНДА!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                third.color = first.color;
                return third;
            }
            else if (random == 2 & first.gender != second.gender)
            {
                Panda third = new Panda();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"У ПАНД \"{first.name}\" И \"{second.name}\" РОДИЛАСЬ МАЛЕНЬКАЯ ПАНДА!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                third.color = second.color;
                return third;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ОБА РОДИТЕЛЯ С ОДИНАКОВЫМ ПОЛОМ! СОЗДАТЬ НОВУЮ ПАНДУ НЕВОЗМОЖНО! ПРЕЗАПУСТИТЕ ПРОГРАММУ!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                return null;
            }


        }
        public static Panda operator- ( Panda first, Panda second) //Переопределение оператора "-"
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ПАНДА \"{first.name}\" НАПАДАЕТ НА ПАНДУ \"{second.name}\", НО ОНА ОСТАЛАСЬ ЖИВА!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            second.hp = second.hp - (first.attack - second.defence);
            if (second.hp < 1) second.hp = 1;
            return second;
        }
        public override bool Equals(object obj) //Сравнение панд по здоровью и весу вместе
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Panda))
            {
                return false;
            }

            if ((this.hp == ((Panda)obj).hp) & (this.color == (((Panda)obj).color)))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"У панд {this.name} и {((Panda)obj).name} одинаковый вес и цвет!");
                Console.ForegroundColor = ConsoleColor.Gray;
                return true;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"У панд \"{this.name}\" и \"{((Panda)obj).name}\" не одинаковый вес и/или цвет!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
        }
       public override int GetHashCode()
       {
            return this.name.GetHashCode();
       }
    }
} 

  

