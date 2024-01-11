using System;
using System.Security.Cryptography.X509Certificates;

namespace _2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listOfPerson = new List<Person>();
            listOfPerson.Add(new Person("Tom", 1));
            listOfPerson.Add(new Person("Bob", 1));
            listOfPerson.Add(new Person("Sam", 1));
            listOfPerson.Add(new Person("Alex", 1));
            listOfPerson.Add(new Person("John", 1));

            listOfPerson.Add(new Person("Abby", 2));
            listOfPerson.Add(new Person("Alisha", 2));
            listOfPerson.Add(new Person("Darla", 2));
            listOfPerson.Add(new Person("Carol", 2));
            listOfPerson.Add(new Person("Bonnie", 2));

            listOfPerson.Sort();
            ShowList();
            Console.WriteLine();
            listOfPerson.Sort(new PersonComparer());
            ShowList();


            void ShowList()
            {
                for (int i = 0; i < listOfPerson.Count; i++)
                {
                    Console.WriteLine($"{listOfPerson[i].GetName()}, {listOfPerson[i].GetAge()}");
                }
            }
        }
    }
}
