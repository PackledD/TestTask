using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalc.interfaces;

namespace AreaCalc.figures
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            // Проверка валидности радиуса
            if (radius < 0.0)
            {
                throw new ArgumentException("Radius can't be negative");
            }
            _radius = radius;
        }

        public double Area => Math.PI * _radius * _radius;
    }
}
