using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Item
{
    public class Item
    {
        private string Name = "Unknown";

        public Item(string name) 
        {
            SetName(name);
        }

        public void SetName(string newName) 
        { 
            Name = newName;
        }
        public string GetName() 
        {
            return Name;
        }
    }
}
 