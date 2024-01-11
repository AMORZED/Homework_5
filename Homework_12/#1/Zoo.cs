using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Zoo : ISorting
    {
        Animal[] paddockC = new Animal[5];
        Animal[] paddockH = new Animal[5];

        public void AddToPaddock(object animal)
        {
            if (animal is Elephant)
            {
                Elephant elephant = (Elephant)animal;
                for (int i = 0; i < paddockH.Length; i++)
                {
                    if (paddockH[i] == null)
                    {
                        paddockH[i] = elephant;
                        break;
                    }
                    else if ((i < paddockC.Length) == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("В загоне для травоядных нет места!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                for (int i = 0; i < paddockC.Length; i++)
                {
                    if (paddockC[i] == null)
                    {
                        paddockC[i] = cat;
                        break;
                    }
                    else if ((i < paddockC.Length) == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("В загоне для хищников нет места!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
            if (animal is Bear)
            {
                Bear bear = (Bear)animal;
                for (int i = 0; i < paddockC.Length; i++)
                {
                    if (paddockC[i] == null)
                    {
                        paddockC[i] = bear;
                        break;
                    }
                    else if ((i < paddockC.Length) == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("В загоне для хищников нет места!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
        }
        public void ShowPaddocks()
        {
            Console.WriteLine();
            Console.WriteLine("Загон для плотоядных:");
            for (int i = 0; i < paddockH.Length; i++)
            {
                if (paddockH[i] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("- Место свободно -");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (paddockH[i] != null)
                {
                    paddockH[i].displayAnimal();
                }

            }
            Console.WriteLine();

            Console.WriteLine("Загон для хищников:");
            for (int i = 0; i < paddockC.Length; i++)
            {
                if (paddockC[i] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("- Место свободно -");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (paddockC[i] != null)
                {
                    paddockC[i].displayAnimal();
                }
            }
            Console.WriteLine();
        }

    }
}
