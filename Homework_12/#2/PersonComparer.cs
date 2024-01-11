using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class PersonComparer : IComparer<Person?>
    {
        public int Compare(Person first, Person second)
        {            
                if (first.GetGender() != second.GetGender() & first.GetGender() == 2)
                {
                    return -1;
                }
                if (first.GetGender() != second.GetGender() & first.GetGender() == 1)
                {
                    return 1;
                }
                if (first.GetGender() == 2 & first.GetGender() == second.GetGender() & first.GetAge() > second.GetAge())
                {
                    return 1;
                }
                if (first.GetGender() == 1 & first.GetGender() == second.GetGender() & first.GetAge() > second.GetAge())
                {
                    return 1;
                }
                if (first.GetGender() == 2 & first.GetGender() == second.GetGender() & first.GetAge() <= second.GetAge())
                {
                    return -1;
                }
                if (first.GetGender() == 1 & first.GetGender() == second.GetGender() & first.GetAge() <= second.GetAge())
                {
                    return -1;
                }
                else return 0;
            
        }           
    }
    
}
