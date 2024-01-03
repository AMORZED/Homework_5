namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda a = new Panda("CJ"); //Создание первой панды
            a.ShowStats();

            Panda b = new Panda("BigSmoke"); //Создание второй панды
            b.ShowStats();

            a.Equals(b);

            Panda c = a + b; //Создание ребенка панды
            c.ShowStats();

            Panda d = a - b; //Мочиловка между двумя пандами
            d.ShowStats();

           
        }
    }
}
