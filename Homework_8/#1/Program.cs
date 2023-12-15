using _Item;

namespace Homework_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Item itm = new Item();
            
            Console.WriteLine(itm.GetName());
            
            itm.SetName("IT Academy");
            
            Console.WriteLine(itm.GetName());
        }
    }
}
