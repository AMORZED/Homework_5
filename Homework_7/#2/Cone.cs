namespace _Cone
{
    public class Cone
    {
        public double Radius { get; private set; }
        public double Height { get; private set; }

        public Cone(double R, double H) //Конструктор присваивает значения радиуса и высоты соответствующим полям
        {
            this.Radius = R;
            this.Height = H;
        }

        public void AreaOfBase() //Площадь основания
        {
            double areaOfBase = Math.Round(Math.PI * Math.Pow(this.Radius, 2), 2);
            Console.WriteLine($"Площадь основания цилиндра: {areaOfBase} см2");
        }
        public void AreaTotal() //Полная площадь
        {
            double areaTotal = Math.Round(Math.PI * Math.Pow(this.Radius, 2) + Math.PI * this.Radius * Math.Sqrt(Math.Pow(this.Radius, 2) + Math.Pow(this.Height, 2)), 2);
            Console.WriteLine($"Полная площадь цилиндра: {areaTotal} см2");
        }

    }
}
