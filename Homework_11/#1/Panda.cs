using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Panda
    {
        Random rnd = new Random();
        enum Gender { Male = 1, Femail = 2 };
        enum Color { WhiteBlack = 1, Black = 2, White = 3 };
        
        private Gender gender = 0;        
        private Color color = 0;
        private int hp { get; set; }
        private int attack { get; set; }
        private int defence { get; set; }
        private string name = null;

        public Panda ()
        {
            SetName();
            SetGender();
            SetColor();
            SetHP();
            SetAttack();
            SetDefence();
        }
        public Panda(string name)
        {
            this.name = name;
            SetGender();
            SetColor();
            SetHP();
            SetAttack();
            SetDefence();
        }

        public void SetName() //Ввод имени для панды
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите имя новой панды:");
            Console.ForegroundColor = ConsoleColor.Gray;
            this.name = Convert.ToString(Console.ReadLine());
        }
        public void SetGender() //Случайный пол
        {
            int random = rnd.Next(1, 3);
            this.gender = (Gender)random;
        }
        public void SetColor() //Случайный цвет
        {
            int random = rnd.Next(1, 4);
            this.color = (Color)random;
        }

        public void SetHP() //Здоровье принимает значение 1-100
        {
            int random = rnd.Next(1, 101);
            this.hp = random;
        }
        public void SetAttack() //Атака принимает значение 5-10
        {
            int random = rnd.Next(5, 11);
            this.attack = random;
        }
        public void SetDefence() //Защита принимает значение 1-5
        {
            int random = rnd.Next(1, 6);
            this.defence = random;
        }
        public void ShowStats() //Вывод характеристик панды на экран
        {
            Console.WriteLine("----------");
            Console.WriteLine($"Характеристики панды \"{this.name}\":");
            Console.WriteLine();
            Console.WriteLine($"Пол: {this.gender}");
            Console.WriteLine($"Цвет: {this.color}");
            Console.WriteLine($"Здоровье: {this.hp} оз.");
            Console.WriteLine($"Атака: {this.attack} ур/с.");
            Console.WriteLine($"Защита: {this.defence} оз.");
            Console.WriteLine("----------");
        }

        public static Panda operator+ ( Panda first, Panda second ) //Переопределение оператора "+"
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 3);            
            if (random == 1 & first.gender != second.gender)
            {
                Panda third = new Panda();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"У ПАНД \"{first.name}\" И \"{second.name}\" РОДИЛАСЬ МАЛЕНЬКАЯ ПАНДА!");
                Console.ForegroundColor = ConsoleColor.Gray;
                third.color = first.color;
                return third;
            }
            else if (random == 2 & first.gender != second.gender)
            {
                Panda third = new Panda();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"У ПАНД \"{first.name}\" И \"{second.name}\" РОДИЛАСЬ МАЛЕНЬКАЯ ПАНДА!");
                Console.ForegroundColor = ConsoleColor.Gray;
                third.color = second.color;
                return third;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Оба родителя с одинаковым полом! Создать новую панду невозможно! Перезапустите программу!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                return null;
            }


        }
        public static Panda operator- ( Panda first, Panda second) //Переопределение оператора "-"
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ПАНДА \"{first.name}\" НАПАДАЕТ НА ПАНДУ \"{second.name}\", НО ОНА ОСТАЛАСЬ ЖИВА!");
            Console.ForegroundColor = ConsoleColor.Gray;
            second.hp = second.hp - (first.attack - second.defence);
            if (second.hp < 1) second.hp = 1;
            return second;
        }
        public static void CompareHP (Panda a, Panda b) //Сравнение панд по здоровью
        {
            Console.ForegroundColor= ConsoleColor.Blue;

            if (a.hp > b.hp) Console.WriteLine($"У панды {a.name} больше здоровья, чем у панды {b.name}!");
            else if (a.hp == b.hp) Console.WriteLine($"У панды {a.name} столько же здоровья, как и у панды {b.name}!");
            else Console.WriteLine($"У панды {a.name} меньше здоровья, чем у панды {b.name}!");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void CompareColor(Panda a, Panda b) //Сравнение панд по цвету
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if (a.color == b.color) Console.WriteLine($"У панд {a.name} и {b.name} одинаковый цвет!");
            else Console.WriteLine($"У панд {a.name} и {b.name} разный цвет!");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    

  
}
