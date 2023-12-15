using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Item
{
    public class Item
    {
        private object Name = "Unknown";

        public void SetName(string newValue) 
        { 
            Name = newValue;
        }
        public object GetName() 
        {
            return Name;
        }
    }
}
 