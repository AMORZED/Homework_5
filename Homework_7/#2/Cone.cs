using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _Cone
{
    public class Cone
    {
        public double Radius;
        public double Height;
        public Cone(double R, double H) //Конструктор присваивает значения радиуса и высоты соответствующим полям
        {
            Radius = R;
            Height = H;
        }

        public double AreaOfBase() //Площадь основания
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double AreaTotal() //Полная площадь
        {
            return (Math.PI * Math.Pow(Radius, 2) + Math.PI * Radius * (Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2))));
        }
    }
}
