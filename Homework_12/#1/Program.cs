namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("рев" , "коричневый");
            Cat cat = new Cat("мяуканье", "белый");
            Elephant elephant = new Elephant("трубление", "серый");
            Elephant elephant1 = new Elephant("трубление", "свето-серый");
            Zoo zoo = new Zoo();

            zoo.AddToPaddock(bear);
            zoo.AddToPaddock(cat);
            zoo.AddToPaddock(elephant);
            zoo.AddToPaddock(elephant1);

            zoo.ShowPaddocks();

            Console.WriteLine(elephant.Equals(elephant1));            
        }
    }
}
