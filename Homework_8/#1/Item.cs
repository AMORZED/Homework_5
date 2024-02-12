namespace _Item
{
    public class Item
    {
        public Item() { }

        public Item(string name)
        {
            this.name = name;
        }
        public void SetName(string newName) 
        { 
            this.name = newName;
        }
        public string GetName() 
        {
            return this.name;
        }

        private string name = "Unknown";
    }
}
 