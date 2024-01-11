using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private enum Gender { male = 1, female = 2 }
        private Gender gender;

        public Person(string name, byte i)
        {
            this.name = name;
            this.gender = (Gender)i;
            SetRandomAge();
        }
        public Person(string name, byte i, int j)
        {
            this.name = name;
            this.gender = (Gender)i;
            SetAge(j);
        }

        private void SetAge(int i)
        {
            this.age = i;
        }

        private void SetRandomAge()
        {
            Random rnd = new Random();
            this.age = (int)rnd.Next(18, 46);
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetName()
        {
            return name;
        }
        public int GetGender() 
        { 
            return (int)this.gender;
        }
        
        public int CompareTo(Person? prs)
        {
            if (prs is Person)
            {
                if (this.gender != prs.gender & this.gender == Gender.female)
                {
                    return -1;
                }
                if (this.gender != prs.gender & this.gender == Gender.male)
                {
                    return 1;
                }
                if (this.gender == Gender.female & this.gender == prs.gender & this.age > prs.age)
                {
                    return 1;
                }
                if (this.gender == Gender.male & this.gender == prs.gender & this.age > prs.age)
                {
                    return 1;
                }
                if (this.gender == Gender.female & this.gender == prs.gender & this.age <= prs.age)
                {
                    return -1;
                }
                if (this.gender == Gender.male & this.gender == prs.gender & this.age <= prs.age)
                {
                    return -1;
                }
                else return 0;
            }
            else throw new ArgumentException();
        }

    }

}
