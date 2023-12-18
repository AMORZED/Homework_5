using _Bag;
using _Item;
using System.Data;

namespace Homework_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bag Bag = new Bag();
            Item Item_1 = new Item("Книга");
            Item Item_2 = new Item("Ноутбук");

            Bag.OpenBag();
            Bag.AddItemInBag(Item_1);
            Bag.AddItemInBag(Item_2);
            Bag.Show();
            Bag.GetItem(1);
            Bag.Show();
        }
    }
}
