namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water();
            GroundGrains grains = new GroundGrains();
            water.Show();
            grains.Show();

            Coffee coffee = water + grains;
            coffee.Show();
        }
    }
}
