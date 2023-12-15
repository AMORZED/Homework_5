using _Bag;
using _Item;
using System.Data;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bag b = new Bag();
            Item it = new Item();
            b.Show();
            b.AddItemInBag();
            b.OpenBag();
            b.AddItemInBag();
            b.Show();

        }
    }
}
