namespace _Cone
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Cone firstCone = new Cone(5, 10); //Создание объектных переменных с введение радиуса и высоты
            Cone secondCone = new Cone(10, 20);

            Console.WriteLine("Площадь основания первого цилиндра: " + Math.Round(firstCone.AreaOfBase(), 2) + " см2"); //Вывод результатов с округлением до сотых
            Console.WriteLine("Полная площадь первого цилиндра: " + Math.Round(firstCone.AreaTotal(), 2) + " см2");
            Console.WriteLine();
            Console.WriteLine("Площадь основания второго цилиндра: " + Math.Round(secondCone.AreaOfBase(), 2) + " см2");
            Console.WriteLine("Полная площадь второго цилиндра: " + Math.Round(secondCone.AreaTotal(), 2) + " см2");


        }
    }
}
